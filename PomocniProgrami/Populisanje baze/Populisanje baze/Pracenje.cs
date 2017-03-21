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
    public partial class Pracenje : Form
    {
        public Pracenje()
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

                int brojRedova = int.Parse(tbBrojPracenja.Text);

                string query = "select count(*) from Pracenja";
                MySqlCommand komanda1 = new MySqlCommand(query, konekcija);
                Int32 brojKorisnika = Convert.ToInt32(komanda1.ExecuteScalar());

                Random random = new Random();

                for(int i = 0; i < brojRedova; i ++)
                {
                    Int32 prvi, drugi, rezulat = 0;

                    drugi =  random.Next(30, brojKorisnika);
                    prvi = random.Next(30, brojKorisnika);
                    while(prvi == drugi)
                    {
                        drugi = random.Next(brojKorisnika / 2, brojKorisnika);                  
                    }
                    string upit = "insert into Pracenja values(" + prvi.ToString() + "," + drugi.ToString() + ")";
                    MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                    rezulat = komanda.ExecuteNonQuery();

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
