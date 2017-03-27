using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Data.SqlTypes;
using System.Data;

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

        /// <summary>
        /// Proveravanje jedinstvenosti izabranog parametra. Tipovi parametara: 1-Korisnicko ime 2-Email
        /// </summary>
        private static bool PostojiParametar(string pparametar, int tipParametra)
        {
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);

            try
            {
                konekcija.Open();
                string upit;
                if (tipParametra == 1)
                    upit = "SELECT count(*) FROM Korisnici WHERE korisnickoIme=@ProsledjeniParametar;";
                else
                    upit = "SELECT count(*) FROM Korisnici WHERE email=@ProsledjeniParametar;";

                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("ProsledjeniParametar", pparametar);
                System.Windows.Forms.MessageBox.Show(upit);
                int rezultat = Convert.ToInt32(komanda.ExecuteScalar());
                System.Windows.Forms.MessageBox.Show(rezultat.ToString());
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

        /// <summary>
        /// Da li postoji zadati email?
        /// </summary>
        public static bool PostojiEmail(string email)
        {
            return PostojiParametar(email, 2);
        }

        /// <summary>
        /// Da li postoji zadato korisničko ime?
        /// </summary>
        public static bool PostojiKorisnickoIme(string korisnickoIme)
        {
            return PostojiParametar(korisnickoIme, 1);
        }

        /// <summary>
        /// Korisnikčkom nalogu sa zadatim ID-em se dodaju zadati email, korisničko ime i broj telefona.
        /// </summary>
        public static bool DodajPodatkePriPrvojPrijaviNaAplikaciju(string email, string korisnickoIme, string brojTelefona, string novaSifra, int korisnikId)
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
                string upit = "UPDATE Korisnici SET email=@Email, korisnickoIme=@KorisnickoIme, brojTelefona=@BrojTelefona, lozinka=@NovaSifra WHERE idKorisnik=@KorisnikId;";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("Email", email);
                komanda.Parameters.AddWithValue("KorisnickoIme", korisnickoIme);
                komanda.Parameters.AddWithValue("BrojTelefona", brojTelefona);
                komanda.Parameters.AddWithValue("NovaSifra", MD5Hash(novaSifra));
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

        /// <summary>
        /// Broj obroka na nalogu korisnika sa zadatim ID-em. Tipovi obroka: 1-Doručak, 2-Ručak, 3-Večera
        /// </summary>
        private static int BrojObrokaKorisnika(int idKorisnik, int tip)
        {
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);

            try
            {
                konekcija.Open();

                string upit = "SELECT count(*) FROM Obroci WHERE idUplatioca=@IdUplatilac AND tipObroka=@Tip AND iskoriscen=0;";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("IdUplatilac", idKorisnik);
                komanda.Parameters.AddWithValue("Tip", tip);
                int rezultat = Convert.ToInt32(komanda.ExecuteScalar());
                return rezultat;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
            return 0;
        }

        /// <summary>
        /// Broj doručka na nalogu korisnika sa zadatim ID-em.
        /// </summary>
        public static int BrojDoruckaKorisnika(int idKorisnik)
        {
            return BrojObrokaKorisnika(idKorisnik, 1);
        }

        /// <summary>
        /// Broj ručkova na nalogu korisnika sa zadatim ID-em.
        /// </summary>
        public static int BrojRuckovaKorisnika(int idKorisnik)
        {
            return BrojObrokaKorisnika(idKorisnik, 2);
        }

        /// <summary>
        /// Broj večera na nalogu korisnika sa zadatim ID-em.
        /// </summary>
        public static int BrojVeceraKorisnika(int idKorisnik)
        {
            return BrojObrokaKorisnika(idKorisnik, 3);
        }

        /// <summary>
        /// Ime korisnika sa zadatim ID-em.
        /// </summary>
        public static string ImeKorisnika(int idKorisnik)
        {
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);

            try
            {
                konekcija.Open();

                string upit = "SELECT ime FROM Korisnici WHERE idKorisnik=@IdKorisnik;";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("IdKorisnik", idKorisnik);
                string rezultat = komanda.ExecuteScalar().ToString();
                return rezultat;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
            return string.Empty;
        }

        /// <summary>
        /// Prezime korisnika sa zadatim ID-em.
        /// </summary>
        public static string PrezimeKorisnika(int idKorisnik)
        {
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);

            try
            {
                konekcija.Open();

                string upit = "SELECT prezime FROM Korisnici WHERE idKorisnik=@IdKorisnik;";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("IdKorisnik", idKorisnik);
                string rezultat = komanda.ExecuteScalar().ToString();
                return rezultat;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
            return string.Empty;
        }

        /// <summary>
        /// Pomoćna funkcija za računanje MD5.
        /// </summary>
        private static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        /// <summary>
        /// Dodavanje lozinke zadatom ID-u,
        /// </summary>
        public static bool DodajLozinkuZaID(int idKorisnik, string lozinka)
        {
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);

            try
            {
                konekcija.Open();

                string MD5lozinke = MD5Hash(lozinka);
                string upit = "UPDATE Korisnici SET lozinka=@MD5lozinke WHERE idKorisnik=@IdKorisnik;";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("IdKorisnik", idKorisnik);
                komanda.Parameters.AddWithValue("MD5lozinke", MD5lozinke);
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

        /// <summary>
        /// Dodaj lozinku, ime, prezime, datum rođenja, datum registracije, fakultet, broj indeksa. Datum isteka naloga će biti izračunat i dodat. Onemogućiti dodavanje broja indeksa i fakulteta nalozima zaposlenih!
        /// </summary>
        public static bool DodajPodatkePriRegistracijiKorisnikaUSistem(int tipNaloga, string lozinka, string ime, string prezime, DateTime datumRodjenja, DateTime datumRegistracije, int fakultet = 0, int brojIndeksa = 0)
        {
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);

            try
            {
                konekcija.Open();

                string MD5lozinke = MD5Hash(lozinka);
                string upit = "INSERT INTO Korisnici (tipNaloga, lozinka, ime, prezime, datumRodjenja, datumRegistracije, fakultet, brojIndeksa, datumVaziDo) VALUES (@TipNaloga, @MD5lozinke, @Ime, @Prezime, @DatumRodjenja, @DatumRegistracije, @Fakultet, @BrojIndeksa, @DatumIstekaNaloga);";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);

                komanda.Parameters.AddWithValue("TipNaloga", tipNaloga);
                komanda.Parameters.AddWithValue("MD5lozinke", MD5lozinke);
                komanda.Parameters.AddWithValue("Ime", ime);
                komanda.Parameters.AddWithValue("Prezime", prezime);
                komanda.Parameters.AddWithValue("DatumRodjenja", datumRodjenja);
                komanda.Parameters.AddWithValue("DatumRegistracije", datumRegistracije);
                if (fakultet != 0)
                    komanda.Parameters.AddWithValue("Fakultet", fakultet);
                else
                    komanda.Parameters.AddWithValue("Fakultet", DBNull.Value);
                if (brojIndeksa != 0)
                    komanda.Parameters.AddWithValue("BrojIndeksa", brojIndeksa);
                else
                    komanda.Parameters.AddWithValue("BrojIndeksa", DBNull.Value);

                DateTime datumIstekaNaloga;
                if (datumRegistracije.Month >= 1 && datumRegistracije.Month <= 9)
                    datumIstekaNaloga = new DateTime(datumRegistracije.Year, 10, 31);
                else
                    datumIstekaNaloga = new DateTime(datumRegistracije.Year + 1, 10, 31);
                komanda.Parameters.AddWithValue("DatumIstekaNaloga", datumIstekaNaloga);

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

        /// <summary>
        /// Da li zadata lozinka odgovara zadatom korisnickom imenu.
        /// </summary>
        public static bool LozinkaOdgovaraKorisnickomImenu(string unetaLozinka, string unetoKorisnickoIme)
        {
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);

            try
            {
                konekcija.Open();

                string MD5lozinke = MD5Hash(unetaLozinka);
                string upit = "SELECT count(*) FROM Korisnici WHERE lozinka=@MD5lozinke AND korisnickoIme=@KorisnickoIme;";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("MD5lozinke", MD5lozinke);
                komanda.Parameters.AddWithValue("KorisnickoIme", unetoKorisnickoIme);
                int rezultat = Convert.ToInt32(komanda.ExecuteScalar());

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

        /// <summary>
        /// Da li zadata lozinka odgovara zadatom email-u.
        /// </summary>
        public static bool LozinkaOdgovaraEmailu(string unetaLozinka, string unetiEmail)
        {
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);

            try
            {
                konekcija.Open();

                string MD5lozinke = MD5Hash(unetaLozinka);
                string upit = "SELECT count(*) FROM Korisnici WHERE lozinka=@MD5lozinke AND email=@Emal;";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("MD5lozinke", MD5lozinke);
                komanda.Parameters.AddWithValue("Emal", unetiEmail);
                int rezultat = Convert.ToInt32(komanda.ExecuteScalar());

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

        /// <summary>
        /// Datum rođenja korisnika sa zadatim ID-em.
        /// </summary>
        public static DateTime DatumRodjenjaKorisnika(int idKorisnik)
        {
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);

            try
            {
                konekcija.Open();

                string upit = "SELECT datumRodjenja FROM Korisnici WHERE idKorisnik=@IdKorisnik;";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("IdKorisnik", idKorisnik);
                DateTime rezultat = (DateTime)komanda.ExecuteScalar();
                return rezultat;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
            return DateTime.Now;
        }

        /// <summary>
        /// Datum registracije korisnika sa zadatim ID-em.
        /// </summary>
        public static DateTime DatumRegistracijeKorisnika(int idKorisnik)
        {
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);

            try
            {
                konekcija.Open();

                string upit = "SELECT datumRegistracije FROM Korisnici WHERE idKorisnik=@IdKorisnik;";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("IdKorisnik", idKorisnik);
                DateTime rezultat = (DateTime)komanda.ExecuteScalar();
                return rezultat;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
            return DateTime.Now;
        }

        /// <summary>
        /// Datum isteka naloga korisnika sa zadatim ID-em.
        /// </summary>
        public static DateTime DatumIstekaNaloga(int idKorisnik)
        {
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);

            try
            {
                konekcija.Open();

                string upit = "SELECT datumVaziDo FROM Korisnici WHERE idKorisnik=@IdKorisnik;";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("IdKorisnik", idKorisnik);
                DateTime rezultat = (DateTime)komanda.ExecuteScalar();
                return rezultat;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
            return DateTime.Now;
        }

        /// <summary>
        /// Obrok čiji je broj potrebno umanjiti. Tipovi obroka: 1-Doručak, 2-Ručak, 3-Večera
        /// </summary>
        private static bool UmanjiObrok(int idKorisnik, int tipObroka)
        {
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);

            try
            {
                konekcija.Open();

                string upitZaID = "SELECT idObrok FROM Obroci WHERE idUplatioca=@IdKorisnik AND tipObroka=@TipObroka AND iskoriscen=0";
                MySqlCommand komandaZaID = new MySqlCommand(upitZaID, konekcija);
                komandaZaID.Parameters.AddWithValue("IdKorisnik", idKorisnik);
                komandaZaID.Parameters.AddWithValue("TipObroka", tipObroka);
                int rezultatID = Convert.ToInt32(komandaZaID.ExecuteScalar());

                string upit = "UPDATE Obroci SET iskoriscen=1 WHERE idObrok=@RezultatID;";
                MySqlCommand komanda = new MySqlCommand(upit, konekcija);
                komanda.Parameters.AddWithValue("RezultatID", rezultatID);
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

        /// <summary>
        /// Umanji broj doručka korisniku sa zadatim ID-em.
        /// </summary>
        public static bool UmanjiDorucak(int idKorisnik)
        {
            return UmanjiObrok(idKorisnik, 1);
        }

        /// <summary>
        /// Umanji broj doručka korisniku sa zadatim ID-em.
        /// </summary>
        public static bool UmanjiRucak(int idKorisnik)
        {
            return UmanjiObrok(idKorisnik, 2);
        }

        /// <summary>
        /// Umanji broj doručka korisniku sa zadatim ID-em.
        /// </summary>
        public static bool UmanjiVeceru(int idKorisnik)
        {
            return UmanjiObrok(idKorisnik, 3);
        }
    }
}
