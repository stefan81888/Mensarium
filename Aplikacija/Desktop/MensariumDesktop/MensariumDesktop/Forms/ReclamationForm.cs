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
            LoadData();
        }

        private void ReclamationForm_Load(object sender, EventArgs e)
        {
            txtUserID.Text = student.UserID.ToString();
            txtUserFName.Text = student.FirstName;
            txtUserLName.Text = student.LastName;

            dgvMeals.DataSource = list;
            dgvMeals.Columns["MensaAdded"].Visible = false;
            dgvMeals.Columns["Id"].HeaderText = "ID Obroka";
            dgvMeals.Columns["DateAdded"].HeaderText = "Datum uplacivanja";
            dgvMeals.Columns["Type"].HeaderText = "Tip";
            dgvMeals.Columns["MensaName"].HeaderText = "Mesto uplate";
            cmbFilter.SelectedIndex = 0;
        }

        private void LoadData()
        {
            list = MainController.GetReclamationMeals(student);
        }
        private void RefreshData()
        {
            int fitem = cmbFilter.SelectedIndex;
            if (fitem == 0)
                dgvMeals.DataSource = list;
            else
            {
                Mensa.MealType t = (Mensa.MealType)fitem;
                dgvMeals.DataSource = list.FindAll(x => x.Type == t);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (dgvMeals.SelectedRows.Count == 0)
                return;

            MealTodayAdded selected = (MealTodayAdded)dgvMeals.SelectedRows[0].DataBoundItem;
            bool ops = MainController.UndoAddMeals(selected);
            LoadData();
            
            RefreshData();
        }
    }
}
