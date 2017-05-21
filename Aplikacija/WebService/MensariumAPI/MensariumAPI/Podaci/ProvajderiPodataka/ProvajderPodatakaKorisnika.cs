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
            s.Close();
            return k;
        }

        public static List<Korisnik> VratiKorisnike()
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<Korisnik> korisnici = s.Query<Korisnik>().Select(k => k);
            s.Close();
            return korisnici.ToList();
        }

        public static void DodajKorisnika(Korisnik k)
        {
            ISession s = SesijeProvajder.Sesija;
            s.Save(k);
            s.Flush();
            s.Close();
        }

        public static void UpdateKorisnika(Korisnik k)
        {
            ISession s = SesijeProvajder.Sesija;
            s.Update(k);
            s.Flush();
            s.Close();
        }

        public static SesijaDto PrijavaKorisnika(Korisnik k)
        {
            LoginSesija sesija = ValidatorKorisnika.ProveriSifru(k);
            return new SesijaDto()
            {
                IdSesije = sesija.IdSesije,
                IdKorisnika = sesija.KorisnikSesije.IdKorisnika,
                DatumPrijavljivanja = sesija.DatumPrijavljivanja,
                ValidnaDo = sesija.ValidnaDo
            };
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

            s.Close();

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
            s.Close();
            return praceni;
        }
    }
}