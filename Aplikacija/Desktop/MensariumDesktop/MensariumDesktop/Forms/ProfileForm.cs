using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MensariumDesktop.Model.Components;
using MensariumDesktop.Model.Controllers;

namespace MensariumDesktop.Forms
{
    public partial class ProfileForm : Form
    {
        private User user;

        public ProfileForm(User u)
        {
            InitializeComponent();
            user = u;

            if (user.ProfilePicture == null)
                MainController.LoadProfilePicture(u);

            RefreshData();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefreshData()
        {
            if (user.ProfilePicture != null) picUserImage.Image = user.ProfilePicture;
            txtID.Text = user.UserID.ToString();
            txtUsername.Text = user.Username;
            txtEmail.Text = user.Email;
            txtFName.Text = user.FirstName;
            txtLName.Text = user.LastName;
            txtBirthDate.Text = user.Birthday.ToShortDateString();
            txtPhone.Text = user.PhoneNumber;
            txtRegistrationDate.Text = user.RegistrationDate.ToShortDateString();
            txtAccType.Text = user.AccountType.ToString();
            txtAccActive.Text = user.ActiveAccount ? "Aktivan" : "Neaktivan";
            if (user.AccountType == User.UserAccountType.Student)
            {
                
                txtFaculty.Text = user.Faculty.Name;
                txtIndex.Text = user.Index;
                txtCardValid.Text = user.ValidUntil.ToShortDateString();
            }
        }
        
        private void picUserImage_Paint(object sender, PaintEventArgs e)
        {
            MUtility.RoundPictureBox(sender as PictureBox);
        }
    }
}
