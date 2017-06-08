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
    public partial class MenzaManagerForm : Form
    {
        private Mensa selectedMensa;
        private Mensa newMensa;

        public MenzaManagerForm()
        {
            InitializeComponent();
            RefreshList();
            dgvMensaList.Columns[0].HeaderText = "Menza ID";
            dgvMensaList.Columns[1].HeaderText = "Naziv Menze";
            dgvMensaList.Columns[2].HeaderText = "Lokacija";
            dgvMensaList.Columns[3].HeaderText = "Radno Vreme";
            dgvMensaList.Columns[4].HeaderText = "Ne radi";
            dgvMensaList.Columns[5].HeaderText = "GPS_LAT";
            dgvMensaList.Columns[6].HeaderText = "GPS_LON";
            RefreshData();
        }

        private void RefreshData()
        {
            if (dgvMensaList.SelectedRows.Count == 0)
            {
                txtMenzaID.Text = "";
                txtName.Text = "";
                txtLocation.Text = "";
                txtWorkTime.Text = "";
                cbxNotWorking.Checked = false;
                txtGPS_Lat.Text = "";
                txtGPS_Lon.Text = "";
                return;
            }

            selectedMensa = (Mensa) dgvMensaList.SelectedRows[0].DataBoundItem;
            txtMenzaID.Text = selectedMensa.MensaID.ToString();
            txtName.Text = selectedMensa.Name;
            txtLocation.Text = selectedMensa.Location;
            txtWorkTime.Text = selectedMensa.WorkTime;
            cbxNotWorking.Checked = selectedMensa.CurrentlyClosed;
            txtGPS_Lat.Text = selectedMensa.GPSLat.ToString();
            txtGPS_Lon.Text = selectedMensa.GPSLong.ToString();
            newMensa = null;
        }

        private void RefreshList()
        {
            if (Mensa.Mensas == null)
                return;
            dgvMensaList.DataSource = Mensa.Mensas;
            newMensa = null;
        }
        private void btnFinish_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void dgvMensaList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshData();
        }

        private bool ValidateInput()
        {
            if (txtName.Text == string.Empty) return false;
            if (txtLocation.Text == string.Empty) return false;
            if (txtWorkTime.Text == string.Empty) return false;
            try
            {
                double.Parse(txtGPS_Lat.Text);
                double.Parse(txtGPS_Lon.Text);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (newMensa != null)
            {
                if (!ValidateInput())
                {
                    MUtility.ShowInformation("Nevalidni podaci. Proverite sva polja!");
                    return;
                }
                newMensa.Name = txtName.Text;
                newMensa.Location = txtLocation.Text;
                newMensa.WorkTime = txtWorkTime.Text;
                newMensa.CurrentlyClosed = cbxNotWorking.Checked;
                newMensa.GPSLat = double.Parse(txtGPS_Lat.Text);
                newMensa.GPSLong = double.Parse(txtGPS_Lon.Text);
                MainController.AddMensa(newMensa);
                RefreshList();
                RefreshData();
                newMensa = null;
                return;
            }

            if (selectedMensa == null)
            {
                MUtility.ShowInformation("Odaberi menzu za izmenu");
                return;
            }

            if (!ValidateInput())
            {
                MUtility.ShowInformation("Nevalidni podaci. Proverite sva polja!");
                return;
            }

            selectedMensa.Name = txtName.Text;
            selectedMensa.CurrentlyClosed = cbxNotWorking.Checked;
            selectedMensa.Location = txtLocation.Text;
            selectedMensa.GPSLong = double.Parse(txtGPS_Lon.Text);
            selectedMensa.GPSLat = double.Parse(txtGPS_Lat.Text);
            selectedMensa.WorkTime = txtWorkTime.Text;

            MainController.UpdateMensa(selectedMensa);
            RefreshList();
            RefreshData();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMensa == null)
            {
                MUtility.ShowInformation("Odaberi fakultet za brisanje");
                return;
            }

            DialogResult dg = MessageBox.Show("Da li ste sigurni da zelite da obrisete " + selectedMensa.Name + "?", "Brisanje fakulteta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.No)
                return;

            MainController.DeleteMensa(selectedMensa);
            RefreshList();
            RefreshData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            selectedMensa = null;
            txtMenzaID.Text = "<NovaMenza>";
            txtName.Text = "Unesi podatak";
            txtGPS_Lat.Text = "Unesi podatak";
            txtGPS_Lon.Text = "Unesi podatak";
            txtLocation.Text = "Unesi podatak";
            txtWorkTime.Text = "Unesi podatak";
            cbxNotWorking.Checked = false;

            txtName.Focus();
            txtName.SelectAll();
            newMensa = new Mensa();
        }

        private void txtBox_SelectAll_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
    }
}
