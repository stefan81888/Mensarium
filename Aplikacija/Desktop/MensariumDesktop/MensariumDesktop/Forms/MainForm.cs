﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MensariumDesktop.Forms;
using MensariumDesktop.Model;
using MensariumDesktop.Model.Components;
using MensariumDesktop.Model.Components.DTOs;
using MensariumDesktop.Model.Controllers;

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
            //KorisnikFullDto k = MensariumApi.GetUserFullInfo(2);

            //User u = new User();
            //u.Email = k.Email;
            //u.Birthday = k.DatumRodjenja;
            //u.FirstName = k.Ime;
            //u.LastName = k.Prezime;
            //u.PhoneNumber = k.BrojTelefona;
            //u.UserID = k.IdKorisnika;
            //u.RegistrationDate = k.DatumRegistracije;
            //u.Username = k.KorisnickoIme;

            //MensariumConfig.LoggedUser = u;

            //lblCurrentUserFName.Text = u.FirstName;
            //lblCurrentUserLName.Text = u.LastName;

            //List<KorisnikFullDto> korisnici = MensariumApi.GetUsersFullInfo();

            KorisnikFullDto kk = new KorisnikFullDto();
            kk.DatumRodjenja = DateTime.Now;
            kk.AktivanNalog = true;
            kk.BrojIndeksa = "121213";
            kk.BrojTelefona = "21312312312";
            kk.DatumRegistracije = DateTime.Now;
            kk.Email = "oprem@dobro.com";
            kk.IdKorisnika = 12;
            kk.IdTipaNaloga = 5;
            kk.Ime = "Mile";
            kk.Prezime = "Zilenium";
            kk.KorisnickoIme = "zix";

            Api.SendUserFull(kk);

        }
    }
}
