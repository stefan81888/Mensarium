using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MensariumDesktop.Model.Components;
using MensariumDesktop.Model.Components.DTOs;
using RestSharp.Extensions;
using System.Windows.Forms;
using System.Drawing;

namespace MensariumDesktop.Model.Controllers
{
    public static class MUtility
    {
        public static User GenerateUserFromDTO(KorisnikFullDto korisnik)
        {
            Student u = new Student();

            u.AccountType = (User.UserAccountType)korisnik.IdTipaNaloga;
            u.Birthday = korisnik.DatumRodjenja;
            if (korisnik.Email != null) u.Email = korisnik.Email;
            u.FirstName = korisnik.Ime;
            u.LastName = korisnik.Prezime;
            u.PhoneNumber = korisnik.BrojTelefona;
            u.RegistrationDate = korisnik.DatumRegistracije;
            u.UserID = korisnik.IdKorisnika;
            if (korisnik.KorisnickoIme != null) u.Username = korisnik.KorisnickoIme;
            u.ActiveAccount = korisnik.AktivanNalog;

            u.ProfilePicture = Api.GetUserImage(u.UserID);

            if (u.AccountType == User.UserAccountType.Student)
            {
                u.ValidUntil = (DateTime)korisnik.DatumVaziDo;
                u.Index = korisnik.BrojIndeksa;
                u.Faculty = Faculty.Faculties.Find(x => x.FacultyID == korisnik.IdFakulteta);
                return u;
            }  
            return u as User;
        }
        public static Faculty Faculty_From_FakultetFullDto(FakultetFullDto f)
        {
            return new Faculty() {FacultyID = f.IdFakultet, Name = f.Naziv };
        }
        public static List<Faculty> FacultyList_FromFakultetiFullDto(List<FakultetFullDto> flist)
        {
            List<Faculty> fl = new List<Faculty>();

            foreach (FakultetFullDto f in flist)
            {
                fl.Add(Faculty_From_FakultetFullDto(f));
            }

            return fl;
        }

        public static Mensa Mensa_From_MenzaFullDto(MenzaFullDto mensa)
        {
            return new Mensa()
            {
                MensaID = mensa.IdMenze,
                Name = mensa.Naziv,
                Location = mensa.Lokacija,
                CurrentlyClosed = mensa.VanrednoNeRadi,
                WorkTime = mensa.RadnoVreme
            };
        }
        public static List<Mensa> MensaList_FromMensaFullDto(List<MenzaFullDto> mlist)
        {
            List<Mensa> ml = new List<Mensa>();

            foreach (var m in mlist)
            {
                ml.Add(Mensa_From_MenzaFullDto(m));
            }

            return ml;
        }

        public static void RoundPictureBox(PictureBox t)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            
            gp.AddEllipse(0, 0, t.Width - 1, t.Height - 1);
            Region rg = new Region(gp);
            
            t.Region = rg;
        }
    }
}
