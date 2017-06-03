using System;
using System.Collections.Generic;
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

namespace MensariumAPI.Podaci.ProvajderiPodataka
{
    public class ProvajderPodatakaKorisnika
    {
        // TO DO: private delegates
        public delegate KorisnikKreiranjeDto KreiranjeKorisnika(KorisnikKreiranjeDto kkdto);
        public delegate List<KorisnikFollowDto> PretragaKorisnika(PretragaKriterijumDto pkdto);

        public List<KreiranjeKorisnika> listaDelegataKreiranja = new List<KreiranjeKorisnika>();
        public List<PretragaKorisnika> listaDelegataPretrage = new List<PretragaKorisnika>();

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
            
            LoginSesija sesija = new LoginSesija()
            {
                KorisnikSesije = ko[0],
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

            foreach (var v in lista)
            {
                if(v.IdKorisnika == pkdto.IdKorisnika)
                    break;
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
            List<Obrok> obr = ProvajderPodatakaObroka.VratiObroke().ToList();

            int doruckovi = (from o in obr
                where (o.Uplatilac.IdKorisnika == korisnik.IdKorisnika && o.Tip.IdTipObroka == 1)
                select o
            ).Count();

            int ruckovi = (from o in obr
                where (o.Uplatilac.IdKorisnika == korisnik.IdKorisnika && o.Tip.IdTipObroka == 2)
                select o
            ).Count();

            int vecere = (from o in obr
                where (o.Uplatilac.IdKorisnika == korisnik.IdKorisnika && o.Tip.IdTipObroka == 3)
                select o
            ).Count();

            KorisnikStanjeDto k = new KorisnikStanjeDto();

            k.BrojDorucka = doruckovi;
            k.BrojRuckova = ruckovi;
            k.BrojVecera = vecere;

            return k;
        }

        public static PozivanjaFullDto Pozovi(PozivanjaFullDto pfdto)
        {
            ISession s = SesijeProvajder.Sesija;
            
            Korisnik pozivalac = VratiKorisnika(pfdto.IdPozivaoca);
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

            s.Save(pozivalac);
            s.Save(poziv);

            foreach (var v in pozvani)
            {
                s.Save(v); 
            }

            s.Flush();

            List<Pozivanje> p = s.Query<Pozivanje>().Select(x => x).OrderBy(x => x.IdPoziva).ToList(); // TO DO : svuda primeniti ovo

            pfdto.IdPoziva = p[p.Count - 1].IdPoziva;

            return pfdto;  
        }

        public static List<PozivanjaNewsFeedItemDto> SviPozivi(int id)
        {
            ISession s = SesijeProvajder.Sesija;

            Korisnik pozivalac = VratiKorisnika(id);
            if (pozivalac == null)
                return null;

            List<PozivanjaNewsFeedItemDto> sviPozivi = new List<PozivanjaNewsFeedItemDto>();


            foreach (var v in pozivalac.PozivanjaOd.ToList())
            {
                int idPoziva = v.IdPozivanjaPozvani.IdPoziva.IdPoziva;
                Pozivanje p = s.Get<Pozivanje>(idPoziva);

                if (DateTime.Compare(p.DatumPoziva, DateTime.Today) < 0)
                    break;

                if(DateTime.Compare(p.DatumPoziva, p.VaziDo) > 0)
                    break;

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

            sviPozivi.Sort((x, y) => y.DatumPoziva.CompareTo(x.DatumPoziva));

            return sviPozivi;
        }

        public static PozivanjaPozvaniDto OdogovoriNaPoziv(PozivanjaPozvaniDto ppdto)
        {
            ISession s = SesijeProvajder.Sesija;

            Korisnik k = VratiKorisnika(ppdto.IdPozvanog);
            if (k == null)
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

            Korisnik praceni = VratiKorisnika(idPraceni);

            if (praceni == null)
                return false;

            if (praceni.PracenOd.Contains(pratilac))
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

            string sifra = Guid.NewGuid().ToString().Substring(0, 10);
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
                AktivanNalog = true,
                Obrisan = false,
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
            Korisnik korisnik = VratiKorisnika(kkdto.IdKorisnika);

            if (korisnik == null)
                return null;

            korisnik.KorisnickoIme = kkdto.KorisnickoIme;
            korisnik.Ime = kkdto.Ime;
            korisnik.Prezime = kkdto.Prezime;
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

            //LoginSesija ses = s.Query<LoginSesija>()
            //    .Where(x => x.IdSesije == sid)
            //    .FirstOrDefault();

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

            s.Delete(obrisani);
            s.Flush();

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
            Korisnik k = VratiKorisnika(id);

            if (k == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Student ne postoji") });

            return sifra == k.Sifra;
        }

        public static SesijaDto RegistracijaNaAndroid(ClientZaRegistracijuDto czrdto)
        {
            ISession s = SesijeProvajder.Sesija;

            Korisnik k = VratiKorisnika(czrdto.DodeljeniId);

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

            k.Email = czrdto.Email;
            k.KorisnickoIme = czrdto.KorisnickoIme;
            k.BrojTelefona = czrdto.Telefon;
            k.Sifra = czrdto.NovaLozinka;

            s.Save(k);
            s.Flush();

            Korisnik korisnik = VratiKorisnika(czrdto.DodeljeniId);

            LoginSesija sesija = new LoginSesija()
            {
                KorisnikSesije = korisnik,
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
    }
}