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
    public partial class Objave : Form
    {
        public Objave()
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

                int lokacija = cbxLokacija.SelectedIndex + 1;
                string datum = dtDatum.Value.ToString("yyyy-MM-dd");
                string tekstObjave = tbTekst.Text;


                string upit = "INSERT INTO Objave VALUES(Null," + lokacija + ",'" + datum + "','" + tekstObjave + "');";
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

                    var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijKLMNO34PQRSklmnopqrstuvwxyz0123456789";
                    var stringNaziv = new char[10];
                

                    for (int j = 0; j < 10; j++)
                    {
                        stringNaziv[j] = chars[random.Next(chars.Length)];                      
                    }

                    string tekstObjave = new String(stringNaziv);
                    int lokacija = random.Next(1,4);
                    string datum = random.Next(2015, 2017).ToString() + "-" + random.Next(1, 12).ToString() + "-" + random.Next(1, 30).ToString();

                    string upit = "INSERT INTO Objave VALUES(Null," + lokacija + ",'" + datum + "','" + tekstObjave + "');";
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
