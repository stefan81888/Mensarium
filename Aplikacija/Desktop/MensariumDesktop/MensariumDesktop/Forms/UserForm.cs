using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MensariumDesktop.Model.Components;
using MensariumDesktop.Model.Controllers;

namespace MensariumDesktop.Forms
{
    public partial class UserForm : Form
    {
        public User user;
        public bool CreateMode;

        public UserForm()
        {
            InitializeComponent();

            user = new User();
            CreateMode = true;
            user.AccountType = User.UserAccountType.Student;
            MyInitForm();
        }
        public UserForm(User u)
        {
            InitializeComponent();

            user = u;
            CreateMode = false;
            MyInitForm();
        }
        public void MyInitForm()
        {
            cbxTip.DataSource = Enum.GetValues(typeof(User.UserAccountType));
            cbxFaculty.DataSource = Faculty.Faculties;
            cbxFaculty.DisplayMember = "Name";

            cbxTip.SelectedItem = User.UserAccountType.Student;
            if (MSettings.CurrentSession.LoggedUser.AccountType == User.UserAccountType.Menadzer)
                cbxTip.Enabled = false;

            cbxStanje.SelectedIndex = 0;
            btnSave.Text = CreateMode? "Dodaj" : "Sacuvaj";

        }
        private void FillData()
        {
            if (!CreateMode && user.ProfilePicture == null)
                MainController.LoadProfilePicture(user);

            picProfilePicture.Image = user.ProfilePicture;
            txtID.Text = (user.UserID == 0 )? "/" : user.UserID.ToString();
            txtFName.Text = user.FirstName ?? "";
            txtLName.Text = user.LastName ?? "";
            if (user.Birthday != DateTime.MinValue)
                dateTimeBirthday.Value = user.Birthday;
            if (user.Faculty != null) cbxFaculty.SelectedItem = user.Faculty;
            txtIndex.Text = user.Index ?? "";
            txtPhone.Text = user.PhoneNumber ?? "";
            txtUsername.Text = user.Username ?? "";
            txtEmail.Text = user.Email ?? "";
            txtPassword.Text = "";
            if (user.RegistrationDate != DateTime.MinValue)
                dateTimeRegistration.Value = user.RegistrationDate;
            else
                dateTimeRegistration.Value = DateTime.Now;
            
            cbxTip.SelectedItem = user.AccountType;
            cbxStanje.SelectedIndex = user.ActiveAccount ? 0 : 1;
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            FillData();
        }
        private void cbxTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CreateMode && (User.UserAccountType)cbxTip.SelectedItem == User.UserAccountType.Student)
            {
                txtUsername.Enabled = false;
                txtEmail.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUsername.Enabled = true;
                txtEmail.Enabled = true;
                txtPassword.Enabled = true;
            }
            
            if ((User.UserAccountType)cbxTip.SelectedItem != User.UserAccountType.Student)
            {
                cbxFaculty.Enabled = false;
                txtIndex.Enabled = false;
                dateTimeValid.Enabled = false;
            }
            else
            {
                cbxFaculty.Enabled = true;
                txtIndex.Enabled = true;
                dateTimeValid.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void AllowOnlyLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void AllowOnlyAlphaNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar));
        }
        private void AllowOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text == string.Empty) return;
            if (!MainController.IsValidEmail(txtEmail.Text))
            {
                MUtility.ShowWarrning("Unet je nevalidan email");
                return;
            }
        }

        private void picProfilePicture_Click(object sender, EventArgs e)
        {
            openImageFileDialog.ShowDialog();

            string filename = openImageFileDialog.FileName;
            long filesize = (new FileInfo(filename)).Length;

            if (filesize >= (1024 * 1024 * 1))
            {
                MUtility.ShowWarrning("Prevelika slika. Slika mora da bude manje od 1MB");
                return;
            }
            picProfilePicture.Image = Image.FromFile(openImageFileDialog.FileName);
            
        }
    }
}
