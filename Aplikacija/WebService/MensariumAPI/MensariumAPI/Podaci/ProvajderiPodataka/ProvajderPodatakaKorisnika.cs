using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.DTO;
using MensariumAPI.Podaci.Entiteti;
using Microsoft.Ajax.Utilities;
using NHibernate;
using NHibernate.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Net;
using System.Web.UI.WebControls;
using EASendMail;
using FluentNHibernate.Conventions;
using NHibernate.Mapping;

namespace MensariumAPI.Podaci.ProvajderiPodataka
{
    public class ProvajderPodatakaKorisnika
    {
        #region Podaci
        private static string server_mail = "dalibor.aleksic.dacha@gmail.com";
        private static string verifikacioni_link = "http://160.99.38.140:2244/api/korisnici/verifikacija";
        private static string promena_emaila_link = "http://160.99.38.140:2244/api/korisnici/mail/reset";

        public delegate KorisnikKreiranjeDto KreiranjeKorisnika(KorisnikKreiranjeDto kkdto);
        public delegate List<KorisnikFollowDto> PretragaKorisnika(PretragaKriterijumDto pkdto);
        public delegate List<KorisnikFullDto> SviKorisnici();

        public List<KreiranjeKorisnika> listaDelegataKreiranja = new List<KreiranjeKorisnika>();
        public List<PretragaKorisnika> listaDelegataPretrage = new List<PretragaKorisnika>();
        public List<SviKorisnici> listaDelegataSvihKorisnika = new List<SviKorisnici>();
        
       //GUID adresira dictionari sa parom id-novi mail 
       //Promena email adrese
        public static Dictionary<string, Dictionary<int, string>> promenaMaila =
            new Dictionary<string, Dictionary<int, string>>();
        
        //Pamti par username-pin(privremena sifra)
        public static Dictionary<string, string> passRecovery = new Dictionary<string, string>();

        #endregion

        public ProvajderPodatakaKorisnika()
        {
            listaDelegataKreiranja.Add(DodajAdministratora);
            listaDelegataKreiranja.Add(DodajMenadzera);
            listaDelegataKreiranja.Add(DodajUplatu);
            listaDelegataKreiranja.Add(DodajNaplatu);
            listaDelegataKreiranja.Add(DodajStudenta);

            listaDelegataKreiranja.Add(AzurirajAdministratora);
            listaDelegataKreiranja.Add(AzurirajMenadzera);
            listaDelegataKreiranja.Add(AzurirajUplatu);
            listaDelegataKreiranja.Add(AzurirajNaplatu);
            listaDelegataKreiranja.Add(AzurirajStudenta);

            listaDelegataPretrage.Add(PretraziSveNaloge);
            listaDelegataPretrage.Add(PretraziSveNaloge);
            listaDelegataPretrage.Add(PretraziSveNaloge);
            listaDelegataPretrage.Add(PretraziSveNaloge);
            listaDelegataPretrage.Add(PretraziStudente);

            listaDelegataSvihKorisnika.Add(VratiKorisnikeAdmin);
            listaDelegataSvihKorisnika.Add(VratiKorisnikeOstali);
            listaDelegataSvihKorisnika.Add(VratiKorisnikeOstali);
            listaDelegataSvihKorisnika.Add(VratiKorisnikeOstali);
            listaDelegataSvihKorisnika.Add(VratiKorisnikeStudent);
        }

        public static Korisnik VratiKorisnika(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            Korisnik k = s.Get<Korisnik>(id);

            if (k == null)
                return null;

            if (k.Obrisan)
                return null;

            if (!k.AktivanNalog)
                return null;

            return k;
        }

        public static List<Korisnik> VratiKorisnike()
        {
            ISession s = SesijeProvajder.Sesija;
            List<Korisnik> korisnici = s.Query<Korisnik>().Select(k => k).ToList();
            korisnici.RemoveAll(x => x.Obrisan);
            korisnici.RemoveAll(x => !x.AktivanNalog);

            return korisnici;
        }

        public static void DodajKorisnika(Korisnik k)
        {
            ISession s = SesijeProvajder.Sesija;
            s.Save(k);
            s.Flush();
        }

        public static void UpdateKorisnika(Korisnik k)
        {
            ISession s = SesijeProvajder.Sesija;
            s.Update(k);
            s.Flush();
        }

        public static SesijaDto PrijavaKorisnika(ClientLoginDto cdto)
        {
            ISession s = SesijeProvajder.Sesija;
            
            List<Korisnik> korisnici = s.Query<Korisnik>().Select(k => k).ToList();
            
            /*
            List<Korisnik> ko = (from k in korisnici
                where k.KorisnickoIme == cdto.KIme_Mail
                || k.Email == cdto.KIme_Mail
                select k).ToList();

            if (ko.Count != 1)
                return null;

            if (ko[0].Sifra != cdto.Sifra)
                return null;

            if (ko[0].Obrisan)
                return null;

            if (!ko[0].AktivanNalog)
                return null;
            */

            Korisnik ko = korisnici.Find(x => x.KorisnickoIme == cdto.KIme_Mail
                                         || x.Email == cdto.KIme_Mail);

            if (ko == null)
                return null;

            if (ko.Obrisan)
                return null;

            if (!ko.AktivanNalog)
                return null;

            if (ko.Sifra != cdto.Sifra)
                return null;

            LoginSesija sesija = new LoginSesija()
            {
                KorisnikSesije = ko,
                IdSesije = Guid.NewGuid().ToString(),
                DatumPrijavljivanja = DateTime.Now,
                ValidnaDo = DateTime.Now.AddYears(1)
            };
            s.Save(sesija);
            s.Flush();

            SesijaDto sdto = new SesijaDto()
            {
                IdSesije = sesija.IdSesije,
                IdKorisnika = sesija.KorisnikSesije.IdKorisnika,
                DatumPrijavljivanja = sesija.DatumPrijavljivanja,
                ValidnaDo = sesija.ValidnaDo
            };

            return sdto;
        }

