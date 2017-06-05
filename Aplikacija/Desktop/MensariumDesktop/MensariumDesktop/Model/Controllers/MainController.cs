using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MensariumDesktop.Forms;
using MensariumDesktop.Model.Components;
using MensariumDesktop.Model.Components.DTOs;
using System.Drawing;

namespace MensariumDesktop.Model.Controllers
{
    public static class MainController
    {
        public static Student LoadedCardUser;

        public static void InitApplication()
        {
            //Ucitaj podatke iz fajl
            MSettings.Server = new Server();
        }

        public static void PostLoginInit()
        {
            Faculty.UpdateFacultyList(); 
            Mensa.UpdateMensaList();
            Mensa.LoadPrices();
            MSettings.LoadSettings();
        }
        public static void Shutdown()
        {
            LogoutUser();
            MSettings.SaveSettings();
            Application.Exit();
        }
        public static bool TestConnection(string hostname, string port)
        {
            try
            {
                MUtility.ShowInformation(Api.TestConnection(hostname, port));
                return true;
            }
            catch (Exception ex)
            {
                MUtility.ShowInformation(ex.Message);
                return false;
            }
        }
        public static bool LoginUser(string username, string password)
        {
            ClientLoginDto clog = new ClientLoginDto{ KIme_Mail = username, Sifra = password };
            try
            {
                SesijaDto sesija = Api.LoginUser(clog);
                MSettings.CurrentSession = new Session() { SessionID = sesija.IdSesije };
                
                KorisnikFullDto korisnik = Api.GetUserFullInfo(sesija.IdKorisnika);
                if (korisnik.IdTipaNaloga == (int)User.UserAccountType.Student)
                {
                    MUtility.ShowError("Prijavljivanje sa studentskog naloga je onemoguceno na ovoj aplikaciji!");
                    Api.LogoutUser(MSettings.CurrentSession.SessionID);
                    return false;
                }
                MSettings.CurrentSession.LoggedUser = MUtility.GenerateUserFromDTO(korisnik);
                return true;
            }
            catch (Exception ex)
            {
                MSettings.CurrentSession = null;
                MUtility.ShowException(ex);
                return false;
            }
        }
        public static bool LogoutUser()
        {
            try
            {
                if (MSettings.CurrentSession != null)
                    Api.LogoutUser(MSettings.CurrentSession.SessionID);
                
                MSettings.CurrentSession = null;
            }
            catch (Exception ex)
            {
                ShowException(ex);
                return false;
            }
            return true;
        }

        public static bool ChangeServerIP(string newIP)
        {
            try
            {
                MSettings.Server.IP = newIP;
                Api.UpdateBaseUrl();
                return true;
            }
            catch(Exception e)
            {
                MUtility.ShowException(e);
                return false;
            }
        }
        public static bool ChangeServerPort(string newPort)
        {
            try
            {
                MSettings.Server.Port = newPort;
                Api.UpdateBaseUrl();
                return true;
            }
            catch (Exception e)
            {
                MUtility.ShowException(e);
                return false;
            }
        }
        public static bool ChangeServer(string newIP, string newPort)
        {
            return ChangeServerIP(newIP) && ChangeServerPort(newPort);
        }
        public static bool ChangeCurrentMensa(Mensa m)
        {            
            if (m == null)
                return false;
            MSettings.CurrentMensa = m;
            return true;
        }

        public static void LoadUserCard(int cardId)
        {
            try
            {
                KorisnikFullDto korisnik = Api.GetUserFullInfo(cardId);
                if (korisnik.IdTipaNaloga != (int)User.UserAccountType.Student)
                    throw new Exception("Nalog nije studentski");
                LoadedCardUser = MUtility.GenerateUserFromDTO(korisnik) as Student;
                KorisnikStanjeDto stanje = Api.UserMealsCount(LoadedCardUser.UserID);
                LoadedCardUser.BreakfastCount =  stanje.BrojDorucka;
                LoadedCardUser.LunchCount =  stanje.BrojRuckova;
                LoadedCardUser.DinnerCount =  stanje.BrojVecera;
            }
            catch(Exception ex)
            {
                MUtility.ShowException(ex);
            }
        }
        public static void AddUserMeal(Student s, MealType type, int count)
        {
            if (count <= 0)
                return;

            ObrokUplataDto o = new ObrokUplataDto()
            {
                BrojObroka = count,
                IdLokacijeUplate = MSettings.CurrentMensa.MensaID,
                IdKorisnika = s.UserID,
                IdTipa = (int)type
            };
            try
            {
                Api.AddMeal(o);
            }
            catch(Exception e)
            {
                MUtility.ShowException(e);
            }
        }
        public static void AddUserMeals(Student s, int breakfast, int lunch, int dinner)
        {
            AddUserMeal(s, MealType.Dorucak, breakfast);
            AddUserMeal(s, MealType.Rucak, lunch);
            AddUserMeal(s, MealType.Vecera, dinner);
        }

        public static List<MealReclamation> GetReclamationMeals(Student s, ReclamationForm.Mode m)
        {
            try
            {
                List<ObrokReklamacijaDto> list = (m == ReclamationForm.Mode.PogresnaUplata)
                    ? Api.TodayAddedMeals(s.UserID)
                    : Api.TodayUsedMeals(s.UserID);
               
                List<MealReclamation> rlist = new List<MealReclamation>();
                foreach (var obrok in list)
                {
                    rlist.Add(new MealReclamation()
                    {
                        Id = obrok.IdObroka,
                        DateAdded = obrok.Datum,
                        Type = (MealType)obrok.IdTipaObroka,
                        Mensa = Mensa.Mensas.Find(x => x.MensaID == obrok.IdTipaObroka)
                    });
                }
                return rlist;
            }
            catch (Exception e)
            {
                MUtility.ShowException(e);
                return new List<MealReclamation>();
            }
        }
        public static bool UndoAddMeals(MealReclamation meal)
        {
            try
            {
                Api.UndoAddMeals(meal.Id);
                return true;
            }
            catch (Exception e)
            {
                MUtility.ShowException(e);
                return false;
            }
        }
        public static bool UndoUseMeals(MealReclamation meal)
        {
            try
            {
                Api.UndoUseMeals(meal.Id);
                return true;
            }
            catch (Exception e)
            {
                MUtility.ShowException(e);
                return false;
            }
        }

        public static bool UseMeal(MealType type)
        {
            try
            {

                ObrokNaplataDto o = new ObrokNaplataDto();
                o.BrojObroka = 1;
                o.IdKorisnika = MainController.LoadedCardUser.UserID;
                o.IdLokacijeIskoriscenja = MSettings.CurrentMensa.MensaID;
                o.IdTipa = (int) type;

                Api.UseMeal(o);
                return true;
            }
            catch (Exception e)
            {
                MUtility.ShowException(e);
                return false;
            }

        }
        


        public static void ShowError(string Message) {
            MessageBox.Show(Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowException(Exception e) {
            MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowWarrning(string message) {
            MessageBox.Show(message, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void ShowInformation(string message) {
            MessageBox.Show(message, "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
