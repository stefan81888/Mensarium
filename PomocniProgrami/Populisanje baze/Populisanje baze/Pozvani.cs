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
    public partial class Pozvani : Form
    {
        public Pozvani()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                // uspostavljanje i otvaranje konekcije
                string konekcioniString = @"Data Source=160.99.38.10; Database=mensarium_db; User ID=mensarium; Password='Vodja.204'; Port=6666;";                                                                                                                                                  //SqlConnection konekcija = new SqlConnection(ConfigurationManager.ConnectionStrings[konekcioniString].ConnectionString);
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();

                int id = int.Parse(tbID.Text);
                int odgovor = cbxOdgovor.SelectedIndex;
                int idPoziva = int.Parse(tbIDpoziva.Text);

                string upit = "INSERT INTO PozivanjaPozvani VALUES("  + idPoziva + "," + id + "," + odgovor + ");";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.ExecuteNonQuery();

                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Javio se izuzetak", MessageBoxButtons.OK);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            try
            {
                // uspostavljanje i otvaranje konekcije
                string konekcioniString = @"Data Source=160.99.38.10; Database=mensarium_db; User ID=mensarium; Password='Vodja.204'; Port=6666;";                                                                                                                                                  //SqlConnection konekcija = new SqlConnection(ConfigurationManager.ConnectionStrings[konekcioniString].ConnectionString);
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();

                int brojRedova = int.Parse(tbBroj.Text);

                for(int i = 0; i < brojRedova; i++)
                {
                    Random random = new Random();
                    int id = random.Next(1,60);
                    int odgovor = random.Next(0,1);
                    int idPoziva = i + 1;               

                    string upit = "INSERT INTO PozivanjaPozvani VALUES(" + idPoziva + "," + id + "," + odgovor + ");";
                    MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                    komanda.ExecuteNonQuery();
                }          
                
                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Javio se izuzetak", MessageBoxButtons.OK);
            }
        }
    }
}
