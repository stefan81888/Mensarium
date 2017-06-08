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

            cbxStanje.SelectedIndex = 1;
            btnSave.Text = CreateMode ? "Dodaj" : "Sacuvaj";

        }

        private void FillData()
        {
            if (!CreateMode && user.ProfilePicture == null)
                MainController.LoadProfilePicture(user);

            picProfilePicture.Image = user.ProfilePicture;
            txtID.Text = (user.UserID == 0) ? "/" : user.UserID.ToString();
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
            if (CreateMode && (User.UserAccountType) cbxTip.SelectedItem == User.UserAccountType.Student)
            {
                txtUsername.Enabled = false;
                txtEmail.Enabled = false;
                txtPassword.Enabled = false;
                cbxStanje.Enabled = false;
            }
            else
            {
                txtUsername.Enabled = true;
                txtEmail.Enabled = true;
                txtPassword.Enabled = true;
                cbxStanje.Enabled = true;
            }

            if ((User.UserAccountType) cbxTip.SelectedItem != User.UserAccountType.Student)
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

        private void AllowOnlyLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char) Keys.Back);
        }

        private void AllowOnlyAlphaNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char) Keys.Back || char.IsNumber(e.KeyChar));
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
            DialogResult dr = openImageFileDialog.ShowDialog();
            if (dr != DialogResult.OK)
                return;

            string filename = openImageFileDialog.FileName;
            
            long filesize = (new FileInfo(filename)).Length;

            if (filesize >= (1024 * 1024 * 1))
            {
                MUtility.ShowWarrning("Prevelika slika. Slika mora da bude manje od 1MB");
                return;
            }
            picProfilePicture.Image = Image.FromFile(openImageFileDialog.FileName);

        }

        private bool ValidateData()
        {
            if (txtFName.Text == string.Empty) return false;
            if (txtLName.Text == string.Empty) return false;
            if (dateTimeBirthday.Value >= DateTime.Now) return false;
            if (txtIndex.Enabled && txtIndex.Text == string.Empty) return false;
            if (txtPhone.Text == string.Empty) return false;
            if (txtUsername.Enabled && txtUsername.Text == string.Empty && cbxStanje.SelectedIndex == 0) return false;
            if (txtEmail.Enabled && txtEmail.Text == string.Empty && cbxStanje.SelectedIndex == 0) return false;
            if (dateTimeValid.Enabled && dateTimeValid.Value < user.RegistrationDate) return false;
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                MUtility.ShowWarrning("Proverite sva polja");
                return;
            }
            
            user.ProfilePicture = picProfilePicture.Image;
            user.FirstName = txtFName.Text;
            user.LastName = txtLName.Text;
            user.Birthday = dateTimeBirthday.Value;
            if (user.AccountType == User.UserAccountType.Student)
            {
                user.Faculty = cbxFaculty.SelectedItem as Faculty;
                user.Index = txtIndex.Text;
            }
            user.PhoneNumber = txtPhone.Text;

            user.Username = txtUsername.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.ValidUntil = dateTimeValid.Value;
            user.RegistrationDate = dateTimeRegistration.Value;
            user.AccountType = (User.UserAccountType) cbxTip.SelectedItem;
            user.ActiveAccount = cbxStanje.SelectedIndex == 0;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
