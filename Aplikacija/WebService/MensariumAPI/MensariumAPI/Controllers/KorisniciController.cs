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
        public KorisnikFullDto VratiKorisnikaFull(int id)
        {
            SesijeProvajder.OtvoriSesiju();

            Korisnik k = ProvajderPodataka.VratiKorisnika(id);
            KorisnikFullDto korisnik = new KorisnikFullDto();
            if (Validator.KorisnikPostoji(k))
            {
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


       
    }
}
