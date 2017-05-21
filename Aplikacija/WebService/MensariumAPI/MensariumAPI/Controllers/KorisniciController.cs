using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using MensariumAPI.Podaci.Entiteti;
using MensariumAPI.Podaci.Konfigracija;
using NHibernate;
using MensariumAPI.Podaci.ProvajderiPodataka;
using MensariumAPI.Podaci.DTO;
namespace MensariumAPI.Controllers
{
    [RoutePrefix("api/korisnici")]


    public class KorisniciController : ApiController
    {


        //[HttpGet]
        //public string Korisnik(int id)
        //{
            
            
        //    try
        //    {
        //        ISession ses = Podaci.ProvajderiPodataka.SesijeProvajder.VratiSesiju();
        //        string odgovor;
        //        Korisnik k = ses.Load<Korisnik>(id);
                
        //        odgovor = string.Format("ID_{0} {1} {2} {3} {4}",
        //            k.IdKorisnika,
        //            k.Ime,
        //            k.Prezime,
        //            k.KorisnickoIme,
        //            k.Email
        //        );
        //        ses.Close();
        //        return odgovor;
        //    }
        //    catch (Exception ex)
        //    {
        //        Konfiguracija.StampajIzuzetak(ex);
        //    }
        //    return null;
        //}



        [HttpGet]
        [Route("full/{id:int}")]
        public KorisnikFullDto VratiKorisnikaFull(int id)
        {
            SesijeProvajder.OtvoriSesiju();

            Korisnik k = ProvajderPodataka.VratiKorisnika(id);
            KorisnikFullDto korisnik = new KorisnikFullDto();
            if (Validator.KorisnikPostoji(k))
            {
                //TO-DO: PUCA ZA NULLABLE
                //za sve nullable podatke ispitati da li su postavljeni
                //i ako nije preskoci dodavanje u dto;
                korisnik.KorisnickoIme = k.KorisnickoIme;
                korisnik.Email = k.Email;
                korisnik.Ime = k.Ime;
                korisnik.Prezime = k.Prezime;
                korisnik.DatumRodjenja = k.DatumRodjenja;
                korisnik.DatumRegistracije = k.DatumRegistracije;
                korisnik.BrojTelefona = k.BrojTelefona;
                korisnik.BrojIndeksa = k.BrojIndeksa;
                korisnik.DatumVaziDo = k.DatumVaziDo;
                korisnik.AktivanNalog = k.AktivanNalog;
                korisnik.IdTipaNaloga = k.TipNaloga.IdTip;
                korisnik.IdFakulteta = k.StudiraFakultet.IdFakultet;
                korisnik.IdObjave = k.Objava.IdObjave;
            }
            SesijeProvajder.ZatvoriSesiju();
            return korisnik;
        }

        [HttpGet]
        public List<KorisnikFullDto> VratiSveKorisnikeFull()
        {
            SesijeProvajder.OtvoriSesiju();

            IEnumerable<Korisnik> ienKorisnici = ProvajderPodataka.VratiKorisnike();
            List<Korisnik> listaKorisnika = ienKorisnici.ToList();
            List<KorisnikFullDto> listaKorisnikaFull = new List<KorisnikFullDto>(listaKorisnika.Count);

            for (int i = 0; i < listaKorisnika.Count; ++i)
            {
                KorisnikFullDto korisnik = new KorisnikFullDto();
                Korisnik k = listaKorisnika[i];

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

                

                listaKorisnikaFull.Add(korisnik);
            }
            SesijeProvajder.ZatvoriSesiju();
            return listaKorisnikaFull;
        }

        [HttpGet]
        [Route("follow/{id:int}")]
        public KorisnikFollowDto VratiKorisnikaFollow(int id)
        {
            SesijeProvajder.OtvoriSesiju();

            Korisnik k = ProvajderPodataka.VratiKorisnika(id);
            KorisnikFollowDto korisnik = new KorisnikFollowDto();
            if (Validator.KorisnikPostoji(k))
            {
                //korisnik.IdKorisnika = k.IdKorisnika; ???
                korisnik.KorisnickoIme = k.KorisnickoIme;
                korisnik.Ime = k.Ime;
                korisnik.Prezime = k.Prezime;
                korisnik.Fakultet = k.StudiraFakultet.Naziv;
                //korisnik.Zapracen ???
            }

            SesijeProvajder.ZatvoriSesiju();
            return korisnik;
        }

        [HttpPost]
        [Route("dodaj")]
        public void DodajKorisnika([FromBody]KorisnikFullDto kdto)
        {
            SesijeProvajder.OtvoriSesiju();

            Korisnik k = new Korisnik()
            {
                KorisnickoIme = kdto.KorisnickoIme,
                Ime = kdto.Ime,
                Prezime = kdto.Prezime,
                DatumRegistracije = kdto.DatumRegistracije,
                DatumRodjenja = kdto.DatumRodjenja,
                DatumVaziDo = kdto.DatumVaziDo,
                Email = kdto.Email,
                BrojIndeksa = kdto.BrojIndeksa,
                BrojTelefona = kdto.BrojTelefona
            };

            ProvajderPodataka.DodajKorisnika(k);

            SesijeProvajder.ZatvoriSesiju();
        }

        [HttpPut]
        [Route("update")]
        public void UpdateKorisnika([FromBody]ClientZaRegistracijuDto klijentReg)
        {
            SesijeProvajder.OtvoriSesiju();

            Korisnik k = ProvajderPodataka.VratiKorisnika(klijentReg.DodeljeniId);
            if (Validator.KorisnikPostoji(k))
            {
                //if (k.Sifra == klijentReg.DodeljenaLozinka)
                //{
                //    if (!Validator.PostojiUsername(klijentReg.NovaLozinka))
                //    {
                //        k.KorisnickoIme = klijentReg.KorisnickoIme;
                //        k.Email = klijentReg.Email;
                //        k.Sifra = klijentReg.NovaLozinka;
                //        k.BrojTelefona = klijentReg.Telefon;
                //    }
                //    ProvajderPodataka.UpdateKorisnika(k);
                //}
            }

            SesijeProvajder.ZatvoriSesiju();
        }

        [HttpGet]
        [Route("prijava")]
        public SesijaDto Prijava([FromBody]ClientLoginDto cdto)
        {
            SesijeProvajder.OtvoriSesiju();

            Korisnik k = new Korisnik()
            {
                KorisnickoIme = cdto.KorisnickoIme,
                Email = cdto.Email,
                Sifra = cdto.Sifra
            };

            SesijeProvajder.ZatvoriSesiju();

            return null;
        }


    }
}
