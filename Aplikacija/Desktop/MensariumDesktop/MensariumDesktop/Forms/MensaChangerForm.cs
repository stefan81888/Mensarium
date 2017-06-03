using MensariumDesktop.Model.Components;
using MensariumDesktop.Model.Controllers;
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
    public partial class MensaChangerForm : Form
    {
        public MensaChangerForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void MensaChangerForm_Load(object sender, EventArgs e)
        {
            if (Mensa.Mensas == null || Mensa.Mensas.Count == 0)
                gbxLokacija.Enabled = false;
            else
            {
                cbxSettingsMenza.DataSource = Mensa.Mensas;
                cbxSettingsMenza.DisplayMember = "Name";
                cbxSettingsMenza.SelectedItem = MSettings.CurrentMensa;
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool successfull = true;
            if (gbxLokacija.Enabled)
                successfull = MainController.ChangeCurrentMensa((Mensa)cbxSettingsMenza.SelectedItem);

            if (successfull) Close();
        }
    }
}
