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
using MensariumDesktop.Model.Components.DTOs;
using MensariumDesktop.Model.Controllers;
namespace MensariumDesktop.Forms
{
    public partial class ReclamationForm : Form
    {
        private Student student;
        private List<MealTodayAdded> list;
        
        public ReclamationForm(Student s)
        {
            InitializeComponent();
            student = s;
            list = MainController.GetReclamationMeals(s);
        }

        private void ReclamationForm_Load(object sender, EventArgs e)
        {
            txtUserID.Text = student.UserID.ToString();
            txtUserFName.Text = student.FirstName;
            txtUserLName.Text = student.LastName;

            cmbFilter.SelectedIndex = 0;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            Mensa.MealType m = (Mensa.MealType)cmbFilter.SelectedIndex;
            dgvMeals.Refresh();
        }
    }
}
