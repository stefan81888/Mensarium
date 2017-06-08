using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MensariumDesktop.Forms;
using MensariumDesktop.Model;
using MensariumDesktop.Model.Components;
using MensariumDesktop.Model.Components.DTOs;
using MensariumDesktop.Model.Controllers;
using RestSharp;
using System.Threading;

namespace MensariumDesktop
{
    public partial class MainForm : Form
    {
        #region MAIN_FORM
        LoadingForm loadform = new LoadingForm();
        public MainForm()
        {
            InitializeComponent();
            bgWorkerLoading.RunWorkerAsync();
            loadform.ShowDialog();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            HOME_lblCurrentUserFName.Text = MSettings.CurrentSession.LoggedUser.FirstName;
            HOME_lblCurrentUserLName.Text = MSettings.CurrentSession.LoggedUser.LastName;
            HOME_lblCurrentUserAccType.Text = MSettings.CurrentSession.LoggedUser.AccountType.ToString();
            HOME_picCurrentUser.Image = MSettings.CurrentSession.LoggedUser.ProfilePicture;
            HOME_lblCurrentLocation.Text = MSettings.CurrentMensa.Name;
            HOME_lblCurrentLocationAddress.Text = MSettings.CurrentMensa.Location;

            UPLATA_lblBreakfastPrice.Text = MSettings.PriceBreakfast.ToString();
            UPLATA_lblLunchPrice.Text = MSettings.PriceLunch.ToString();
            UPLATA_lblDinnerPrice.Text = MSettings.PriceDinner.ToString();

            KORSN_cbxAccTypeChooser.SelectedIndex = 2;
            RefreshStatusBarData();

            switch (MSettings.CurrentSession.LoggedUser.AccountType)
            {
                case User.UserAccountType.Menadzer:
                    tabControls.TabPages.Remove(tabAdmin);
                    tabControls.TabPages.Remove(tabNaplata);
                    tabControls.TabPages.Remove(tabUplata);
                    break;
                case User.UserAccountType.Uplata:
                    tabControls.TabPages.Remove(tabAdmin);
                    tabControls.TabPages.Remove(tabNaplata);
                    tabControls.TabPages.Remove(tabUsers);
                    break;
                case User.UserAccountType.Naplata:
                    tabControls.TabPages.Remove(tabAdmin);
                    tabControls.TabPages.Remove(tabUplata);
                    tabControls.TabPages.Remove(tabUsers);
                    break;
            }
            
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            STATUS_statbarUserSignOut.PerformClick();
        }
        #endregion

