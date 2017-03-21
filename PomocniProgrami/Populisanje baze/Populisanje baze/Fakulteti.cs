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
    public partial class Fakulteti : Form
    {
        private List<string> listaFakulteta;

        public Fakulteti()
        {
            InitializeComponent();
            listaFakulteta = new List<string>();
            listaFakulteta.Add("Elektronski fakultet Nis");
            listaFakulteta.Add("Pravni");
            listaFakulteta.Add("Ekonomski");
            listaFakulteta.Add("Zastita na radu");
        }

        private void btnFakulteti_Click(object sender, EventArgs e)
        {
            try
            {
                // uspostavljanje i otvaranje konekcije
                string konekcioniString = @"Data Source=160.99.38.10; Database=mensarium_db; User ID=mensarium; Password='Vodja.204'; Port=6666;";                                                                                                                                                  //SqlConnection konekcija = new SqlConnection(ConfigurationManager.ConnectionStrings[konekcioniString].ConnectionString);
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();


                string upit = "INSERT INTO Fakulteti(naziv) values('" + listaFakulteta[cbxFakulteti.SelectedIndex] + "');";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.ExecuteNonQuery();


                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Javio se izuzetak", MessageBoxButtons.OK);
            }
        }
    }
}
