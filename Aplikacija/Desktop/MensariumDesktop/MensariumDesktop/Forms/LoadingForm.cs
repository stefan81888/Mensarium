using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MensariumDesktop.Model.Controllers;

namespace MensariumDesktop.Forms
{
    public partial class LoadingForm : Form
    {
        public string TextToDisplay = "Učitavanje";
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            label1.Text = TextToDisplay;
        }
       
    }
}
