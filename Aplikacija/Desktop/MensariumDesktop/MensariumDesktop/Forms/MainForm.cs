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
            
            //TO-DO: CURRENT MENSA
            HOME_lblCurrentLocation.Text = MSettings.CurrentMensa.Name;
            HOME_lblCurrentLocationAddress.Text = MSettings.CurrentMensa.Location;

            RefreshStatusBarData();
            
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
        }
        private void OpStatusWorking()
        {
            STATUS_statbarOPStatus.Visible = true;
            Cursor.Current = Cursors.AppStarting;
        }
        private void OpStatusIdle()
        {
            STATUS_statbarOPStatus.Visible = false;
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
            ReclamationForm reclamationForm = new ReclamationForm();
            reclamationForm.ShowDialog();
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
            var j = new RestSharp.Deserializers.JsonDeserializer();
            RestResponse r = new RestResponse();
            r.Content = "{\"BrojDorucka\": 25,\"BrojRuckova\": 1,\"BrojVecera\": 0}\"";
            r.ContentType = "application/json";
            
            KorisnikStanjeDto k = j.Deserialize<KorisnikStanjeDto>(r);
            

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
        private void btnSignOut_Click(object sender, EventArgs e)
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
        private void HOME_picCurrentUser_Paint(object sender, PaintEventArgs e)
        {
            MUtility.RoundPictureBox(sender as PictureBox);
        }

        private void UPLATA_picLoadedUser_Paint(object sender, PaintEventArgs e)
        {
            MUtility.RoundPictureBox(sender as PictureBox);
        }

        private void btnExecutePay_Click(object sender, EventArgs e)
        {
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

            UPLATA_txtBreakfast.Text = "0";
            UPLATA_txtLunch.Text = "0";
            UPLATA_txtDinner.Text = "0";
        }
    }
}
