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
    public partial class CardReaderEmulator : Form
    {
        public int CardData;

        public CardReaderEmulator()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool successfull = int.TryParse(textBox1.Text, out CardData);
            if (!successfull)
            {
                MessageBox.Show("UNESI BROJ");
                return;
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
