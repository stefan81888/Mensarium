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
    public partial class Korisnici : Form
    {
        private List<string> listaFakulteta;
        private List<string> listaNaloga;

        public Korisnici()
        {
            InitializeComponent();
            listaFakulteta = new List<string>();
            listaNaloga = new List<string>();         

            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            //za fakultete i tipove naloga proslediti selected indeks + 1 

            try
            {
                // uspostavljanje i otvaranje konekcije
                string konekcioniString = @"Data Source=160.99.38.10; Database=mensarium_db; User ID=mensarium; Password='Vodja.204'; Port=6666;";                                                                                                                                                  //SqlConnection konekcija = new SqlConnection(ConfigurationManager.ConnectionStrings[konekcioniString].ConnectionString);
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();

                string datumRodjenja = dtRodjenje.Value.ToString("yyyy-MM-dd");
                string datumRegistracije = dtRegistracija.Value.ToString("yyyy-MM-dd");
                string datumVaziDo = dtVaziDo.Value.ToString("yyyy-MM-dd");
                int tipNaloga = cbxTipNaloga.SelectedIndex + 1;
                int fakultet = cbxFakultet.SelectedIndex + 1;


                string upit = "INSERT INTO Korisnici VALUES(NULL, '" + tbKorisnicko.Text + "','" + tbEmail.Text + "','" + tbLozinka.Text + "','" + tbIme.Text + "','" + tbPrezime.Text + "','" + datumRodjenja + "','" + datumRegistracije + "','" + tbBrojTelefona.Text + "'," + fakultet.ToString() + ",'" + tbBrojIndeksa.Text + "','" + datumVaziDo + "','" + tipNaloga + "')";
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
            List<string> listaKorisnickih = new List<string>();
            listaKorisnickih.Add("k1");
            listaKorisnickih.Add("k2");
            listaKorisnickih.Add("k3");
            listaKorisnickih.Add("k");
            listaKorisnickih.Add("r");
            listaKorisnickih.Add("k6");
            listaKorisnickih.Add("k7");
            listaKorisnickih.Add("k");
            listaKorisnickih.Add("k9");
            listaKorisnickih.Add("k10");
            listaKorisnickih.Add("ko10");
            listaKorisnickih.Add("kor10");

            List<string> listaImena = new List<string>();
            listaImena.Add("Marko");
            listaImena.Add("Matej");
            listaImena.Add("Luka");
            listaImena.Add("Jovan");
            listaImena.Add("Marija");
            listaImena.Add("Milica");
            listaImena.Add("Jelena");
            listaImena.Add("Nikola");
            listaImena.Add("Nikola");
            listaImena.Add("Nikola");
            listaImena.Add("Jovana");
            listaImena.Add("Dejan");

            List<string> listaEmailova = new List<string>();
            listaEmailova.Add("a@gmail.com");
            listaEmailova.Add("b@gmail.com");
            listaEmailova.Add("c@gmail.com");
            listaEmailova.Add("d@gmail.com");
            listaEmailova.Add("e@gmail.com");
            listaEmailova.Add("f@gmail.com");
            listaEmailova.Add("e@gmail.com");
            listaEmailova.Add("e@gmail.com");
            listaEmailova.Add("g@gmail.com");
            listaEmailova.Add("h@gmail.com");
            listaEmailova.Add("abc@gmail.com");
            listaEmailova.Add("cba@gmail.com");

            List<string> listaLozinki = new List<string>();
            listaLozinki.Add("asdfgg");
            listaLozinki.Add("2134");
            listaLozinki.Add("asdfgg");
            listaLozinki.Add("assdfddfgg");
            listaLozinki.Add("asvbvdfgg");
            listaLozinki.Add("asadcvdfgg");
            listaLozinki.Add("yyy");
            listaLozinki.Add("asdasfsdfgg");
            listaLozinki.Add("wert");
            listaLozinki.Add("gf");
            listaLozinki.Add("asdasfsdfgg");
            listaLozinki.Add("asdasfsdfgg");

            List<string> listaPrezimena = new List<string>();
            listaPrezimena.Add("Krstic");
            listaPrezimena.Add("Stankovic");
            listaPrezimena.Add("Jovanovic");
            listaPrezimena.Add("Aleksic");
            listaPrezimena.Add("Petkovic");
            listaPrezimena.Add("Stojkovic");
            listaPrezimena.Add("Krstic");
            listaPrezimena.Add("Nikolic");
            listaPrezimena.Add("Vuckovic");
            listaPrezimena.Add("Krstic");
            listaPrezimena.Add("Vuckovic");
            listaPrezimena.Add("Vuckovic");
            

            Random random = new Random();
            Random rand = new System.Random();



            int brojRedova = int.Parse(tbRandom.Text);

            try { 
            string konekcioniString = @"Data Source=160.99.38.10; Database=mensarium_db; User ID=mensarium; Password='Vodja.204'; Port=6666;";                                                                                                                                                 
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);
            konekcija.Open();

            for (int i = 0; i < brojRedova; i++)
            {              

               string datumRodjenja = rand.Next(1950, 2005).ToString() + "-" + rand.Next(1, 12).ToString() + "-" + rand.Next(1, 30).ToString();
               string datumRegistracije = DateTime.Now.ToString("yyyy-MM-dd");
               string datumVazenja = DateTime.Now.AddYears(1).ToString("yyyy-MM-dd");

                string brojTelefona = random.Next(100000, 999999).ToString();
                int fakultet = random.Next(1, 4);
                string brojIndeksa = random.Next(1, 16000).ToString();
                int tipNaloga = random.Next(1, 5);
                int podaci = random.Next(0, 10);

                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijKLMNO34PQRSklmnopqrstuvwxyz0123456789";
                    var stringChars = new char[8];                    

                    for (int j = 0; j < stringChars.Length; j++)
                    {
                        stringChars[j] = chars[random.Next(chars.Length)];
                    }

                    var finalString = new String(stringChars);

                 string upit = @"INSERT INTO Korisnici VALUES(NULL, '" + listaKorisnickih[podaci] + finalString  + "','"
                        + finalString + listaEmailova[podaci] + "','"
                        + listaLozinki[podaci] + "','"
                        + listaImena[podaci] + "','"
                        + listaPrezimena[podaci] + "','" 
                        + datumRodjenja + "','"
                        + datumRegistracije + "','" 
                        + brojTelefona + "'," + fakultet.ToString() + ",'" 
                        + brojIndeksa + "','" + datumVazenja + "'," + tipNaloga.ToString() + ")";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.ExecuteNonQuery();                
            }
            konekcija.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Javio se izuzetak", MessageBoxButtons.OK);
            }

        }
    }
}
