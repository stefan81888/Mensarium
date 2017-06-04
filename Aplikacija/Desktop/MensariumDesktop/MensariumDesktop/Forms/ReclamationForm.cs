using MensariumDesktop.Model.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MensariumDesktop.Forms
{
    public partial class ReclamationForm : Form
    {
        private Student student;

        public ReclamationForm(Student s)
        {
            InitializeComponent();
            student = s;
        }

        private void ReclamationForm_Load(object sender, EventArgs e)
        {
            txtUserID.Text = student.UserID.ToString();
            txtUserFName.Text = student.FirstName;
            txtUserLName.Text = student.LastName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
