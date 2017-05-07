using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql;

namespace Populisanje_baze
{
    public partial class Obroci : Form
    {
        public Obroci()
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

                string datumUplate = dtUplata.Value.ToString("yyyy-MM-dd");
                string datumIskoriscenja = dtIskoriscenje.Value.ToString("yyyy-MM-dd");
                int idObroka = int.Parse(tbIdObroka.Text);
                int tipObroka = cbxTip.SelectedIndex + 1;
                int idUplatioca = int.Parse(tbIddUplatioca.Text);
                int iskoriscen = cbxIskoriscen.SelectedIndex;
                int lokacijaUplate = cbxLokIskoriscenja.SelectedIndex + 1;
                int lokacijaIskoriscenja = cbxLokIskoriscenja.SelectedIndex + 1;


                string upit = "INSERT INTO Obroci VALUES(" + idObroka + "," + tipObroka + "," + idUplatioca + "," + iskoriscen + ",'" + datumUplate + "','" + datumIskoriscenja + "'," + lokacijaUplate + "," + lokacijaIskoriscenja + ");";
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

                for(int i = 0; i < int.Parse(tbBroj.Text); i++)
                {
                    Random random = new Random();
                    int tipObroka = random.Next(1, 3);
                    int idUplatioca = random.Next(1, 60);
                    int iskoriscen = random.Next(0, 1);
                    string datumUplate = random.Next(2016, 2017).ToString() + "-" + random.Next(1, 6).ToString() + "-" + random.Next(1, 20).ToString();                    
                    string datumIskoriscenja = "2017" + "-" + random.Next(7, 12).ToString() + "-" + random.Next(20, 30).ToString();
                    int lokacijaUplate = random.Next(1, 6);
                    int lokacijaIskoriscenja = random.Next(1, 3);


                    string upit = "INSERT INTO Obroci VALUES(Null," + tipObroka + "," + idUplatioca + "," + iskoriscen + ",'" + datumUplate + "','" + datumIskoriscenja + "'," + lokacijaUplate + "," + lokacijaIskoriscenja + ");";
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
