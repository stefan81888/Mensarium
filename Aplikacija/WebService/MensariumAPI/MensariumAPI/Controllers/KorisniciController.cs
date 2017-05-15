using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using MensariumAPI.Podaci.DTO;
using MensariumAPI.Podaci.Entiteti;
using MensariumAPI.Podaci.Konfigracija;
using NHibernate;
using MensariumAPI.Podaci.ProvajderiPodataka;

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
        public KorisnikDto VratiKorisnika(int id)
        {
            SesijeProvajder.OtvoriSesiju();

            Korisnik k = ProvajderPodataka.VratiKorisnika(id);
            KorisnikDto korisnik = new KorisnikDto();
            if (Validator.KorisnikPostoji(k))
            {
                korisnik.Ime = k.Ime;
                korisnik.Prezime = k.Prezime;
                korisnik.BrojTelefona = k.BrojTelefona;
                korisnik.BrojIndeksa = k.BrojIndeksa;
                korisnik.Email = k.Email;
                korisnik.DatumRodjenja = k.DatumRodjenja;
            }

            SesijeProvajder.ZatvoriSesiju();
            return korisnik;
        }
       
    }
}
