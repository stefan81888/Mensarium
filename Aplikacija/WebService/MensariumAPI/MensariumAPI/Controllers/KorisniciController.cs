using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using AutoMapper;
using MensariumAPI.Podaci;
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
        //[System.Web.Http.Route("full/{id:int}")]
        public KorisnikFullDto VratiKorisnikaFull(int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid,
                    ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
                    throw new HttpResponseException(
                        new HttpResponseMessage(HttpStatusCode.Forbidden)
                        {
                            Content = new StringContent("Nemate privilegiju")
                        });

                Korisnik k = ProvajderPodatakaKorisnika.VratiKorisnika(id);

                if (k == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        {Content = new StringContent("Fakultet nije pronadjen")});


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
                return korisnik;
            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(
                    new HttpResponseMessage(HttpStatusCode.InternalServerError)
                    {
                        Content = new StringContent("InternalError: " + e.Message)
                    });
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }
        }

        //Vraća sve korisnike
        [System.Web.Http.HttpGet]
        //[System.Web.Http.Route("")]
        public List<KorisnikFullDto> VratiSveKorisnikeFull([FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid,
                    ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
                    throw new HttpResponseException(
                        new HttpResponseMessage(HttpStatusCode.Forbidden)
                        {
                            Content = new StringContent("Nemate privilegiju")
                        });

                List<Korisnik> listaKorisnika = ProvajderPodatakaKorisnika.VratiKorisnike().ToList();

                if (listaKorisnika.Count == 0)
                {
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        {Content = new StringContent("Fakultet nije pronadjen")});
                }

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
                return listaKorisnikaFull;
            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(
                    new HttpResponseMessage(HttpStatusCode.InternalServerError)
                    {
                        Content = new StringContent("InternalError: " + e.Message)
                    });
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }
        }

        //Korisnik pratilac počinje da prati korisnika praceni
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("zaprati/{pratilac:int}/{praceni:int}")]
        public IHttpActionResult Zaprati(int pratilac, int praceni, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                bool status = ProvajderPodatakaKorisnika.Zaprati(pratilac, praceni);
                
                SesijeProvajder.ZatvoriSesiju();
                if(status)
                    return Content(HttpStatusCode.OK, new KorisnikFollowDto());
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new KorisnikFullDto());
        }

        //Kreiranje naloga
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("dodaj")]
        public IHttpActionResult DodajKorisnika([FromBody]KorisnikKreiranjeDto kddto, [FromUri]string sid)
        {
          
            try
            {
                SesijeProvajder.OtvoriSesiju();

                ProvajderPodatakaKorisnika p = new ProvajderPodatakaKorisnika();
                KorisnikKreiranjeDto kreirani = p.listaDelegataKreiranja[kddto.IdTipaNaloga - 1].Invoke(kddto);

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.Created, kreirani);
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new KorisnikKreiranjeDto());

        }

        //Ažuriranje korisnika -> registracija na android aplikaciju
        [System.Web.Http.HttpPut]
        [System.Web.Http.Route("update")]
        public IHttpActionResult UpdateKorisnika([FromBody]ClientZaRegistracijuDto klijentReg, [FromUri]string sid)
        {
            // kreirati objavu u delu update studenta
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
                return Content(HttpStatusCode.OK, new KorisnikFullDto());
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
                    return Content(HttpStatusCode.OK, sdto);
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new KorisnikFullDto());

        }

        //Prikaz svih korisnika koje korisnik prati
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("pracenja/{id:int}")]
        public IHttpActionResult Pracenja(int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();
                List<KorisnikFollowDto> pracenja = ProvajderPodatakaKorisnika.SvaPracenja(id);
                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.OK, pracenja);
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new KorisnikFullDto());

        }

        //Pretraga po kriterijumu
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("pretraga")]
        public IHttpActionResult Pretraga([FromBody] PretragaKriterijumDto pkdto, [FromUri]string sid)
        {
            // id korisnika koji pretrazuje
            try
            {
                SesijeProvajder.OtvoriSesiju();

                ProvajderPodatakaKorisnika p = new ProvajderPodatakaKorisnika();

                int idTipaNaloga = ProvajderPodatakaKorisnika.VratiKorisnika(pkdto.IdKorisnika).TipNaloga.IdTip; 
                List<KorisnikFollowDto> k = p.listaDelegataPretrage[idTipaNaloga - 1].Invoke(pkdto);

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.OK, k);
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new KorisnikFollowDto());

        }

        //Broj obroka korisnika
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("stanje/{id:int}")]
        public IHttpActionResult VratiKorisnikovoStanjeObroka(int id, [FromUri]string sid)
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
                    return Content(HttpStatusCode.OK, korisnik);
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest,new KorisnikFollowDto());
        }

        //Priivlegije naloga
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("privilegije/{id:int}")]
        public IHttpActionResult VratiPrivilegijeKorisnika(int id, [FromUri]string sid)
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
                    return Content(HttpStatusCode.OK, listaPrivilegijaFull);
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new List<PrivilegijaFullDto>());
        }

        //Pozivanje na obrok
        [System.Web.Http.HttpPut]
        [System.Web.Http.Route("pozovi")]
        public IHttpActionResult Pozovi([FromBody] PozivanjaFullDto pfdto, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                PozivanjaFullDto o = ProvajderPodatakaKorisnika.Pozovi(pfdto);

                SesijeProvajder.ZatvoriSesiju();

                if(o != null)
                    return Content(HttpStatusCode.OK, o);

            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new List<PrivilegijaFullDto>());
        }

        //Vraca sve pozive upucene jednom korisniku
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("pozivi/{id:int}")]
        public IHttpActionResult SviPozivi(int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                List<PozivanjaNewsFeedItemDto> listaPoziva = ProvajderPodatakaKorisnika.SviPozivi(id);

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.OK, listaPoziva);
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new PozivanjaNewsFeedItemDto());
        }

        [System.Web.Http.HttpPut]
        [System.Web.Http.Route("odgovor/pozivi")]
        public IHttpActionResult OdgovorNaPoziv([FromBody] PozivanjaPozvaniDto poziv, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                PozivanjaPozvaniDto odgovor = ProvajderPodatakaKorisnika.OdogovoriNaPoziv(poziv);

                SesijeProvajder.ZatvoriSesiju();

                if(odgovor != null)
                    return Content(HttpStatusCode.OK, odgovor);

            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new PozivanjaPozvaniDto());

        }

        //Korisnik pratilac prestaje da prati korisnika praceni
        [System.Web.Http.HttpPut]
        [System.Web.Http.Route("pracenja/prestani/{pratilac:int}/{praceni:int}")]
        public IHttpActionResult PrestaniDaPratis(int pratilac, int praceni, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                bool status = ProvajderPodatakaKorisnika.PrestaniDaPratis(pratilac, praceni);

                SesijeProvajder.ZatvoriSesiju();
                if (status)
                    return Content(HttpStatusCode.OK, new KorisnikFollowDto());
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new KorisnikFullDto());

        }

        //Odjava korisnika
        [System.Web.Http.HttpPut]
        [System.Web.Http.Route("odjava")]
        public IHttpActionResult Odjava([FromUri]string sid)
        { 
            try
            {
                SesijeProvajder.OtvoriSesiju();
                bool uspesno = ProvajderPodatakaKorisnika.OdjaviSe(sid);

                return Ok("Uspena odjava");
            }
            catch (Exception e)
            {
            }

            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }

            return Ok("PRPRAVVI OOVVOVKVJ");

        }

        //Azuriranje naloga bilo korisnika
        [System.Web.Http.HttpPut]
        [System.Web.Http.Route("azuriraj")]
        public IHttpActionResult Azuriraj([FromBody] KorisnikKreiranjeDto kddto, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                ProvajderPodatakaKorisnika p = new ProvajderPodatakaKorisnika();
                KorisnikKreiranjeDto kreirani = p.listaDelegataKreiranja[kddto.IdTipaNaloga + 4].Invoke(kddto);

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.Created, kreirani);

            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new KorisnikFullDto());
        }

    }
}
