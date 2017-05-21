using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.DTO;
using MensariumAPI.Podaci.Entiteti;
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
            ISession s = SesijeProvajder.Sesija;

            Korisnik pratilac = s.Load<Korisnik>(idPratioca);

            if (!ValidatorKorisnika.KorisnikPostoji(pratilac))
                return false;

            Korisnik praceni = s.Load<Korisnik>(idPracenog);

            if (ValidatorKorisnika.KorisnikPostoji(praceni))
                return false;

            praceni.PracenOd.Add(pratilac);

            s.Save(pratilac);
            s.Save(praceni);
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

            foreach (var ko in k.Prati)
            {
                KorisnikFollowDto kdto = new KorisnikFollowDto()
                {
                    IdKorisnika = k.IdKorisnika,
                    KorisnickoIme = k.KorisnickoIme,
                    Ime = k.Ime,
                    Prezime = k.Prezime,
                    Fakultet = k.StudiraFakultet.Naziv,
                    Zapracen = true
                };

            }
            return praceni;
        }

        public static List<KorisnikFollowDto> Pretraga(int id, string kriterijum)
        {
            ISession s = SesijeProvajder.Sesija;
            Korisnik pretrazuje = s.Load<Korisnik>(id);

            // prvo vracamo korisnike koje pratimo

            pretrazuje.Prati.ToList();
            
            return null;
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
    }
}