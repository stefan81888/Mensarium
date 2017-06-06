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
    public partial class FacultyManagerForm : Form
    {
        private Faculty selectedFaculty;
        private Faculty newFac;

        public FacultyManagerForm()
        {
            InitializeComponent();

            RefreshList();
            dgvFacultyList.Columns[0].HeaderText = "Fakultet ID";
            dgvFacultyList.Columns[1].HeaderText = "Naziv fakulteta";
            RefreshData();
        }

        private void RefreshData()
        {
            if (dgvFacultyList.SelectedRows.Count == 0)
            {
                txtFacultyId.Text = "";
                txtName.Text = "";
                return;
            }

            selectedFaculty = (Faculty) dgvFacultyList.SelectedRows[0].DataBoundItem;

            txtFacultyId.Text = selectedFaculty.FacultyID.ToString();
            txtName.Text = selectedFaculty.Name;
            newFac = null;
        }

        private void RefreshList()
        {
            if (Faculty.Faculties == null)
                return;
            dgvFacultyList.DataSource = Faculty.Faculties;
            newFac = null;
            //dgvFacultyList.Sort(dgvFacultyList.Columns[0], ListSortDirection.Ascending);
        }

        private void dgvFacultyList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //dodavanje fakuleta
            if (newFac != null)
            {
                if (txtName.Text == String.Empty)
                {
                    MUtility.ShowInformation("Naziv ne sme biti prazan");
                    return;
                }
                newFac.Name = txtName.Text;
                MainController.AddFaculty(newFac);
                RefreshList();
                RefreshData();
                newFac = null;
                return;
            }

            if (selectedFaculty == null)
            {
                MUtility.ShowInformation("Odaberi fakultet za izmenu");
                return;
            }

            if (txtName.Text == string.Empty)
            {
                MUtility.ShowInformation("Naziv ne sme biti prazan");
                return;
            }

            selectedFaculty.Name = txtName.Text;
            MainController.UpdateFaculty(selectedFaculty);

            RefreshList();
            RefreshData();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedFaculty == null)
            {
                MUtility.ShowInformation("Odaberi fakultet za brisanje");
                return;
            }

            MainController.DeleteFaculty(selectedFaculty);
            RefreshList();
            RefreshData();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            selectedFaculty = null;
            txtFacultyId.Text = "<NoviFakultet>";
            txtName.Text = "Unesi ime";
            txtName.Focus();
            txtName.SelectAll();

            newFac = new Faculty();
        }
    }
}
