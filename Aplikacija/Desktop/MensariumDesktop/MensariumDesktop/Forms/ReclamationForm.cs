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
        public ReclamationForm()
        {
            InitializeComponent();
        }

        private void ReclamationForm_Load(object sender, EventArgs e)
        {
            cmbFilter.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