        public static bool Zaprati(int idPratioca, int idPracenog)
        {
            if (idPracenog == idPratioca)
                return false;

            ISession s = SesijeProvajder.Sesija;

            Korisnik pratilac = VratiKorisnika(idPratioca);

            if (pratilac == null)
                return false;

            Korisnik praceni = VratiKorisnika(idPracenog);

            if (praceni == null)
                return false;

            if (praceni.PracenOd.Contains(pratilac))
                return false;

            praceni.PracenOd.Add(pratilac);
            pratilac.Prati.Add(praceni);

            s.Save(praceni);
            s.Save(pratilac);

            s.Flush();

            return true;
        }

        public static List<KorisnikFollowDto> SvaPracenja(int id)
        {
            Korisnik k = VratiKorisnika(id);

            if (k == null)
                return null;

            if (k.TipNaloga.IdTip != 5)
                return null;

            if (k.Prati.Count == 0)
                return null;

            List<KorisnikFollowDto> praceni = new List<KorisnikFollowDto>();

            List<Korisnik> lista = k.Prati.ToList();
            lista.RemoveAll(x => !x.AktivanNalog);
            lista.RemoveAll(x => x.Obrisan);

            foreach (var ko in lista)
            {
                KorisnikFollowDto kdto = new KorisnikFollowDto()
                {
                    IdKorisnika = ko.IdKorisnika,
                    KorisnickoIme = ko.KorisnickoIme,
                    Ime = ko.Ime,
                    Prezime = ko.Prezime,
                    Fakultet = ko.StudiraFakultet.Naziv,
                    Zapracen = true
                };
                praceni.Add(kdto);
            }
            return praceni;
        }

        public static List<KorisnikFollowDto> Pretraga(PretragaKriterijumDto pkdto)
        {
            ISession s = SesijeProvajder.Sesija;

            Korisnik pretrazuje = VratiKorisnika(pkdto.IdKorisnika);
            List<KorisnikFollowDto> rezultat = new List<KorisnikFollowDto>();
            List<Korisnik> korisnici = s.Query<Korisnik>().Select(k => k).Where(x => x.KorisnickoIme != null).ToList();

            List<Korisnik> lista = (from k in korisnici
                                    where k.Ime.StartsWith(pkdto.Kriterijum)
                                    || k.Prezime.StartsWith(pkdto.Kriterijum)
                                    || k.KorisnickoIme.StartsWith(pkdto.Kriterijum)
                                    || k.Email.StartsWith(pkdto.Kriterijum)
                                    || k.Ime.StartsWith(char.ToUpper(pkdto.Kriterijum[0]) + pkdto.Kriterijum.Substring(1))
                                    || k.Prezime.StartsWith(char.ToUpper(pkdto.Kriterijum[0]) + pkdto.Kriterijum.Substring(1))
                                    || k.KorisnickoIme.StartsWith(char.ToLower(pkdto.Kriterijum[0]) + pkdto.Kriterijum.Substring(1))
                                    || k.Email.StartsWith(char.ToLower(pkdto.Kriterijum[0]) + pkdto.Kriterijum.Substring(1))
                                    select k).ToList();

            lista.RemoveAll(x => x.Obrisan);
            lista.RemoveAll(x => !x.AktivanNalog);
            lista.RemoveAll(x => x.IdKorisnika == pkdto.IdKorisnika);

            foreach (var v in lista)
            {
                KorisnikFollowDto kdto = new KorisnikFollowDto()
                {
                    KorisnickoIme = v.KorisnickoIme,
                    Ime = v.Ime,
                    Prezime = v.Prezime,
                    IdKorisnika = v.IdKorisnika,
                    Zapracen = false,
                    IdTipNaloga = v.TipNaloga.IdTip
                };
                if (pretrazuje.PracenOd.ToList().Contains(v))
                    kdto.Zapracen = true;
                if (v.StudiraFakultet != null)
                    kdto.Fakultet = v.StudiraFakultet.Naziv;
                rezultat.Add(kdto);
            }

            rezultat.Sort((y, x) => x.IdTipNaloga.CompareTo(y.IdTipNaloga));
            return rezultat;
        }

        public static List<KorisnikFollowDto> PretraziStudente(PretragaKriterijumDto pkdto)
        {
            List<KorisnikFollowDto> svi = Pretraga(pkdto);
            return UkloniOstaleNaloge(svi);
        }

        public static List<KorisnikFollowDto> PretraziSveNaloge(PretragaKriterijumDto pkdto)
        {
            return Pretraga(pkdto);
        }

        public static List<KorisnikFollowDto> UkloniOstaleNaloge(List<KorisnikFollowDto> lista)
        {
            lista.RemoveAll(x => x.IdTipNaloga != 5);
            lista.Sort((y, x) => x.Zapracen.CompareTo(y.Zapracen));
            return lista;
        }

        public static KorisnikStanjeDto Stanje(Korisnik korisnik)
        {
            ISession s = SesijeProvajder.Sesija;

            int doruckovi = korisnik.Obroci.Count(x => x.Iskoriscen == false && x.Tip.IdTipObroka == 1);
            int ruckovi = korisnik.Obroci.Count(x => x.Iskoriscen == false && x.Tip.IdTipObroka == 2);
            int vecere = korisnik.Obroci.Count(x => x.Iskoriscen == false && x.Tip.IdTipObroka == 3);

            KorisnikStanjeDto k = new KorisnikStanjeDto();

            k.BrojDorucka = doruckovi;
            k.BrojRuckova = ruckovi;
            k.BrojVecera = vecere;

            return k;
        }