        #region STATUS BAR
        private void RefreshStatusBarData()
        {
            STATUS_statbarUser.Text = MSettings.CurrentSession.LoggedUser.FullName;
            STATUS_statbarMenza.Text = MSettings.CurrentMensa.Name;
            HOME_lblCurrentLocation.Text = MSettings.CurrentMensa.Name;
            HOME_lblCurrentLocationAddress.Text = MSettings.CurrentMensa.Location;
        }
        private void OpStatusWorking()
        {
            //STATUS_statbarOPStatus.Visible = true;
            STATUS_statbarOPStatus.Image = imageListOPStatus.Images["internet.png"];
            Cursor.Current = Cursors.AppStarting;
        }
        private void OpStatusIdle()
        {
            //STATUS_statbarOPStatus.Visible = false;
            STATUS_statbarOPStatus.Image = null;
            Cursor.Current = Cursors.Default;
        }
        private void statusBarSettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsForm fs = new SettingsForm();
            fs.ShowDialog();
            RefreshStatusBarData();
        }
        private void statbarUserProfile_Click(object sender, EventArgs e)
        {
            ProfileForm f = new ProfileForm(MSettings.CurrentSession.LoggedUser);
            f.ShowDialog();
            RefreshStatusBarData();
        }
        private void statbarUserSignOut_Click(object sender, EventArgs e)
        {
            try
            {
                bgWorkerLoading.DoWork += (sender2, args) => bgWorkerLoading_DoWorkLogOut();
                this.Hide();
                bgWorkerLoading.RunWorkerAsync();
                loadform.TextToDisplay = "Odjavljivanje";
                loadform.ShowDialog();
            }
            catch (Exception ex)
            {
                MUtility.ShowException(ex);
            }

        }
        private void promeniLokacijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MensaChangerForm mc = new MensaChangerForm();
            mc.ShowDialog();
            RefreshStatusBarData();
            
        }
        #region DEBUG
        private void showLoginFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }
        private void showReclamationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void showMensaChangerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MensaChangerForm mc = new MensaChangerForm();
            mc.ShowDialog();

        }
        private void showProfileFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void showUserFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.ShowDialog();
        }
        private void showNewUserCreatedFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void dEBUGMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try { pcbCurrentUser.Image = Api.GetUserImage(2); } catch (Exception exception) { MessageBox.Show(exception.Message); }
            //try { Api.FollowUser(9); } catch (Exception exception) { MessageBox.Show(exception.Message); } //forbidden
            //try { Api.AndroidUserRegistration(new ClientZaRegistracijuDto()); } catch (Exception exception) { MessageBox.Show(exception.Message); } 
            //try { Api.UsersThatFollows(); } catch (Exception exception) { MessageBox.Show(exception.Message); }
            //try { Api.SearchUsers(new PretragaKriterijumDto()); } catch (Exception exception) { MessageBox.Show(exception.Message); }
            //try { Api.UserMealsCount(); } catch (Exception exception) { MessageBox.Show(exception.Message); }
            //try { Api.UserPriviledges(); } catch (Exception exception) { MessageBox.Show(exception.Message); } 
            //try { Api.InviteUser(new PozivanjaFullDto()); } catch (Exception exception) { MessageBox.Show(exception.Message); }//NOT FOUND
            //try { Api.UserCalledBy(); } catch (Exception exception) { MessageBox.Show(exception.Message); }//null kad nevalidan
            //try { Api.Respond2Invite(new PozivanjaPozvaniDto()); } catch (Exception exception) { MessageBox.Show(exception.Message); }
            //try { Api.Unfolow(22); } catch (Exception exception) { MessageBox.Show(exception.Message); }
            //try { Api.UpdateUser(new KorisnikKreiranjeDto()); } catch (Exception exception) { MessageBox.Show(exception.Message); }

        }
        #endregion
        #endregion

        #region POCETNA_TAB
        private void HOME_btnSignOut_Click(object sender, EventArgs e)
        {
            STATUS_statbarUserSignOut.PerformClick();
        }
        private void HOME_MensaChanger_Click(object sender, EventArgs e)
        {
            STATUS_statbarMenzaChangeLocation.PerformClick();
        }
        private void HOME_btnSettings_Click(object sender, EventArgs e)
        {
            STATUS_statbarSettings.PerformClick();
        }
        private void HOME_btnProfile_Click(object sender, EventArgs e)
        {
            STATUS_statbarUserProfile.PerformClick();
        }
        private void HOME_picCurrentUser_Paint(object sender, PaintEventArgs e)
        {
            MUtility.RoundPictureBox(sender as PictureBox);
        }
        #endregion

        #region UPLATA_TAB
        private void UPLATA_RefreshCardInfo(bool reload = false)
        {
            if (MainController.LoadedCardUser == null)
                return;

            UPLATA_lblCardUserName.Text = MainController.LoadedCardUser.FullName;
            UPLATA_lblCardUserValidUntil.Text = MainController.LoadedCardUser.ValidUntil.ToShortDateString();
            UPLATA_lblCardUserDatebirth.Text = MainController.LoadedCardUser.Birthday.ToShortDateString();
            UPLATA_lblCardUserFax.Text = MainController.LoadedCardUser.Faculty.Name;
            UPLATA_lblCardUserIndex.Text = MainController.LoadedCardUser.Index;
            UPLATA_picLoadedUser.Image = MainController.LoadedCardUser.ProfilePicture;

            string b = UPLATA_lblBreakfast.Text;
            string l = UPLATA_lblLunch.Text;
            string d = UPLATA_lblDinner.Text;

            UPLATA_lblBreakfast.Text = MainController.LoadedCardUser.BreakfastCount.ToString();
            UPLATA_lblLunch.Text = MainController.LoadedCardUser.LunchCount.ToString();
            UPLATA_lblDinner.Text = MainController.LoadedCardUser.DinnerCount.ToString();

            UPLATA_lblBreakfast.BackColor = Color.Transparent;
            UPLATA_lblLunch.BackColor = Color.Transparent;
            UPLATA_lblDinner.BackColor = Color.Transparent;
            if (reload)
            {
                if (b != UPLATA_lblBreakfast.Text) UPLATA_lblBreakfast.BackColor = Color.LightGreen;
                if (l != UPLATA_lblLunch.Text) UPLATA_lblLunch.BackColor = Color.LightGreen;
                if (d != UPLATA_lblDinner.Text) UPLATA_lblDinner.BackColor = Color.LightGreen;
            }
        }
        private void UPLATA_btnLoadCard_Click(object sender, EventArgs e)
        {
            CardReaderEmulator creader = new CardReaderEmulator();
            creader.ShowDialog();
            OpStatusWorking();
            MainController.LoadUserCard(creader.CardData);
            OpStatusIdle();

            UPLATA_RefreshCardInfo();
        }
        private void UPLATA_picLoadedUser_Paint(object sender, PaintEventArgs e)
        {
            MUtility.RoundPictureBox(sender as PictureBox);
        }
        private void UPLATA_btnExecutePay_Click(object sender, EventArgs e)
        {
            if (MainController.LoadedCardUser == null)
            {
                MUtility.ShowWarrning("Prvo ucitati korisnika");
                return;
            }
            OpStatusWorking();
            int b, l, d;
            bool succ = true;
            succ &= int.TryParse(UPLATA_txtBreakfast.Text, out b);
            succ &= int.TryParse(UPLATA_txtLunch.Text, out l);
            succ &= int.TryParse(UPLATA_txtDinner.Text, out d);
            if (!succ)
            {
                MUtility.ShowError("Nisu svi uneti podaci validni");
                return;
            }
            MainController.AddUserMeals(MainController.LoadedCardUser, b, l, d);
            MainController.LoadUserCard(MainController.LoadedCardUser.UserID);
            UPLATA_RefreshCardInfo(true);
            OpStatusIdle();

        }
        private void UPLATA_txtBreakfast_TextChanged(object sender, EventArgs e)
        {
            UPLATA_RefreshNCalucatePrice();
        }
        private void UPLATA_txtLunch_TextChanged(object sender, EventArgs e)
        {
            UPLATA_RefreshNCalucatePrice();
        }
        private void UPLATA_txtDinner_TextChanged(object sender, EventArgs e)
        {
            UPLATA_RefreshNCalucatePrice();
        }

        private void UPLATA_RefreshNCalucatePrice()
        {
            UPLATA_lblBreakfastCount.Text = UPLATA_txtBreakfast.Text;
            UPLATA_lblLunchCount.Text = UPLATA_txtLunch.Text;
            UPLATA_lblDinnerCount.Text = UPLATA_txtDinner.Text;
            UPLATA_CalucatePrice();
        }
        private void UPLATA_CalucatePrice()
        {
            int Total = 0, b,l,d;

            int.TryParse(UPLATA_lblBreakfastCount.Text, out b);
            int.TryParse(UPLATA_lblLunchCount.Text, out l);
            int.TryParse(UPLATA_lblDinnerCount.Text, out d);

            UPLATA_txtBreakfastTotal.Text = (MSettings.PriceBreakfast * b).ToString();
            UPLATA_txtLunchTotal.Text = (MSettings.PriceLunch * l).ToString();
            UPLATA_txtDinnerTotal.Text = (MSettings.PriceDinner * d).ToString();

            Total = MSettings.PriceBreakfast * b + MSettings.PriceLunch * l + MSettings.PriceDinner * d;
            UPLATA_lblTotalPrice.Text = Total.ToString() + " din";
        }
        private void UPLATA_btnReclamation_Click(object sender, EventArgs e)
        {
            User s = MainController.LoadedCardUser;
            if (s == null)
            {
                MUtility.ShowWarrning("Prvo ucitati korisnika");
                return;
            }

            ReclamationForm rf = new ReclamationForm(MainController.LoadedCardUser, ReclamationForm.Mode.PogresnaUplata);
            rf.ShowDialog();

            OpStatusWorking();
            MainController.LoadUserCard(MainController.LoadedCardUser.UserID);
            UPLATA_RefreshCardInfo();
            OpStatusIdle();
        }
        #endregion

        #region NAPLATA_TAB
        private void NAPLATA_picLoadedUser_Paint(object sender, PaintEventArgs e)
        {
            MUtility.RoundPictureBox(sender as PictureBox);
        }
        private void NAPLATA_btnLoadCard_Click(object sender, EventArgs e)
        {
            CardReaderEmulator creader = new CardReaderEmulator();
            creader.ShowDialog();
            OpStatusWorking();
            MainController.LoadUserCard(creader.CardData);
            OpStatusIdle();
            NAPLATA_RefreshCardInfo();
        }
        private void NAPLATA_RefreshCardInfo(bool keepIcons = false)
        {
            if (MainController.LoadedCardUser == null)
                return;

            NAPLATA_lblUserName.Text = MainController.LoadedCardUser.FullName;
            NAPLATA_lblUserValidUntil.Text = MainController.LoadedCardUser.ValidUntil.ToShortDateString();
            NAPLATA_lblUserBday.Text = MainController.LoadedCardUser.Birthday.ToShortDateString();
            NAPLATA_lblUserFax.Text = MainController.LoadedCardUser.Faculty.Name;
            NAPLATA_lblUserIndex.Text = MainController.LoadedCardUser.Index;
            NAPLATA_picLoadedUser.Image = MainController.LoadedCardUser.ProfilePicture;

            NAPLATA_lblBreakfastCount.Text = MainController.LoadedCardUser.BreakfastCount.ToString();
            NAPLATA_lblLunchCount.Text = MainController.LoadedCardUser.LunchCount.ToString();
            NAPLATA_lblDinnerCount.Text = MainController.LoadedCardUser.DinnerCount.ToString();
            if (!keepIcons)
            {
                NAPLATA_picBminus.Visible = false;
                NAPLATA_picLminus.Visible = false;
                NAPLATA_picDminus.Visible = false;
            }

        }
        private void NAPLATA_UseMeal(MealType type)
        {
            NAPLATA_picBminus.Visible = false;
            NAPLATA_picLminus.Visible = false;
            NAPLATA_picDminus.Visible = false;
            bool ops = MainController.UseMeal(type);
            if (ops)
            {
                switch (type)
                {
                    case MealType.Dorucak:
                        NAPLATA_picBminus.Visible = true;
                        break;
                    case MealType.Rucak:
                        NAPLATA_picLminus.Visible = true;
                        break;
                    case MealType.Vecera:
                        NAPLATA_picDminus.Visible = true;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(type), type, null);
                }
                MainController.LoadUserCard(MainController.LoadedCardUser.UserID);
            }
            
        }
        private void NAPLATA_btnUseBreakfast_Click(object sender, EventArgs e)
        {
            NAPLATA_UseMeal(MealType.Dorucak);
            NAPLATA_RefreshCardInfo(true);
        }
        private void NAPLATA_btnUseLunch_Click(object sender, EventArgs e)
        {
            NAPLATA_UseMeal(MealType.Rucak);
            NAPLATA_RefreshCardInfo(true);
        }
        private void NAPLATA_btnUseDinner_Click(object sender, EventArgs e)
        {
            NAPLATA_UseMeal(MealType.Vecera);
            NAPLATA_RefreshCardInfo(true);
        }
        private void NAPLATA_btnReclamation_Click(object sender, EventArgs e)
        {
            User s = MainController.LoadedCardUser;
            if (s == null)
            {
                MUtility.ShowWarrning("Prvo ucitati korisnika");
                return;
            }

            ReclamationForm rf = new ReclamationForm(MainController.LoadedCardUser, ReclamationForm.Mode.PogresnaNaplata);
            rf.ShowDialog();

            OpStatusWorking();
            MainController.LoadUserCard(MainController.LoadedCardUser.UserID);
            NAPLATA_RefreshCardInfo();
            OpStatusIdle();
        }


        #endregion

        #region KORISNICI_TAB

        private void KORSN_TABINIT()
        {
            if (KORSN_dgvUsers.DataSource == null)
                return;
            try
            {
                KORSN_dgvUsers.Columns["UserID"].HeaderText = "ID";
                KORSN_dgvUsers.Columns["Username"].HeaderText = "Korisnicko ime";
                KORSN_dgvUsers.Columns["FirstName"].HeaderText = "Ime";
                KORSN_dgvUsers.Columns["LastName"].HeaderText = "Prezime";
                KORSN_dgvUsers.Columns["Birthday"].HeaderText = "DatumRodjenja";
                KORSN_dgvUsers.Columns["RegistrationDate"].HeaderText = "DatumRegistracije";
                KORSN_dgvUsers.Columns["PhoneNumber"].HeaderText = "Telefon";
                KORSN_dgvUsers.Columns["AccountType"].HeaderText = "Tip";
                KORSN_dgvUsers.Columns["ProfilePicture"].Visible = false;
                KORSN_dgvUsers.Columns["ActiveAccount"].Visible = false;
                KORSN_dgvUsers.Columns["Index"].HeaderText = "Indeks";
                KORSN_dgvUsers.Columns["ValidUntil"].HeaderText = "VaziDo";
                KORSN_dgvUsers.Columns["Faculty"].Visible = false;
                KORSN_dgvUsers.Columns["FacultyDisplay"].HeaderText = "Fakultet";
                KORSN_dgvUsers.Columns["BreakfastCount"].Visible = false;
                KORSN_dgvUsers.Columns["LunchCount"].Visible = false;
                KORSN_dgvUsers.Columns["DinnerCount"].Visible = false;
                KORSN_dgvUsers.Columns["FullName"].Visible = false;
                KORSN_dgvUsers.Columns["Password"].Visible = false;
            }
            catch (Exception e)
            {
                MUtility.ShowError("Greska prilikom inicijalizacije tabele.");
            }
        }
        private void KORSN_FilterList()
        {
            if (User.AllUsers == null)
            {
                KORSN_dgvUsers.DataSource = new List<User>();
                KORSN_TABINIT();
                return;
            }
            List<User> res = new List<User>();

            string criteria = KORSN_txtSearch.Text.ToLower();
            if (criteria != string.Empty)
            {
                res.AddRange(User.AllUsers.FindAll(x => 
                            (x.UserID.ToString() == criteria) ||
                            (x.FirstName.ToLower().StartsWith(criteria)) ||
                            (x.LastName.ToLower().StartsWith(criteria)) ||
                            (x.Faculty != null && x.Faculty.Name.ToLower().StartsWith(criteria)) ||
                            (x.Email != null && x.Email.ToLower().StartsWith(criteria)) ||
                            (x.Username != null && x.Username.ToLower().StartsWith(criteria)) ||
                            (x.Index != null && x.Index.ToLower().StartsWith(criteria))
                ));    
            }
            else
            {
                res.AddRange(User.AllUsers);
            }

            switch (KORSN_cbxAccTypeChooser.SelectedIndex)
            {
                case 0:
                    res.RemoveAll(x => x.ActiveAccount == false);
                    break;
                case 1:
                    res.RemoveAll(x => x.ActiveAccount == true);
                    break;
            }

            KORSN_dgvUsers.DataSource = res;

        }
        private void KORSN_RefreshUsersGrid(bool ReloadData = false)
        {
            OpStatusWorking();
            if (ReloadData) MainController.UpdateAllUsersList();
            if (User.AllUsers == null)
            {
                MUtility.ShowError("Lista svih korisnika nije ucitana");
                return;
            }
            KORSN_FilterList();
            KORSN_TABINIT();
            OpStatusIdle();
        }
        private void KORSN_btnRefreshList_Click(object sender, EventArgs e)
        {
            KORSN_RefreshUsersGrid(true);
        }
        private void KORSN_cbxAccTypeChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            KORSN_FilterList();
        }
        private void KORSN_txtSearch_TextChanged(object sender, EventArgs e)
        {
            KORSN_FilterList();
        }
        #endregion

        #region ADMIN_PANEL_TAB
        private void button10_Click(object sender, EventArgs e)
        {
            FacultyManagerForm fm = new FacultyManagerForm();
            fm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MenzaManagerForm mf = new MenzaManagerForm();
            mf.ShowDialog();
        }
        #endregion
        #region INIT_GUI
        private void bgWorkerLoading_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(500);
            try
            {
                MainController.PostLoginInit();
            }
            catch(Exception ex)
            {
                MUtility.ShowException(ex);
                MainController.LogoutUser();
                Environment.Exit(1);
            }
        }
        private void bgWorkerLoading_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loadform.Close();
        }
        private void bgWorkerLoading_DoWorkLogOut()
        {
            Thread.Sleep(500);
            try
            {
                MainController.Shutdown();
            }
            catch (Exception ex)
            {
                MUtility.ShowException(ex);
                Environment.Exit(1);
            }
        }
        #endregion
        #region OTHER
        private void tabControls_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = !e.TabPage.Enabled;
            //if (e.TabPage == tabPage1)
            //    e.Cancel = true;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tabControls.TabPages.Remove(tabUsers);
            }
            else
            {
                tabControls.TabPages.Insert(3, tabUsers);
            }  
        }



        #endregion

        private void KORSN_btnProfile_Click(object sender, EventArgs e)
        {
            if (KORSN_dgvUsers.SelectedRows.Count == 0)
            {
                MUtility.ShowInformation("Odaberite korisnika");
                return;
            }

            User sel = (User) KORSN_dgvUsers.SelectedRows[0].DataBoundItem;

            ProfileForm pf = new ProfileForm(sel);
            pf.ShowDialog();
        }

        private void KORSN_btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (KORSN_dgvUsers.SelectedRows.Count == 0)
            {
                MUtility.ShowWarrning("Odaberite korisnika");
                return;
            }

            User u = KORSN_dgvUsers.SelectedRows[0].DataBoundItem as User;

            DialogResult dr = MessageBox.Show(
                string.Format("Da li ste sigurni da zelite da obrisete korisnika {0}?", u.FullName),
                "Brisanje korisnika",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr != DialogResult.OK)
                return;

            
            bool ops = MainController.DeleteUser(u);
            if (ops)
            {
                KORSN_RefreshUsersGrid(true);
                MUtility.ShowInformation("Korisnik uspesno obrisan");
            }
        }

        private void KORSN_btnAddNewUser_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            DialogResult dr = uf.ShowDialog();

            if (dr != DialogResult.OK)
                return;

            User u = uf.user;
            
            bool ops = MainController.AddNewUser(u);
            if (ops)
                KORSN_RefreshUsersGrid(true);

        }

        private void KORSN_btnChangeUser_Click(object sender, EventArgs e)
        {
            if (KORSN_dgvUsers.SelectedRows.Count == 0)
            {
                MUtility.ShowWarrning("Odaberite korisnika");
                return;
            }

            User u = KORSN_dgvUsers.SelectedRows[0].DataBoundItem as User;
            UserForm uf = new UserForm(u);
            if (uf.ShowDialog() == DialogResult.OK)
            {
                bool ops = MainController.UpdateUser(u);
                if(ops) MUtility.ShowInformation("Korisnik uspesno azuriran");
                KORSN_RefreshUsersGrid(true);
            }
            
        }
    }
}
