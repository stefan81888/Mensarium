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
        private List<MealReclamation> list;
        private Mode mode;
        public enum Mode
        {
            PogresnaUplata,
            PogresnaNaplata
        }
        public ReclamationForm(Student s, Mode m)
        {
            InitializeComponent();
            student = s;
            mode = m;
            LoadData();
        }

        private void ReclamationForm_Load(object sender, EventArgs e)
        {
            txtUserID.Text = student.UserID.ToString();
            txtUserFName.Text = student.FirstName;
            txtUserLName.Text = student.LastName;

            dgvMeals.DataSource = list;
            dgvMeals.Columns["Mensa"].Visible = false;
            dgvMeals.Columns["Id"].HeaderText = "ID Obroka";
            dgvMeals.Columns["DateAdded"].HeaderText = "Datum " + ((mode == Mode.PogresnaUplata)? "uplacivanja" : "naplacivanja");
            dgvMeals.Columns["Type"].HeaderText = "Tip";
            dgvMeals.Columns["MensaName"].HeaderText = "Mesto " + ((mode == Mode.PogresnaUplata) ? "uplate" : "naplate");
            cmbFilter.SelectedIndex = 0;
            
        }

        private void LoadData()
        {
            list = MainController.GetReclamationMeals(student, mode);
        }
        private void RefreshData()
        {
            int fitem = cmbFilter.SelectedIndex;
            if (fitem == 0)
                dgvMeals.DataSource = list;
            else
            {
                MealType t = (MealType)fitem;
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

            MealReclamation selected = (MealReclamation)dgvMeals.SelectedRows[0].DataBoundItem;
            bool ops = (mode == Mode.PogresnaUplata) ? MainController.UndoAddMeals(selected) : MainController.UndoUseMeals(selected);
            LoadData();
            
            RefreshData();
        }
    }
}
