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
    public partial class NewUserCreatedForm : Form
    {
        private string Id;
        private string Pin;

        public NewUserCreatedForm(string id, string pin)
        {
            InitializeComponent();
            Id = id;
            Pin = pin;
        }

        private void NewUserCreatedForm_Load(object sender, EventArgs e)
        {
            lblID.Text = Id;
            lblPIN.Text = Pin;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
