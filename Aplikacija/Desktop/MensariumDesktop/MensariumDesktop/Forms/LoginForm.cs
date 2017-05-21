using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MensariumDesktop.Model.Controllers;

namespace MensariumDesktop.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void picSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.SelectAll();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Unesite sve podatke");
                return;
            }

            bool status = MainController.LogUser(txtUsername.Text, txtPassword.Text);
            if (status)
            {
                MessageBox.Show("Uspesno logovanje");
            }
        }
    }
}
