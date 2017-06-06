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
    }
}