        public static PozivanjaFullDto Pozovi(PozivanjaFullDto pfdto, string sid)
        {
            ISession s = SesijeProvajder.Sesija;
            
            Korisnik pozivalac = VratiKorisnika(ProvajderPodatakaKorisnika.KorisnikIDizSesijaID(sid));
            if (pozivalac == null)
                return null; 

            List<Korisnik> pozvani = new List<Korisnik>();
            Pozivanje poziv = new Pozivanje()
            {
                DatumPoziva = pfdto.DatumPoziva,
                VaziDo = pfdto.VaziDo,
                Pozivaoc = pozivalac
            };

            for (int i = 0; i < pfdto.Pozvani.Count; i++)
            {
                Korisnik k = VratiKorisnika(pfdto.Pozvani[i]);
                if(k != null)
                    pozvani.Add(k);
            }

            foreach (var v in pozvani)
            {
                PozivanjaPozvani pp = new PozivanjaPozvani()
                {
                    IdPozivanjaPozvani =
                    {
                        IdPoziva = poziv,
                        IdPozvanog = v
                    },
                    OdgovorPozvanog = false
                };

                v.PozivanjaOd.Add(pp);
            }

            pozivalac.Pozivi.Add(poziv);

            //prebaciti izmedju prethodnih foreach petlji
            s.Save(poziv);
            s.Save(pozivalac);
           

            foreach (var v in pozvani)
            {
                s.Save(v); 
            }

            s.Flush();

            List<Pozivanje> p = s.Query<Pozivanje>().Select(x => x).ToList();

            if (p.Count == 0)
                return null;

            Pozivanje po = p.Find(x => x.Pozivaoc.IdKorisnika == pozivalac.IdKorisnika && x.DatumPoziva == poziv.DatumPoziva);

            if (po == null)
                return null;

            pfdto.IdPoziva = po.IdPoziva;

            return pfdto;  
        }

        public static List<PozivanjaNewsFeedItemDto> SviPozivi(int id)
        {
            ISession s = SesijeProvajder.Sesija;

            Korisnik pozivalac = VratiKorisnika(id);
            if (pozivalac == null)
                return null;

            if (pozivalac.PozivanjaOd.ToList().Count == 0)
                return null;

            List<PozivanjaNewsFeedItemDto> sviPozivi = new List<PozivanjaNewsFeedItemDto>();


            foreach (var v in pozivalac.PozivanjaOd.ToList())
            {
                int idPoziva = v.IdPozivanjaPozvani.IdPoziva.IdPoziva;
                Pozivanje p = s.Get<Pozivanje>(idPoziva);
              
                Korisnik k = VratiKorisnika(p.Pozivaoc.IdKorisnika);

                PozivanjaNewsFeedItemDto pnfidto = new PozivanjaNewsFeedItemDto()
                {
                    IdPoziva = p.IdPoziva,
                    DatumPoziva = p.DatumPoziva,
                    VaziDo = p.VaziDo,
                    IdPozivaoca = k.IdKorisnika,
                    KorisnickoImePozivaoca = k.KorisnickoIme,
                    PrezimePozivaoca = k.Prezime,
                    ImePozivaoca = k.Ime
                };
                sviPozivi.Add(pnfidto);
            }

            sviPozivi.RemoveAll(x => x.DatumPoziva < DateTime.Now);
            sviPozivi.RemoveAll(x => x.DatumPoziva > x.VaziDo);
            sviPozivi.RemoveAll(x => x.VaziDo < DateTime.Now);
            sviPozivi.Sort((x, y) => y.DatumPoziva.CompareTo(x.DatumPoziva));

            return sviPozivi;
        }

        public static PozivanjaPozvaniDto OdogovoriNaPoziv(PozivanjaPozvaniDto ppdto, string sid)
        {
            ISession s = SesijeProvajder.Sesija;

            Korisnik k = VratiKorisnika(KorisnikIDizSesijaID(sid));
            if (k == null)
                return null;

            if (k.TipNaloga.IdTip != 5)
                return null;

            Pozivanje p = s.Get<Pozivanje>(ppdto.IdPoziva);
            if (p == null)
                return null;

            PozivanjaPozvani pp = new PozivanjaPozvani()
            {
                IdPozivanjaPozvani =
                {
                    IdPoziva = p,
                    IdPozvanog = k
                },
                OdgovorPozvanog = ppdto.OdgovorPozvanog
            };

            s.Update(pp);
            s.Flush();

            return ppdto;
        }

        public static bool PrestaniDaPratis(int idPratilac, int idPraceni)
        {
            if (idPraceni == idPratilac)
                return false;

            ISession s = SesijeProvajder.Sesija;

            Korisnik pratilac = VratiKorisnika(idPratilac);

            if (pratilac == null)
                return false;

            if (pratilac.TipNaloga.IdTip != 5)
                return false;

            Korisnik praceni = VratiKorisnika(idPraceni);

            if (praceni == null)
                return false;

            if (praceni.TipNaloga.IdTip != 5)
                return false;

            if (!praceni.PracenOd.ToList().Contains(pratilac))
                return false;

            if (!pratilac.Prati.ToList().Contains(praceni))
                return false;

            praceni.PracenOd.Remove(pratilac);
            pratilac.Prati.Remove(praceni);

            s.Save(praceni);
            s.Save(pratilac);

            s.Flush();

            return true;
        }

