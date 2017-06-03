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
            MainController.Shutdown();
        }
        #endregion

        #region STATUS BAR
        private void RefreshStatusBarData()
        {
            STATUS_statbarUser.Text = MSettings.CurrentSession.LoggedUser.FullName;
            STATUS_statbarMenza.Text = MSettings.CurrentMensa.Name;
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
                MainController.LogoutUser();
                Close();
            }
            catch (Exception ex)
            {
                MainController.ShowException(ex);
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
        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            STATUS_statbarUserProfile.PerformClick();
        }
        
        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        
        private void button10_Click(object sender, EventArgs e)
        {

        }

        

        #region INIT_GUI
        private void bgWorkerLoading_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1500);
            try
            {
                MainController.PostLoginInit();
                loadform.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MainController.ShowException(ex);
                MainController.LogoutUser();
                Environment.Exit(1);            }
        }
        private void bgWorkerLoading_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loadform.Close();
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


    }
}
