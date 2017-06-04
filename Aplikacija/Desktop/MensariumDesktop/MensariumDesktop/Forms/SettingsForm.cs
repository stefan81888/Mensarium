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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            txtmServerIP.Text = MSettings.Server.IP;
            txtmServerPort.Text = MSettings.Server.Port;

            if (Mensa.Mensas == null || Mensa.Mensas.Count == 0)
            {
                gbxLokacija.Enabled = false;
                return;
            }
            cbxSettingsMenza.DataSource = Mensa.Mensas;
            cbxSettingsMenza.DisplayMember = "Name";
            cbxSettingsMenza.ValueMember = "MensaID";
            cbxSettingsMenza.SelectedItem = MSettings.CurrentMensa;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool successful = true;
            try
            {
                successful &= MainController.ChangeServer(txtmServerIP.Text, txtmServerPort.Text);
                if (gbxLokacija.Enabled)
                    successful &= MainController.ChangeCurrentMensa((Mensa)cbxSettingsMenza.SelectedItem);
            }
            catch(Exception ex)
            {
                MUtility.ShowException(ex);
                return;
            }
            if (!successful) return;

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            MainController.TestConnection(txtmServerIP.Text, txtmServerPort.Text);
            Cursor.Current = Cursors.Default;
        }
    }
}
