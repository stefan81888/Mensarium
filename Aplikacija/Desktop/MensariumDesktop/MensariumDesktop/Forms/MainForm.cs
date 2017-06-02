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

namespace MensariumDesktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

       

        private void statusBarSettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void showLoginFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }

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
                tabControls.TabPages.Insert(3,tabUsers);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            MensaChangerForm mc = new MensaChangerForm();
            mc.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReclamationForm reclamationForm = new ReclamationForm();
            reclamationForm.ShowDialog();
        }

        private void promeniLokacijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MensaChangerForm mc = new MensaChangerForm();
            mc.ShowDialog();
        }

        private void showProfileFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileForm pf = new ProfileForm();
            pf.ShowDialog();
        }

        private void showUserFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbxKriterijum.SelectedIndex = 0;
            lblCurrentUserFName.Text = MSettings.CurrentSession.LoggedUser.FirstName;
            lblCurrentUserLName.Text = MSettings.CurrentSession.LoggedUser.LastName;
            lblCurrentUserAccType.Text = MSettings.CurrentSession.LoggedUser.AccountType.ToString();

            statbarUser.Text = MSettings.CurrentSession.LoggedUser.FirstName + " " + MSettings.CurrentSession.LoggedUser.LastName;

            lblCurrentLocation.Text = Mensa.Mensas[0].Name;
            lblCurrentLocation.Text = Mensa.Mensas[0].Location;

            statbarMenza.Text = Mensa.Mensas[0].Name;
            
        }

        private void showNewUserCreatedFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUserCreatedForm nu = new NewUserCreatedForm();

            nu.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm pf = new ProfileForm();
            pf.ShowDialog();
        }

        private void statbarUserProfile_Click(object sender, EventArgs e)
        {
           ProfileForm pf = new ProfileForm();
           pf.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ProfileForm pf = new ProfileForm();
            pf.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.ShowDialog();
        }

        private void dEBUGMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try { pcbCurrentUser.Image = Api.GetUserImage(2); } catch (Exception exception) { MessageBox.Show(exception.Message); }
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

        private void button10_Click(object sender, EventArgs e)
        {
            FacultyManagerForm fmf = new FacultyManagerForm();
            fmf.ShowDialog();

        }

        private void statbarUserSignOut_Click(object sender, EventArgs e)
        {
            try
            {
                MainController.LogoutUser();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            statbarUserSignOut.PerformClick();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainController.Shutdown();
        }
    }
}
