using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace Upiti
{
    public static class Upiti
    {
        #region Database config
        private const string SERVER = "160.99.38.10";
        private const string DATABASE = "mensarium_db";
        private const string USERNAME = "mensarium";
        private const string PASSWORD = "Vodja.204";
        private const string PORT = "6666";

        private static string konekcioniString = @"Data Source=" + SERVER + ";" +
                                                  "Database=" + DATABASE + ";" +
                                                  "User ID=" + USERNAME + ";" +
                                                  "Password='" + PASSWORD + "';" +
                                                  "Port=" + PORT + ";"; 
        #endregion

        public static bool PostojiIdKorisnika(int idKorisnik)
        {
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                
            try
            {
                konekcija.Open();

                string upit = "SELECT count(*) FROM Korisnici WHERE idKorisnik=@IdKorisnik;";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("IdKorisnik", idKorisnik);
                int rezultat = Convert.ToInt32(komanda.ExecuteScalar());
                if (rezultat == 1)
                    return true;
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                konekcija.Close();
            }

            return false;
            
        }

        public static bool PostojiEmail(string email)
        {
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);

            try
            {
                konekcija.Open();

                string upit = "SELECT count(*) FROM Korisnici WHERE email=@Email;";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("Email", email);
                int rezultat = Convert.ToInt32(komanda.ExecuteScalar());
                if (rezultat == 1)
                    return true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                konekcija.Close();
            }

            return false;
        }

        public static bool PostojiKorisnickoIme(string korisnickoIme)
        {
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);

            try
            {
                konekcija.Open();

                string upit = "SELECT count(*) FROM Korisnici WHERE korisnickoIme=@KorisnickoIme;";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("KorisnickoIme", korisnickoIme);
                int rezultat = Convert.ToInt32(komanda.ExecuteScalar());
                if (rezultat == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                konekcija.Close();
            }

            return false;
        }

        public static string LozinkaZaId(int idKorisnik)
        {
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);

            try
            {
                konekcija.Open();

                string upit = "SELECT lozinka FROM Korisnici WHERE idKorisnik=@IdKorisnik;";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("IdKorisnik", idKorisnik);
                string rezultat = komanda.ExecuteScalar().ToString();
                return rezultat;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                konekcija.Close();
            }
            return string.Empty;
        }

        public static string LozinkaZaMail(string email)
        {
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);

            try
            {
                konekcija.Open();

                string upit = "SELECT lozinka FROM Korisnici WHERE email=@Email;";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("Email", email);
                string rezultat = komanda.ExecuteScalar().ToString();
                return rezultat;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                konekcija.Close();
            }
            return string.Empty;
        }

        public static string LozinkaZaKorisnickoIme(string korisnickoIme)
        {
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);

            try
            {
                konekcija.Open();

                string upit = "SELECT lozinka FROM Korisnici WHERE korisnickoIme=@KorisnickoIme;";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("KorisnickoIme", korisnickoIme);
                string rezultat = komanda.ExecuteScalar().ToString();
                return rezultat;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                konekcija.Close();
            }
            return string.Empty;
        }

        public static bool DodajPodatke(string email, string korisnickoIme, string brojTelefona, int korisnikId)
        {
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);
            
            //Dodavanje podataka prilikom registracije
            try
            {
                konekcija.Open();

                //Proveravanje jedinstvenosti email-a
                string upitZaEmail = "SELECT count(*) FROM Korisnici WHERE email=@Email;";
                MySqlCommand komandaZaMail = new MySqlCommand(upitZaEmail, konekcija);
                komandaZaMail.Parameters.AddWithValue("Email", email);
                int brojEmailova = Convert.ToInt32(komandaZaMail.ExecuteScalar());
                if (brojEmailova != 0)
                    return false;

                //Proveravanje jedinstvenosti korisnickog imena
                string upitZaKorisnickoIme = "SELECT count(*) FROM Korisnici WHERE korisnickoIme=@KorisnickoIme;";
                MySqlCommand komandaZaKorisnickoIme = new MySqlCommand(upitZaKorisnickoIme, konekcija);
                komandaZaKorisnickoIme.Parameters.AddWithValue("KorisnickoIme", korisnickoIme);
                int brojKorisnickihImena = Convert.ToInt32(komandaZaKorisnickoIme.ExecuteScalar());
                if (brojKorisnickihImena != 0)
                    return false;

                //Dodavanje podataka
                string upit = "UPDATE Korisnici SET email=@Email, korisnickoIme=@KorisnickoIme, brojTelefona=@BrojTelefona WHERE idKorisnik=@KorisnikId;";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("Email", email);
                komanda.Parameters.AddWithValue("KorisnickoIme", korisnickoIme);
                komanda.Parameters.AddWithValue("BrojTelefona", brojTelefona);
                komanda.Parameters.AddWithValue("KorisnikId", korisnikId);
                int rezultat = komanda.ExecuteNonQuery();
                if (rezultat == 1)
                   return true;

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }

            return false;
        }
    }
}
