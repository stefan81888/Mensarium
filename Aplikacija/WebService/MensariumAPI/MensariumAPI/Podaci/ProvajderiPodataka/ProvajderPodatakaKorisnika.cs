using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.DTO;
using MensariumAPI.Podaci.Entiteti;
using Microsoft.Ajax.Utilities;
using NHibernate;
using NHibernate.Linq;

namespace MensariumAPI.Podaci.ProvajderiPodataka
{
    public class ProvajderPodatakaKorisnika
    {
        public static Korisnik VratiKorisnika(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            Korisnik k = s.Load<Korisnik>(id);
            return k;
        }

        public static List<Korisnik> VratiKorisnike()
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<Korisnik> korisnici = s.Query<Korisnik>().Select(k => k);
            return korisnici.ToList();
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
                where k.KorisnickoIme == cdto.KIme_Mail || k.Email == cdto.KIme_Mail
                select k).ToList();

            if (ko.Count != 1)
                return null;

            if (ko[0].Sifra != cdto.Sifra)
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
            //Onemoguciti u mobilnoj aplikaciji pracenje vec pracenih

            ISession s = SesijeProvajder.Sesija;

            Korisnik pratilac = s.Load<Korisnik>(idPratioca);

            if (!ValidatorKorisnika.KorisnikPostoji(pratilac))
                return false;

            Korisnik praceni = s.Load<Korisnik>(idPracenog);

            if (!ValidatorKorisnika.KorisnikPostoji(praceni))
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
            ISession s = SesijeProvajder.Sesija;

            Korisnik k = s.Load<Korisnik>(id);

            if (!ValidatorKorisnika.KorisnikPostoji(k))
                return null;

            List<KorisnikFollowDto> praceni = new List<KorisnikFollowDto>();

            List<Korisnik> lista = k.Prati.ToList();

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

        public static List<KorisnikFollowDto> Pretraga(int id, string kriterijum)
        {
            ISession s = SesijeProvajder.Sesija;

            Korisnik pretrazuje = s.Load<Korisnik>(id);
            List<KorisnikFollowDto> rezultat = new List<KorisnikFollowDto>();
            List<Korisnik> korisnici = s.Query<Korisnik>().Select(k => k).ToList();
            
            List<Korisnik> lista =  (from k in korisnici
                where k.Ime.StartsWith(kriterijum) || k.Prezime.StartsWith(kriterijum)
                || k.KorisnickoIme.StartsWith(kriterijum) || k.Email.StartsWith(kriterijum)
                select k).OrderBy(x => x.Prati).ToList();

            foreach (var v in lista)
            {
                KorisnikFollowDto kdto = new KorisnikFollowDto()
                {
                    KorisnickoIme = v.KorisnickoIme,
                    Ime = v.Ime,
                    Prezime = v.Prezime,
                    IdKorisnika = v.IdKorisnika,
                    Fakultet = v.StudiraFakultet.Naziv,
                    Zapracen = false
                };
                if (pretrazuje.PracenOd.ToList().Contains(v))
                    kdto.Zapracen = true;
                rezultat.Add(kdto);
            }
            rezultat.OrderBy(x => x.Zapracen);
            return rezultat;
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

        public static PozivanjaFullDto Pozovi(PozivanjaFullDto pfdto, PozvaniDto listaPozvanih)
        {
            ISession s = SesijeProvajder.Sesija;
            
            Korisnik pozivalac = s.Load<Korisnik>(pfdto.IdPozivaoca);
            List<Korisnik> pozvani = new List<Korisnik>();
            Pozivanje poziv = new Pozivanje()
            {
                DatumPoziva = pfdto.DatumPoziva,
                VaziDo = pfdto.VaziDo,
                Pozivaoc = pozivalac
            };

            for (int i = 0; i < listaPozvanih.Pozvani.Count; i++)
            {
                Korisnik k = s.Load<Korisnik>(i);
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

            return pfdto;  // proveriti da li treba id
        }

        public static List<PozivanjaNewsFeedItemDto> SviPozivi(int id)
        {
            ISession s = SesijeProvajder.Sesija;

            Korisnik pozivalac = s.Load<Korisnik>(id);
            List<PozivanjaNewsFeedItemDto> sviPozivi = new List<PozivanjaNewsFeedItemDto>();


            foreach (var v in pozivalac.PozivanjaOd)
            {
                int idPoziva = v.IdPozivanjaPozvani.IdPoziva.IdPoziva;
                Pozivanje p = s.Load<Pozivanje>(idPoziva);

                if (DateTime.Compare(p.DatumPoziva, DateTime.Today) < 0)
                    break;

                if(DateTime.Compare(p.DatumPoziva, p.VaziDo) > 0)
                    break;

                Korisnik k = s.Load<Korisnik>(p.Pozivaoc.IdKorisnika);

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


            //TO DO:
            // Testirati da li lepo brejkuje
            // Vratiti i odgovor 
            return sviPozivi;
        }

        public static PozivanjaPozvaniDto OdogovoriNaPoziv(PozivanjaPozvaniDto ppdto)
        {
            ISession s = SesijeProvajder.Sesija;
            Korisnik k = s.Load<Korisnik>(ppdto.IdPozvanog);
            Pozivanje p = s.Load<Pozivanje>(ppdto.IdPoziva);

            PozivanjaPozvani pp = new PozivanjaPozvani()
            {
                IdPozivanjaPozvani =
                {
                    IdPoziva = p,
                    IdPozvanog = k
                },
                OdgovorPozvanog = ppdto.OdgovorPozvanog
            };

            s.Save(pp);
            s.Flush();

            return ppdto;
        }
    }
}