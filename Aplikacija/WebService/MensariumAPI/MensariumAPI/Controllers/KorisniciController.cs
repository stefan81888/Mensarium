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
        //Vraća korisnika po id-ju
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("full/{id:int}")]
        public IHttpActionResult VratiKorisnikaFull(int id)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                Korisnik k = ProvajderPodatakaKorisnika.VratiKorisnika(id);

                KorisnikFullDto korisnik = new KorisnikFullDto();
                if (ValidatorKorisnika.KorisnikPostoji(k))
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
            return Content(HttpStatusCode.BadRequest, new KorisnikFullDto());
        }

        //Vraća sve korisnike
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("")]
        public IHttpActionResult VratiSveKorisnikeFull()
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                IEnumerable<Korisnik> ienKorisnici = ProvajderPodatakaKorisnika.VratiKorisnike();
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
            return Content(HttpStatusCode.BadRequest, new List<KorisnikFullDto>());
        }

        //Korisnik pratilac počinje da prati korisnika praceni
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("zaprati/{pratilac:int}/{praceni:int}")]
        public IHttpActionResult Zaprati(int pratilac, int praceni)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                bool status = ProvajderPodatakaKorisnika.Zaprati(pratilac, praceni);
                
                SesijeProvajder.ZatvoriSesiju();
                if(status)
                    return Content(HttpStatusCode.Found, new KorisnikFollowDto());
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new KorisnikFullDto());
        }

        //Dodavanje korisnika
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

                ProvajderPodatakaKorisnika.DodajKorisnika(k);
                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.Found, kdto);
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new KorisnikFullDto());

        }

        //Ažuriranje korisnika
        [System.Web.Http.HttpPut]
        [System.Web.Http.Route("update")]
        public IHttpActionResult UpdateKorisnika([FromBody]ClientZaRegistracijuDto klijentReg)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                Korisnik k = ProvajderPodatakaKorisnika.VratiKorisnika(klijentReg.DodeljeniId);
                if (ValidatorKorisnika.KorisnikPostoji(k))
                {
                    if (k.Sifra == klijentReg.DodeljenaLozinka)
                    {
                        if (!ValidatorKorisnika.PostojiUsername(klijentReg.NovaLozinka))
                        {
                            k.KorisnickoIme = klijentReg.KorisnickoIme;
                            k.Email = klijentReg.Email;
                            k.Sifra = klijentReg.NovaLozinka;
                            k.BrojTelefona = klijentReg.Telefon;
                        }
                        ProvajderPodatakaKorisnika.UpdateKorisnika(k);
                    }
                }

                SesijeProvajder.ZatvoriSesiju();
                return Content(HttpStatusCode.Found, new KorisnikFullDto());
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new KorisnikFullDto());
        }

        //Prijava na sistem
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("prijava")]
        public IHttpActionResult Prijava([FromBody]ClientLoginDto cdto)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                SesijaDto sdto = ProvajderPodatakaKorisnika.PrijavaKorisnika(cdto);

                SesijeProvajder.ZatvoriSesiju();

                if(sdto != null)
                    return Content(HttpStatusCode.Found, sdto);
            }
            catch (Exception e)
            {


            }
            return Content(HttpStatusCode.BadRequest, new KorisnikFullDto());

        }

        //Prikaz svih korisnika koje korisnik prati
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("pracenja/{id:int}")]
        public IHttpActionResult Pracenja(int id)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();
                List<KorisnikFollowDto> pracenja = ProvajderPodatakaKorisnika.SvaPracenja(id);
                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.Found, pracenja);
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new KorisnikFullDto());

        }

        //Pretraga po kriterijumu
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("pretraga/{id:int}")]
        public IHttpActionResult Pretraga(int id,[FromBody] string kriterijum)
        {
            // id korisnika koji pretrazuje
            try
            {
                SesijeProvajder.OtvoriSesiju();

                List<KorisnikFollowDto> k = ProvajderPodatakaKorisnika.Pretraga(id, kriterijum);

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.Found, k);
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new KorisnikFollowDto());

        }

        //Broj obroka korisnika
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("stanje/{id:int}")]
        public IHttpActionResult VratiKorisnikovoStanjeObroka(int id)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                Korisnik k = ProvajderPodatakaKorisnika.VratiKorisnika(id);

                KorisnikStanjeDto korisnik = new KorisnikStanjeDto();
                if (ValidatorKorisnika.KorisnikPostoji(k))
                {
                   korisnik = ProvajderPodatakaKorisnika.Stanje(k);
                }
                SesijeProvajder.ZatvoriSesiju();
                if (korisnik != null)
                    return Content(HttpStatusCode.Found, korisnik);
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest,new KorisnikFollowDto());
        }

        //Priivlegije naloga
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("privilegije/{id:int}")]
        public IHttpActionResult VratiPrivilegijeKorisnika(int id)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();
                List<Privilegija> listaPrivilegija = ProvajderPodatakaTipovaNaloga.VratiPrivilegijeKorisnika(id);
                List<PrivilegijaFullDto> listaPrivilegijaFull = new List<PrivilegijaFullDto>(listaPrivilegija.Count());

                foreach (Privilegija p in listaPrivilegija)
                {
                    listaPrivilegijaFull.Add(new PrivilegijaFullDto()
                    {
                        IdPrivilegije = p.IdPrivilegije,
                        Opis = p.Opis
                    });
                }

                SesijeProvajder.ZatvoriSesiju();

                if (listaPrivilegija != null)
                    return Content(HttpStatusCode.Found, listaPrivilegijaFull);
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, new List<PrivilegijaFullDto>());
        }

        //Pozivanje na obrok
        [System.Web.Http.HttpPut]
        [System.Web.Http.Route("pozovi")]
        public IHttpActionResult Pozovi([FromBody] PozivanjaFullDto pfdto, [FromBody] PozvaniDto listaPozvanih)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                PozivanjaFullDto o = ProvajderPodatakaKorisnika.Pozovi(pfdto, listaPozvanih);

                SesijeProvajder.ZatvoriSesiju();

                if(o != null)
                    return Content(HttpStatusCode.Found, o);

            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new List<PrivilegijaFullDto>());
        }

        //Vraca sve pozive upucene jednom korisniku
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("pozivi/{id:int}")]
        public IHttpActionResult SviPozivi(int id)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                List<PozivanjaNewsFeedItemDto> listaPoziva = ProvajderPodatakaKorisnika.SviPozivi(id);

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.Found, listaPoziva);


            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new PozivanjaNewsFeedItemDto());

        }
    }
}