        public static KorisnikKreiranjeDto DodajStudenta(KorisnikKreiranjeDto kkdto)
        {
            ISession s = SesijeProvajder.Sesija;

            string sifra = Guid.NewGuid().ToString().Substring(0, 8);
            Korisnik k = new Korisnik()
            {
                Ime = kkdto.Ime,
                Prezime = kkdto.Prezime,
                Sifra = sifra,
                DatumRegistracije = DateTime.Now,
                DatumRodjenja = kkdto.DatumRodjenja,
                DatumVaziDo = DateTime.Now.AddYears(1),
                StudiraFakultet = ProvajderPodatakaFakulteta.VratiFakultet(kkdto.IdFakulteta.Value), //uvek ima value jer kreiramo studenta
                BrojIndeksa = kkdto.BrojIndeksa,
                AktivanNalog = false,
                Obrisan = false,
                BrojTelefona = kkdto.BrojTelefona,
                TipNaloga = ProvajderPodatakaTipovaNaloga.VratiTipNaloga(kkdto.IdTipaNaloga)
            };
           
            s.Save(k);
            s.Flush();

            List<Korisnik> lista = s.Query<Korisnik>()
                .Select(x => x)
                .ToList();

            Korisnik kreirani =  lista.Find(x => x.BrojIndeksa == kkdto.BrojIndeksa 
                && x.StudiraFakultet.IdFakultet == kkdto.IdFakulteta
                && x.Sifra == sifra);

            Objava o = new Objava()
            {
                Lokacija = ProvajderPodatakaMenzi.VratiMenzu(4),
                IdKorisnik = kreirani
            };

            s.Save(o);
            s.Flush();

            kkdto.IdKorisnika = kreirani.IdKorisnika;
            kkdto.Sifra = sifra;
            kkdto.DatumRegistracije = kreirani.DatumRegistracije;
            kkdto.DatumVaziDo = kreirani.DatumVaziDo;
            kkdto.AktivanNalog = kreirani.AktivanNalog;

            return kkdto;
        }

        public static KorisnikKreiranjeDto DodajNalog(KorisnikKreiranjeDto kkdto)
        {
            ISession s = SesijeProvajder.Sesija;

            Korisnik k = new Korisnik()
            {
                KorisnickoIme = kkdto.KorisnickoIme,
                Email = kkdto.Email,
                BrojTelefona = kkdto.BrojTelefona,
                Ime = kkdto.Ime,
                Prezime = kkdto.Prezime,
                Sifra = kkdto.Sifra,
                DatumRegistracije = DateTime.Now,
                DatumRodjenja = kkdto.DatumRodjenja,
                AktivanNalog = true,
                Obrisan = false,
                TipNaloga = ProvajderPodatakaTipovaNaloga.VratiTipNaloga(kkdto.IdTipaNaloga)
            };

            s.Save(k);
            s.Flush();

            List<Korisnik> lista = s.Query<Korisnik>()
                .Select(x => x)
                .ToList();

            Korisnik kreirani = lista.Find(x => x.KorisnickoIme == kkdto.KorisnickoIme);

            kkdto.IdKorisnika = kreirani.IdKorisnika;
            kkdto.Sifra = kreirani.Sifra;
            kkdto.DatumRegistracije = kreirani.DatumRegistracije;
            kkdto.AktivanNalog = kreirani.AktivanNalog;

            return kkdto;
        }

        public static KorisnikKreiranjeDto DodajMenadzera(KorisnikKreiranjeDto kkdto)
        {
            return DodajNalog(kkdto);
        }

        public static KorisnikKreiranjeDto DodajUplatu(KorisnikKreiranjeDto kkdto)
        {
            return DodajNalog(kkdto);
        }

        public static KorisnikKreiranjeDto DodajNaplatu(KorisnikKreiranjeDto kkdto)
        {
            return DodajNalog(kkdto);
        }

        public static KorisnikKreiranjeDto DodajAdministratora(KorisnikKreiranjeDto kkdto)
        {
            return DodajNalog(kkdto);
        }

        public static bool OdjaviSe(string sesija)
        {
            ISession s = SesijeProvajder.Sesija;
            List<LoginSesija> sesije = s.Query<LoginSesija>().Select(k => k).ToList();

            LoginSesija login = sesije.Find(x => x.IdSesije == sesija);
            if (login == null)
                return false;

            s.Delete(login);
            s.Flush();

            return true;
        }

        public static KorisnikKreiranjeDto Azuriraj(KorisnikKreiranjeDto kkdto)
        {
            ISession s = SesijeProvajder.Sesija;
            Korisnik korisnik = s.Get<Korisnik>(kkdto.IdKorisnika);

            if (korisnik == null)
                return null;

            korisnik.KorisnickoIme = kkdto.KorisnickoIme;
            korisnik.Ime = kkdto.Ime;
            korisnik.Prezime = kkdto.Prezime;
            if(kkdto.Sifra != null)
                korisnik.Sifra = kkdto.Sifra;
            korisnik.BrojTelefona = kkdto.BrojTelefona;
            korisnik.DatumRodjenja = kkdto.DatumRodjenja;
            korisnik.Email = kkdto.Email;
            korisnik.TipNaloga = ProvajderPodatakaTipovaNaloga.VratiTipNaloga(kkdto.IdTipaNaloga);
            korisnik.AktivanNalog = kkdto.AktivanNalog;

            s.Save(korisnik);
            s.Flush();

            return kkdto;
        }

