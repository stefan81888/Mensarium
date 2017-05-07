using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace Populisanje_baze
{
    public partial class formPocetna : Form
    {
        public formPocetna()
        {
            InitializeComponent();
        }

        private void btnFakulteti_Click(object sender, EventArgs e)
        {
            Fakulteti fakulteti = new Fakulteti();
            fakulteti.ShowDialog();
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            Korisnici fakulteti = new Korisnici();
            fakulteti.ShowDialog();
        }

        private void btnPracenje_Click(object sender, EventArgs e)
        {
            Pracenje pracenje = new Pracenje();
            pracenje.ShowDialog();
        }

        private void btnObroci_Click(object sender, EventArgs e)
        {
            Obroci obrok = new Obroci();
            obrok.ShowDialog();
        }

        private void btnMenze_Click(object sender, EventArgs e)
        {
            Menze menza = new Menze();
            menza.ShowDialog();
        }

        private void btnObjave_Click(object sender, EventArgs e)
        {
            Objave objave = new Objave();
            objave.ShowDialog();
        }

        private void btnPozivanja_Click(object sender, EventArgs e)
        {
            Pozivanja poziv = new Pozivanja();
            poziv.ShowDialog();
        }

        private void btnPozvani_Click(object sender, EventArgs e)
        {
            Pozvani pozvani = new Pozvani();
            pozvani.ShowDialog();
        }
    }
}
