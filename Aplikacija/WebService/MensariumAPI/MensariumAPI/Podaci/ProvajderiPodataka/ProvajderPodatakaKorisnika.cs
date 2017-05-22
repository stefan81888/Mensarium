﻿using System;
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
    }
}