        public static KorisnikKreiranjeDto AzurirajStudenta(KorisnikKreiranjeDto kkdto)
        {
            KorisnikKreiranjeDto k = Azuriraj(kkdto);
            if (k == null)
                return null;

            ISession s = SesijeProvajder.Sesija;
            Korisnik korisnik = s.Get<Korisnik>(kkdto.IdKorisnika); // Azuriraj(kkdto) proslo, korisnik psotoji i aktivan je

            korisnik.BrojIndeksa = kkdto.BrojIndeksa;
            korisnik.DatumVaziDo = kkdto.DatumVaziDo;
            korisnik.StudiraFakultet = ProvajderPodatakaFakulteta.VratiFakultet(kkdto.IdFakulteta.Value);

            s.Save(korisnik);
            s.Flush();

            return kkdto;
        }

        public static KorisnikKreiranjeDto AzurirajNaplatu(KorisnikKreiranjeDto kkdto)
        {
            return Azuriraj(kkdto);
        }

        public static KorisnikKreiranjeDto AzurirajUplatu(KorisnikKreiranjeDto kkdto)
        {
            return Azuriraj(kkdto);
        }

        public static KorisnikKreiranjeDto AzurirajAdministratora(KorisnikKreiranjeDto kkdto)
        {
            return Azuriraj(kkdto);
        }

        public static KorisnikKreiranjeDto AzurirajMenadzera(KorisnikKreiranjeDto kkdto)
        {
            return Azuriraj(kkdto);
        }
        
        public static int KorisnikIDizSesijaID(string sid)
        {
            ISession s = SesijeProvajder.Sesija;

            List<LoginSesija> lista = s.Query<LoginSesija>().Select(k => k).ToList();

            LoginSesija ses = lista.Find(x => x.IdSesije == sid);

            if (ses == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                { Content = new StringContent("Nevalidna sesija") });

            return ses.KorisnikSesije.IdKorisnika;
        }

        public static bool ObrisiIzBaze(int id)
        {
            Korisnik obrisani = Obrisi(id);

            if (obrisani == null)
                return false; // Korisnik ne postoji, nemoguce brisanje iz baze

            ISession s = SesijeProvajder.Sesija;
            try { 
            s.Delete(obrisani);
            s.Flush();
            } 
            catch(Exception e) { }
            return true;
        }

        public static Korisnik Obrisi(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            Korisnik k = VratiKorisnika(id);

            if (k == null)
                return null; // Korisnik ne postoji, nemoguce setovanje flegova 

            k.Obrisan = true;
            k.AktivanNalog = false;

            s.Save(k);
            s.Flush(); // ne moze da pukne ako je korisnik null

            Korisnik rezultat = s.Get<Korisnik>(id);

            return rezultat;
        }

        public static KorisnikFullDto KorisnikToFullDto(Korisnik k)
        {
            KorisnikFullDto korisnik = new KorisnikFullDto();
            korisnik.KorisnickoIme = k.KorisnickoIme;
            korisnik.Email = k.Email;
            korisnik.Ime = k.Ime;
            korisnik.Prezime = k.Prezime;
            korisnik.DatumRodjenja = k.DatumRodjenja;
            korisnik.DatumRegistracije = k.DatumRegistracije;
            korisnik.BrojTelefona = k.BrojTelefona;
            if (k.BrojIndeksa != null)
                korisnik.BrojIndeksa = k.BrojIndeksa;
            if (k.DatumVaziDo != null)
                korisnik.DatumVaziDo = k.DatumVaziDo;
            korisnik.AktivanNalog = k.AktivanNalog;
            korisnik.IdTipaNaloga = k.TipNaloga.IdTip;
            if (k.StudiraFakultet != null)
                korisnik.IdFakulteta = k.StudiraFakultet.IdFakultet;
            if (k.Objava != null)
                korisnik.IdObjave = k.Objava.IdObjave;
            if (k.IdKorisnika != 0)
                korisnik.IdKorisnika = k.IdKorisnika;
            return korisnik;

        }

        public static KorisnikStanjeDto PredlogUplate(int idKorisnika)
        {
            ISession s = SesijeProvajder.Sesija;
            KorisnikStanjeDto predlog = new KorisnikStanjeDto();

            Korisnik kor = ProvajderPodatakaKorisnika.VratiKorisnika(idKorisnika);

            predlog.BrojDorucka = (kor.Obroci.Count(k => k.Tip.IdTipObroka == 1 && k.DatumUplacivanja.Month <= DateTime.Now.Month && k.DatumUplacivanja.Month >= DateTime.Now.AddMonths(-3).Month) / 3);
            predlog.BrojRuckova = (kor.Obroci.Count(k => k.Tip.IdTipObroka == 2 && k.DatumUplacivanja.Month <= DateTime.Now.Month && k.DatumUplacivanja.Month >= DateTime.Now.AddMonths(-3).Month) / 3);
            predlog.BrojVecera = (kor.Obroci.Count(k => k.Tip.IdTipObroka == 3 && k.DatumUplacivanja.Month <= DateTime.Now.Month && k.DatumUplacivanja.Month >= DateTime.Now.AddMonths(-3).Month) / 3);

            if (predlog != null)
                return predlog;
            return null;

        }

