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
    public partial class Menze : Form
    {
        public Menze()
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

                string naziv = tbNaziv.Text;
                string lokacija = tbLokacija.Text;
                string radnoVreme = tbRadnoVreme.Text;
                int neRadi = cbxNeRadi.SelectedIndex;


                string upit = "INSERT INTO Menze VALUES(Null,'" + naziv + "','" + lokacija + "','" + radnoVreme + "'," + neRadi + ");";
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

                    var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijKLMNO34PQRSklmnopqrstuvwxyz0123456789";
                    var stringNaziv = new char[10];
                    var stringLokacija = new char[10];
                    var stringRadnoVreme = new char[10];

                    for (int j = 0; j < 10; j++)
                    {
                        stringNaziv[j] = chars[random.Next(chars.Length)];
                        stringLokacija[j] = chars[random.Next(chars.Length)];
                        stringRadnoVreme[j] = chars[random.Next(chars.Length)];
                    }

                    string naziv = new String(stringNaziv);
                    string lokacija = new String(stringLokacija);
                    string radnoVreme = new String(stringRadnoVreme);
                    int neRadi = random.Next(1);

                    string upit = "INSERT INTO Menze VALUES(Null,'" + naziv + "','" + lokacija + "','" + radnoVreme + "'," + neRadi + ");";
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
