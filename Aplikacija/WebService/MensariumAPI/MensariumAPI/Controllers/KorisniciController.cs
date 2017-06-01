﻿using System;
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
                        {Content = new StringContent("Korisnik nije pronadjen")});


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
                        {Content = new StringContent("Nema korisnika")});
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
        //[System.Web.Http.Route("zaprati/{pratilac:int}/{praceni:int}")]
        public IHttpActionResult Zaprati(int pratilac, int praceni, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Nemate privilegiju") });

                bool status = ProvajderPodatakaKorisnika.Zaprati(pratilac, praceni);
              
                if(status)
                    return Ok("Korisnik zapracen");

                throw  new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                { Content = new StringContent("Korisnik nije zapracen") });
            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("InternalError: " + e.Message) });
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }
        }

        //Kreiranje naloga
        [System.Web.Http.HttpPost]
       // [System.Web.Http.Route("dodaj")]
        public KorisnikKreiranjeDto DodajKorisnika([FromBody]KorisnikKreiranjeDto kddto, [FromUri]string sid)
        {

            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid,
                    ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                        {Content = new StringContent("Nemate privilegiju")});

                ProvajderPodatakaKorisnika p = new ProvajderPodatakaKorisnika();
                KorisnikKreiranjeDto kreirani = p.listaDelegataKreiranja[kddto.IdTipaNaloga - 1].Invoke(kddto);

                if (kreirani == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        {Content = new StringContent("Korisnik nije dodat")});


                return kreirani;
            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError)
                { Content = new StringContent("InternalError: " + e.Message) });
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }

        }

        //Ažuriranje korisnika -> registracija na android aplikaciju
        [System.Web.Http.HttpPut]
       // [System.Web.Http.Route("update")]
        public IHttpActionResult UpdateKorisnika([FromBody]ClientZaRegistracijuDto klijentReg, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid,
                    ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                        {Content = new StringContent("Nemate privilegiju")});

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
                return Ok("Korisnik je registrovan na aplikaciju");
            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError)
                { Content = new StringContent("InternalError: " + e.Message) });
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }
        }

        //Prijava na sistem
        [System.Web.Http.HttpPost]
        //[System.Web.Http.Route("prijava")]
        public SesijaDto Prijava([FromBody]ClientLoginDto cdto, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Nemate privilegiju") });

                SesijaDto sdto = ProvajderPodatakaKorisnika.PrijavaKorisnika(cdto);

                if(sdto == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                    { Content = new StringContent("Prijava neuspesna") });

                return sdto;
            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError)
                { Content = new StringContent("InternalError: " + e.Message) });
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }

        }

        //Prikaz svih korisnika koje korisnik prati
        [System.Web.Http.HttpGet]
        // [System.Web.Http.Route("pracenja/{id:int}")]
        public List<KorisnikFollowDto> Pracenja(int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                List<KorisnikFollowDto> pracenja = ProvajderPodatakaKorisnika.SvaPracenja(id);

               if(pracenja.Count == 0)
                   throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                   { Content = new StringContent("Nisu pronadjeni korisnici") });

                return pracenja;
            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError)
                { Content = new StringContent("InternalError: " + e.Message) });
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }
        }

        //Pretraga po kriterijumu
        [System.Web.Http.HttpPost]
    //    [System.Web.Http.Route("pretraga")]
        public List<KorisnikFollowDto> Pretraga([FromBody] PretragaKriterijumDto pkdto, [FromUri]string sid)
        {
            // id korisnika koji pretrazuje
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Nemate privilegiju") });

                ProvajderPodatakaKorisnika p = new ProvajderPodatakaKorisnika();

                int idTipaNaloga = ProvajderPodatakaKorisnika.VratiKorisnika(pkdto.IdKorisnika).TipNaloga.IdTip; 
                List<KorisnikFollowDto> k = p.listaDelegataPretrage[idTipaNaloga - 1].Invoke(pkdto);

                if(k.Count == 0)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                    { Content = new StringContent("Nema rezultata") });

                return k;
            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("InternalError: " + e.Message) });
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }

        }

        //Broj obroka korisnika
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("stanje")]
        public KorisnikStanjeDto VratiKorisnikovoStanjeObroka([FromUri] int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Nemate privilegiju") });

                Korisnik k = ProvajderPodatakaKorisnika.VratiKorisnika(id);

                KorisnikStanjeDto korisnik = new KorisnikStanjeDto();
                if (ValidatorKorisnika.KorisnikPostoji(k))
                {
                   korisnik = ProvajderPodatakaKorisnika.Stanje(k);
                }
                if (korisnik == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                    { Content = new StringContent("Korisnik nije pronadjen") });

                return korisnik;
            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("InternalError: " + e.Message) });
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }
        }

        //Priivlegije naloga
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("privilegije")]
        public List<PrivilegijaFullDto> VratiPrivilegijeKorisnika(int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Nemate privilegiju") });

                List<Privilegija> listaPrivilegija = ProvajderPodatakaTipovaNaloga.VratiPrivilegijeKorisnika(id);

                if (listaPrivilegija.Count == 0)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                    { Content = new StringContent("Korisnik nije") });

                List<PrivilegijaFullDto> listaPrivilegijaFull = new List<PrivilegijaFullDto>(listaPrivilegija.Count);

                foreach (Privilegija p in listaPrivilegija)
                {
                    listaPrivilegijaFull.Add(new PrivilegijaFullDto()
                    {
                        IdPrivilegije = p.IdPrivilegije,
                        Opis = p.Opis
                    });
                }

                if (listaPrivilegija.Count != 0)
                    return listaPrivilegijaFull;

                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Nema korisnika") });
            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("InternalError: " + e.Message) });
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }
        }

        //Pozivanje na obrok
        [System.Web.Http.HttpPut]
      //  [System.Web.Http.Route("pozovi")]
        public PozivanjaFullDto Pozovi([FromBody] PozivanjaFullDto pfdto, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Nemate privilegiju") });

                PozivanjaFullDto o = ProvajderPodatakaKorisnika.Pozovi(pfdto);


                if(o == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                    { Content = new StringContent("Poziv nije poslat") });

                return o;

            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("InternalError: " + e.Message) });
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }
        }

        //Vraca sve pozive upucene jednom korisniku
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("pozivi")]
        public List<PozivanjaNewsFeedItemDto> SviPozivi(int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Nemate privilegiju") });

                List<PozivanjaNewsFeedItemDto> listaPoziva = ProvajderPodatakaKorisnika.SviPozivi(id);

                if(listaPoziva.Count == 0)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                    { Content = new StringContent("Nema poziva") });

                return listaPoziva;
            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("InternalError: " + e.Message) });
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }
        }
        
        //Odgovor na poziv za obrok
        [System.Web.Http.HttpPut]
      //  [System.Web.Http.Route("odgovor/pozivi")]
        public PozivanjaPozvaniDto OdgovorNaPoziv([FromBody] PozivanjaPozvaniDto poziv, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                        { Content = new StringContent("Nemate privilegiju") });

                PozivanjaPozvaniDto odgovor = ProvajderPodatakaKorisnika.OdogovoriNaPoziv(poziv);

                if(odgovor == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                    { Content = new StringContent("Odgovor nije poslat") });

                return odgovor;

            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("InternalError: " + e.Message) });
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }

        }
        
        //Korisnik pratilac prestaje da prati korisnika praceni
        [System.Web.Http.HttpPut]
       // [System.Web.Http.Route("pracenja/prestani/{pratilac:int}/{praceni:int}")]
        public IHttpActionResult PrestaniDaPratis(int pratilac, int praceni, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                        { Content = new StringContent("Nemate privilegiju") });

                bool status = ProvajderPodatakaKorisnika.PrestaniDaPratis(pratilac, praceni);

                if (status)
                    return Ok("Korisnik prestao sa pracenjem");

               throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                                              { Content = new StringContent("Neuspesno") });
            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("InternalError: " + e.Message) });
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }

        }

        //Odjava korisnika
        [System.Web.Http.HttpPut]
        //[System.Web.Http.Route("odjava")]
        public IHttpActionResult Odjava([FromUri]string sid)
        { 
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Nemate privilegiju") });

                bool uspesno = ProvajderPodatakaKorisnika.OdjaviSe(sid);

                if(uspesno)
                    return Ok("Uspena odjava");

                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Nemate privilegiju") });
            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("InternalError: " + e.Message) });
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }

        }

        //Azuriranje naloga bilo korisnika
        [System.Web.Http.HttpPut]
    //    [System.Web.Http.Route("azuriraj")]
        public KorisnikKreiranjeDto Azuriraj([FromBody] KorisnikKreiranjeDto kddto, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Nemate privilegiju") });

                ProvajderPodatakaKorisnika p = new ProvajderPodatakaKorisnika();
                KorisnikKreiranjeDto kreirani = p.listaDelegataKreiranja[kddto.IdTipaNaloga + 4].Invoke(kddto);

               if(kreirani == null)
                   throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                   { Content = new StringContent("Korisnik azuriran") });
                return kreirani;

            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("InternalError: " + e.Message) });
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }
        }

    }
}