        public static bool PrvaPrijava(int id, string sifra)
        {
            ISession s = SesijeProvajder.VratiSesiju();
            Korisnik k = s.Get<Korisnik>(id);

            
            if (k == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Student ne postoji") });

            if (k.TipNaloga.IdTip != 5)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Greska: Nalog nije studentski") });

            return sifra == k.Sifra;
        }

        public static bool RegistracijaNaAndroid(ClientZaRegistracijuDto czrdto)
        {
            ISession s = SesijeProvajder.Sesija;

            Korisnik k = s.Load<Korisnik>(czrdto.DodeljeniId);

            if (k.KorisnickoIme != null)
                return false;

            if (k.Email != null)
                return false;

            if (k == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Student ne postoji") });

            if(czrdto.Email == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent(" Morate uneti email") });

            if (czrdto.KorisnickoIme == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent(" Morate uneti korisničko ime") });

            if (czrdto.Telefon == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent(" Morate uneti broj telefona") });

            if (czrdto.NovaLozinka == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent(" Morate uneti novu sifru") });

            List<Korisnik> korisnici = s.Query<Korisnik>().Select(x => x).ToList();

            Korisnik isto_korisnicko = korisnici.Find(x => x.KorisnickoIme == czrdto.KorisnickoIme);

