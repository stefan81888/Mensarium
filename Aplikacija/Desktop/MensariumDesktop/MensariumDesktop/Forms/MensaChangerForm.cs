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
            cbxSettingsMenza.SelectedIndex = 0;
        }
    }
}
