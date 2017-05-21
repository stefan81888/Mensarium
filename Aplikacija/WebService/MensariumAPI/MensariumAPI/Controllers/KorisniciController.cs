using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using AutoMapper;
using MensariumAPI.Podaci.Entiteti;
using MensariumAPI.Podaci.Konfigracija;
using NHibernate;
using MensariumAPI.Podaci.ProvajderiPodataka;
using MensariumAPI.Podaci.DTO;
namespace MensariumAPI.Controllers
{
    [System.Web.Http.RoutePrefix("api/korisnici")]
    public class KorisniciController : ApiController
    {
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("full/{id:int}")]
        public IHttpActionResult VratiKorisnikaFull(int id)
        {
            try
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
                    if (k.IdKorisnika != null)
                        korisnik.IdKorisnika = k.IdKorisnika;
                }
                SesijeProvajder.ZatvoriSesiju();
                if(korisnik != null)
                    return Content(HttpStatusCode.Found, korisnik);
            }
            catch (Exception e)
            {
                
            }
            return Content(HttpStatusCode.BadRequest, "Korisnik nije pronadjen");
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult VratiSveKorisnikeFull()
        {
            try
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
                    if (k.IdKorisnika != null)
                        korisnik.IdKorisnika = k.IdKorisnika;


                    listaKorisnikaFull.Add(korisnik);
                }
                SesijeProvajder.ZatvoriSesiju();
                if (listaKorisnikaFull != null)
                    return Content(HttpStatusCode.Found, listaKorisnikaFull);
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, "Korisnici nije pronadjen");
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("zaprati/{pratilac:int}/{praceni:int}")]
        public IHttpActionResult Zaprati(int pratilac, int praceni)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                Korisnik k = ProvajderPodataka.VratiKorisnika(pratilac);
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
                if(korisnik != null)
                    return Content(HttpStatusCode.Found, korisnik);
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, "Akcija neuspešna");
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("dodaj")]
        public IHttpActionResult DodajKorisnika([FromBody]KorisnikFullDto kdto)
        {
            try
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

                return Content(HttpStatusCode.OK, "");
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, "");

        }

        [System.Web.Http.HttpPut]
        [System.Web.Http.Route("update")]
        public IHttpActionResult UpdateKorisnika([FromBody]ClientZaRegistracijuDto klijentReg)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                Korisnik k = ProvajderPodataka.VratiKorisnika(klijentReg.DodeljeniId);
                if (Validator.KorisnikPostoji(k))
                {
                    if (k.Sifra == klijentReg.DodeljenaLozinka)
                    {
                        if (Validator.PostojiUsername(klijentReg.NovaLozinka) == null)
                        {
                            k.KorisnickoIme = klijentReg.KorisnickoIme;
                            k.Email = klijentReg.Email;
                            k.Sifra = klijentReg.NovaLozinka;
                            k.BrojTelefona = klijentReg.Telefon;
                        }
                        ProvajderPodataka.UpdateKorisnika(k);
                    }
                }

                SesijeProvajder.ZatvoriSesiju();
                return Content(HttpStatusCode.OK, "");
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, "");
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("prijava")]
        public IHttpActionResult Prijava([FromBody]ClientLoginDto cdto)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                Korisnik k = new Korisnik()
                {
                    KorisnickoIme = cdto.KorisnickoIme,
                    Email = cdto.Email,
                    Sifra = cdto.Sifra
                };

                SesijeProvajder.ZatvoriSesiju();

                SesijaDto sdto = ProvajderPodataka.PrijavaKorisnika(k);
                if(sdto != null)
                    return Content(HttpStatusCode.Found, sdto);
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, "");

        }


    }
}