            if(isto_korisnicko != null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Korisnicko ime vec postoji") }); 

            Korisnik isti_mail = korisnici.Find(x => x.Email == czrdto.Email);

            if (isti_mail != null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Email već u upotrebi") });

            EmailAddressAttribute mail_validator = new EmailAddressAttribute();

            if (!mail_validator.IsValid(k.Email))
                return false;

            k.Email = czrdto.Email;
            k.KorisnickoIme = czrdto.KorisnickoIme;
            k.BrojTelefona = czrdto.Telefon;
            k.Sifra = czrdto.NovaLozinka;

            s.Save(k);
            s.Flush();

            VerifikacijaNaloga(czrdto.Email, czrdto.DodeljeniId);

            return true;
        }
        
        public static PozivanjaFullDto NoviPoziv(PozivanjaFullDto pfdto, string sid)
        {
            ISession s = SesijeProvajder.Sesija;

            Korisnik pozivalac = VratiKorisnika(KorisnikIDizSesijaID(sid));

            if (pozivalac == null)
                return null;

            if (pozivalac.TipNaloga.IdTip != 5)
                return null;

            if (pfdto.DatumPoziva == DateTime.MinValue)
                return null;

            if (pfdto.VaziDo == DateTime.MinValue)
                return null;

            Pozivanje poziv = new Pozivanje()
            {
                DatumPoziva = pfdto.DatumPoziva,
                VaziDo = pfdto.VaziDo,
                Pozivaoc = pozivalac
            };

            pozivalac.Pozivi.Add(poziv);

            s.Save(poziv);
            s.Save(pozivalac);
           

            s.Flush();

            List<Pozivanje> p = s.Query<Pozivanje>().Select(x => x).ToList();

            if (p.Count == 0)
                return null;

            Pozivanje po = p.Find(x => x.Pozivaoc.IdKorisnika == pozivalac.IdKorisnika && x.DatumPoziva == poziv.DatumPoziva);

            if (po == null)
                return null;

            pfdto.IdPoziva = po.IdPoziva;
            pfdto.IdPozivaoca = po.Pozivaoc.IdKorisnika;

            return pfdto;
        }

        public static bool AktivirajNalog(int id)
        {
            ISession s = SesijeProvajder.Sesija;

            Korisnik korisnik = s.Load<Korisnik>(id);
            korisnik.AktivanNalog = true;
            s.Save(korisnik);
            s.Flush();

            return true;
        }

        public static bool VerifikacijaNaloga(string email, int id)
        {
            EmailAddressAttribute mail_validator = new EmailAddressAttribute();

            if (!mail_validator.IsValid(email))
                return false;

            SmtpMail oMail = new SmtpMail("TryIt");
            SmtpClient oSmtp = new SmtpClient();

            // Ko salje mail
            oMail.From = server_mail; 

            // Primalac
            oMail.To = email;

            string link = Guid.NewGuid().ToString();

            oMail.HtmlBody = String.Format("Poštovani, " +
                "dobro došli na <span style=\"color:green\">Mensarium</span> sistem!" +
                "Molimo Vas da aktivirate nalog pritiskom na link: <br> {0}",
                "<a href=\"" + 
                verifikacioni_link + id +"\">"
                + link + "</a>");

            oMail.Subject = "Verifikacija naloga";

            SmtpServer oServer = new SmtpServer(""); 

            try
            {
                oSmtp.SendMail(oServer, oMail);
                return true;
            }
            catch (Exception e)
            {
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError)
                { Content = new StringContent("InternalError: " + e.Message) });
            }
        }

        public static bool DodajUPoziv(int idPoziva, int idPozvanog)
        {
            ISession s = SesijeProvajder.Sesija;

            Pozivanje p = s.Load<Pozivanje>(idPoziva);

            Korisnik pozvani = p.Pozivaoc.Prati.ToList().Find(x => x.IdKorisnika == idPozvanog);

            if (pozvani == null)
                return false; // nemoguce pozvati nekog koga ne pratimo
           
            PozivanjaPozvani pp = new PozivanjaPozvani()
            {

                IdPozivanjaPozvani =
                {
                    IdPoziva = p,
                    IdPozvanog = pozvani
                },
                OdgovorPozvanog = false
           };

           pozvani.PozivanjaOd.Add(pp);
           p.Pozvani.Add(pp);

           s.Save(p);
           s.Save(pp);
           s.Flush();

           return true;
        }

        //Korisnici koje admin sme da vidi - svi sem obrisanih
        public static List<KorisnikFullDto> VratiKorisnikeAdmin()
        {
            ISession s = SesijeProvajder.Sesija;
            List<Korisnik> korisnici = s.Query<Korisnik>().Select(x => x).ToList();
            korisnici.RemoveAll(x => x.Obrisan);

            List<KorisnikFullDto> rezultat = new List<KorisnikFullDto>();

            foreach (var VARIABLE in korisnici)
            {
                KorisnikFullDto k = KorisnikToFullDto(VARIABLE);
                rezultat.Add(k);
            }
            return rezultat;
        }

        //Korisnici koje student sme da vidi - aktivni studenti
        public static List<KorisnikFullDto> VratiKorisnikeStudent()
        {
            List<KorisnikFullDto> rezultat = VratiKorisnikeOstali();
            rezultat.RemoveAll(x => !x.AktivanNalog);
            return rezultat;
        }

        //Korisnici koje menadzer, naplata i uplata smeju da vide - aktivni i neaktivni studenti
        public static List<KorisnikFullDto> VratiKorisnikeOstali()
        {
            List<KorisnikFullDto> rezultat = VratiKorisnikeAdmin();
            rezultat.RemoveAll(x => x.IdTipaNaloga != 5);
            return rezultat;
        }
        
        public static List<OgovorNaPozivDto> ObavestiOOdgovorima(int idPoziva, string sid)
        {
            ISession s = SesijeProvajder.Sesija;
            Pozivanje p = s.Get<Pozivanje>(idPoziva);

            if (p.VaziDo < DateTime.Now)
                return null;

            List<PozivanjaPozvani> pp = s.Query<PozivanjaPozvani>().Select(x => x).ToList();
            List<PozivanjaPozvani> poziv = pp.FindAll(x => x.IdPozivanjaPozvani.IdPoziva.IdPoziva == idPoziva);

            if (poziv.Count == 0)
                return null;

            List<OgovorNaPozivDto> rezultat = new List<OgovorNaPozivDto>();

            foreach (var v in poziv)
            {
                OgovorNaPozivDto o = new OgovorNaPozivDto()
                {
                    OdgovorPozvanog = v.OdgovorPozvanog.Value,
                    IdPozvanog = v.IdPozivanjaPozvani.IdPozvanog.IdKorisnika,
                    Ime = v.IdPozivanjaPozvani.IdPozvanog.Ime,
                    Prezime = v.IdPozivanjaPozvani.IdPozvanog.Prezime,
                    KorisnickoIme = v.IdPozivanjaPozvani.IdPozvanog.KorisnickoIme,
                    IdPoziva = v.IdPozivanjaPozvani.IdPoziva.IdPoziva
                };
                rezultat.Add(o);
            }
            rezultat.Sort((x, y) => y.OdgovorPozvanog.CompareTo(x.OdgovorPozvanog));

            return rezultat;
        }

        public static PozivanjaFullDto Poziv(int idPoziva, string sid)
        {
            ISession s = SesijeProvajder.Sesija;
            Pozivanje p = s.Get<Pozivanje>(idPoziva);

            if (p.VaziDo < DateTime.Now)
                return null;

            PozivanjaFullDto rezultat = new PozivanjaFullDto()
            {
                IdPoziva = p.IdPoziva,
                DatumPoziva = p.DatumPoziva,
                VaziDo = p.VaziDo,
                IdPozivaoca = p.Pozivaoc.IdKorisnika
            };

            foreach (var v in p.Pozvani.ToList())
            {
                rezultat.Pozvani.Add(v.IdPozivanjaPozvani.IdPozvanog.IdKorisnika);
            }

            return rezultat;
        }

        public static bool SesijaValidna(string sid)
        {
            ISession s = SesijeProvajder.Sesija;
            List<LoginSesija> lista = s.Query<LoginSesija>().Select(x => x).ToList();

            LoginSesija se = lista.First(x => x.IdSesije == sid);

            return se != null;
        }

        public static PozivanjaFullDto PoslednjiPoziv(string sid)
        {
            ISession s = SesijeProvajder.Sesija;

            Korisnik k = VratiKorisnika(KorisnikIDizSesijaID(sid));

            if (k == null)
                return null;

            if (k.TipNaloga.IdTip != 5)
                return null;

            List<Pozivanje> lista = k.Pozivi.ToList();

            PozivanjaFullDto p = new PozivanjaFullDto();

            if (lista.Count == 0)
            {
                p.IdPoziva = -1;
                p.DatumPoziva = DateTime.MinValue;
                p.VaziDo = DateTime.MinValue;
            }
            else
            {
                lista.Sort((x, y) => x.DatumPoziva.CompareTo(y.DatumPoziva));
                p.IdPoziva = lista[lista.Count - 1].IdPoziva;
                p.DatumPoziva = lista[lista.Count - 1].DatumPoziva;
                p.VaziDo = lista[lista.Count - 1].VaziDo;
            }

            foreach (var v in lista[lista.Count - 1].Pozvani.ToList())
            {
                p.Pozvani.Add(v.IdPozivanjaPozvani.IdPozvanog.IdKorisnika);
            }

            return p;
        }

        public static bool PosaljiObroke(int idPrimaoca, KorisnikStanjeDto kdsto, string sid)
        {
            ISession s = SesijeProvajder.Sesija;
            Korisnik salje = VratiKorisnika(KorisnikIDizSesijaID(sid));

            if (salje == null)
                return false;

            if (salje.TipNaloga.IdTip != 5)
                return false;

            Korisnik primalac = VratiKorisnika(idPrimaoca);

            if (primalac == null)
                return false;

            if (primalac.TipNaloga.IdTip != 5)
                return false;

            List<Obrok> obroci = s.Query<Obrok>().Select(x => x).ToList();
            List<Obrok> dorucak = obroci.FindAll(x => x.Uplatilac.IdKorisnika == salje.IdKorisnika &&
                                                      x.Tip.IdTipObroka == 1);
            if (dorucak.Count < kdsto.BrojDorucka)
                return false;

            List<Obrok> rucak = obroci.FindAll(x => x.Uplatilac.IdKorisnika == salje.IdKorisnika &&
                                                      x.Tip.IdTipObroka == 2);
            if (rucak.Count < kdsto.BrojRuckova)
                return false;

            List<Obrok> vecera = obroci.FindAll(x => x.Uplatilac.IdKorisnika == salje.IdKorisnika &&
                                                      x.Tip.IdTipObroka == 3);
            if (vecera.Count < kdsto.BrojVecera)
                return false;

            for (int i = 0; i < kdsto.BrojDorucka; i++)
            {
                dorucak[i].Uplatilac = primalac;
                s.Save(dorucak[i]);
            }

            for (int i = 0; i < kdsto.BrojRuckova; i++)
            {
                rucak[i].Uplatilac = primalac;
                s.Save(rucak[i]);
            }

            for (int i = 0; i < kdsto.BrojVecera; i++)
            {
                vecera[i].Uplatilac = primalac;
                s.Save(vecera[i]);
            }

            s.Flush();

            return true;
        }

        //Promena email-a
        public static bool PromeniEmail(string noviMail, string sid)
        {
            EmailAddressAttribute mail_validator = new EmailAddressAttribute();

            if (!mail_validator.IsValid(noviMail))
                return false;

            Korisnik k = VratiKorisnika(KorisnikIDizSesijaID(sid));

            if (k == null)
                return false;

            Dictionary<int, string> mail = new Dictionary<int, string>();
            mail.Add(k.IdKorisnika, noviMail);
            string pin = Guid.NewGuid().ToString();

            promenaMaila.Add(pin,mail);

            SmtpMail oMail = new SmtpMail("TryIt");
            SmtpClient oSmtp = new SmtpClient();

            // Ko salje mail
            oMail.From = server_mail;

            // Primalac
            oMail.To = noviMail;

            string link = Guid.NewGuid().ToString();

            oMail.HtmlBody = String.Format("Poštovani, " +
                                           "molimo Vas kliknite na link kako biste resetovali email adresu" +
                                           " na <span style=\"color:green\">Mensarium</span> sistemu:" +
                                           "<br> {0}",
                "<a href=\"" +
                promena_emaila_link + 
                "?pin=" +
                pin + 
                "&id=" +
                k.IdKorisnika +
                "\">"
                + link + "</a>");

            oMail.Subject = "Promena email-a";

            SmtpServer oServer = new SmtpServer("");

            try
            {
                oSmtp.SendMail(oServer, oMail);
                return true;
            }
            catch (Exception e)
            {
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError)
                    { Content = new StringContent("InternalError: " + e.Message) });
            }
        }

        public static bool ResetujEmail(string pin, int id)
        {
            ISession s = SesijeProvajder.Sesija;

            Dictionary<int,string> id_noviMail = promenaMaila[pin];

            Korisnik k = VratiKorisnika(id);

            if (k == null)
                return false;

            k.Sifra = id_noviMail[id];

            s.Save(k);
            s.Flush();

            return false;
        }

        public static bool AndroidUpdate(StudentAzuriranjeDto sadto, string sid)
        {
            ISession s = SesijeProvajder.Sesija;

            Korisnik k = VratiKorisnika(KorisnikIDizSesijaID(sid));

            if (k == null)
                return false;

            if (k.TipNaloga.IdTip != 5)
                return false;

            if (k.Sifra != sadto.StaraSifra)
                return false;

            if (sadto.Mail != null)
                k.Email = sadto.Mail;

            if (sadto.NovaSifra != null)
                k.Sifra = sadto.NovaSifra;

            if (sadto.Telefon != null)
                k.BrojTelefona = sadto.Telefon;

            s.Save(k);
            s.Flush();

            return true;
        }

        public static bool SifraRecoverySend(string korisnickoIme)
        {
            ISession s = SesijeProvajder.Sesija;

            List<Korisnik> ko = s.Query<Korisnik>().Select(x => x).ToList();

            Korisnik k = ko.First(x => x.KorisnickoIme == korisnickoIme);

            if (k == null)
                return false;

            string privremenaSifra = Guid.NewGuid().ToString().Substring(0, 5);
                
            passRecovery.Add(k.KorisnickoIme, privremenaSifra);

            SmtpMail oMail = new SmtpMail("TryIt");
            SmtpClient oSmtp = new SmtpClient();

            // Ko salje mail
            oMail.From = server_mail;

            // Primalac
            oMail.To = k.Email;

            oMail.HtmlBody = String.Format("Poštovani, " +
                                           "Vaša privremena šifra je" +
                                           "<br> {0}", privremenaSifra);

            oMail.Subject = "Resetovanje šifre";

            SmtpServer oServer = new SmtpServer("");

            try
            {
                oSmtp.SendMail(oServer, oMail);
                return true;
            }
            catch (Exception e)
            {
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError)
                    { Content = new StringContent("InternalError: " + e.Message) });
            }
        }

        public static bool SifraRecoveryConfirm(PassRecoveryDto prdto)
        {
            ISession s = SesijeProvajder.Sesija;

            string pin = passRecovery[prdto.KorisnickoIme];

            if (pin != prdto.Pin)
                return false;

            List<Korisnik> ko = s.Query<Korisnik>().Select(x => x).ToList();
            Korisnik k = ko.First(x => x.KorisnickoIme == prdto.KorisnickoIme);
            k.Sifra = prdto.NovaSifra;

            s.Save(k);
            s.Flush();

            return true;
        }
    }
}