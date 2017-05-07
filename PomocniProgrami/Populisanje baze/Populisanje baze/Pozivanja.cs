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
    public partial class Pozivanja : Form
    {
        public Pozivanja()
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

                int idPozivaoca = int.Parse(tbIDPozivaoca.Text);
                string datum = dtDatum.Value.ToString("yyyy-MM-dd");
                string vreme = nudSati.Value + ":" + nudMinuti.Value + ":" + nudSekunde.Value;


                string upit = "INSERT INTO Pozivanja VALUES(Null," + idPozivaoca + ",'" + datum + "','" + vreme + "');";
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

                for (int i = 0; i < brojRedova; i++)
                {
                    Random random = new Random();                

                    int idPozivaoca = random.Next(1,70);
                    string datum = random.Next(2015, 2017).ToString() + "-" + random.Next(1, 12).ToString() + "-" + random.Next(1, 30).ToString();
                    string vreme = random.Next(0,1).ToString() + ":" + random.Next(0,60).ToString() + ":" + random.Next(0, 60).ToString();

                    string upit = "INSERT INTO Pozivanja VALUES(Null," + idPozivaoca + ",'" + datum + "','" + vreme + "');";
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
