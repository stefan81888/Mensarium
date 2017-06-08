using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using MensariumAPI.Podaci;
using MensariumAPI.Podaci.Entiteti;
using MensariumAPI.Podaci.Konfigracija;
using NHibernate;
using MensariumAPI.Podaci.ProvajderiPodataka;
using MensariumAPI.Podaci.DTO;
using System.Web;

namespace MensariumAPI.Controllers
{
    [RoutePrefix("api/korisnici")]
    public class KorisniciController : ApiController
    {
        //Vraća korisnika po id-ju
        [HttpGet]
        public KorisnikFullDto VratiKorisnikaFull(int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if(!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid,
                    ValidatorPrivilegija.UserPrivilegies.CitanjeKorisnik))
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
                    //if (k.IdKorisnika != null)
                    if (k.IdKorisnika != 0)
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
        [HttpGet]
        public List<KorisnikFullDto> VratiSveKorisnikeFull([FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });


                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid,
                    ValidatorPrivilegija.UserPrivilegies.CitanjeKorisnik))
                    throw new HttpResponseException(
                        new HttpResponseMessage(HttpStatusCode.Forbidden)
                        {
                            Content = new StringContent("Nemate privilegiju")
                        });

                ProvajderPodatakaKorisnika ppk = new ProvajderPodatakaKorisnika();

                Korisnik k =
                    ProvajderPodatakaKorisnika.VratiKorisnika(ProvajderPodatakaKorisnika.KorisnikIDizSesijaID(sid));

                if (k == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                    { Content = new StringContent("Korisnik je neaktivan ili obrisan") });

                List<KorisnikFullDto> listaKorisnika = ppk.listaDelegataSvihKorisnika[k.TipNaloga.IdTip - 1].Invoke();

                if (listaKorisnika.Count == 0)
                {
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        {Content = new StringContent("Nema korisnika")});
                }
                return listaKorisnika;
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
        [HttpGet]
        [Route("zaprati")]
        public IHttpActionResult Zaprati([FromUri] int praceni, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });


                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.PracenjeKorisnika))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Nemate privilegiju") });

                int pratilac = ProvajderPodatakaKorisnika.KorisnikIDizSesijaID(sid);
                
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
        [HttpPost]
        [Route("dodaj")]
        public KorisnikKreiranjeDto DodajKorisnika([FromBody]KorisnikKreiranjeDto kddto, [FromUri]string sid)
        {

            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid,
                    ValidatorPrivilegija.UserPrivilegies.DodavanjeKorisnik))
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

        //Ažuriranje korisnika -> mail, sifra i/ili telefon
        [HttpPut]
        [Route("update")]
        public IHttpActionResult UpdateKorisnika([FromBody] StudentAzuriranjeDto sadto, [FromUri] string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });


                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.PracenjeKorisnika))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                        { Content = new StringContent("Nemate privilegiju") });

                bool status = ProvajderPodatakaKorisnika.AndroidUpdate(sadto, sid);

                if (status)
                    return Ok("Korisnik azuriran");

                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Korisnik nije azuriran") });
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

        //Prijava na sistem
        [HttpPost]
        [Route("prijava")]
        public SesijaDto Prijava([FromBody]ClientLoginDto cdto) 
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();
                                
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
        [HttpGet]
        [Route("pracenja")]
        public List<KorisnikFollowDto> Pracenja([FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });


                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.PracenjeKorisnika))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                        { Content = new StringContent("Nemate privilegiju") });

                List<KorisnikFollowDto> pracenja = ProvajderPodatakaKorisnika.SvaPracenja(ProvajderPodatakaKorisnika.KorisnikIDizSesijaID(sid));

                if(pracenja == null)
                   throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                   { Content = new StringContent("Nisu pronadjeni korisnici") });

                if (pracenja.Count == 0)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Korisnik nikog ne prati") });

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
        [HttpPost]
        [Route("pretraga")]
        public List<KorisnikFollowDto> Pretraga([FromBody] PretragaKriterijumDto pkdto, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeKorisnik))
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
        [HttpGet]
        [Route("stanje")]
        public KorisnikStanjeDto VratiKorisnikovoStanjeObroka([FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeObrok))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Nemate privilegiju") });

                Korisnik k = ProvajderPodatakaKorisnika.VratiKorisnika(ProvajderPodatakaKorisnika.KorisnikIDizSesijaID(sid));

                KorisnikStanjeDto korisnik = new KorisnikStanjeDto();
                if (ValidatorKorisnika.KorisnikPostoji(k))
                {
                   korisnik = ProvajderPodatakaKorisnika.Stanje(k);
                }
                else
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

        [HttpGet]
        [Route("stanje")] 
        public KorisnikStanjeDto VratiKorisnikovoStanjeObroka([FromUri] int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeObrok))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Nemate privilegiju") });

                Korisnik k = ProvajderPodatakaKorisnika.VratiKorisnika(id);

                KorisnikStanjeDto korisnik = new KorisnikStanjeDto();
                if (ValidatorKorisnika.KorisnikPostoji(k))
                {
                    korisnik = ProvajderPodatakaKorisnika.Stanje(k);
                }
               else
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
        [HttpGet]
        [Route("privilegije")]
        public List<PrivilegijaFullDto> VratiPrivilegijeKorisnika([FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.PregledPrivilegija))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Nemate privilegiju") });

                List<Privilegija> listaPrivilegija = ProvajderPodatakaTipovaNaloga.VratiPrivilegijeKorisnika(ProvajderPodatakaKorisnika.KorisnikIDizSesijaID(sid));

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
        [HttpPut]
        [Route("pozovi")]
        public PozivanjaFullDto Pozovi([FromBody] PozivanjaFullDto pfdto, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.PracenjeKorisnika))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Nemate privilegiju") });

                PozivanjaFullDto o = ProvajderPodatakaKorisnika.Pozovi(pfdto, sid);


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
        [HttpGet]
        [Route("pozivi")]
        public List<PozivanjaNewsFeedItemDto> SviPozivi([FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.PracenjeKorisnika))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Nemate privilegiju") });

                List<PozivanjaNewsFeedItemDto> listaPoziva = ProvajderPodatakaKorisnika.SviPozivi(ProvajderPodatakaKorisnika.KorisnikIDizSesijaID(sid));

                //if(listaPoziva.Count == 0)
                //    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                //    { Content = new StringContent("Nema poziva") });

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
        [HttpPut]
        [Route("odgovor/pozivi")]
        public PozivanjaPozvaniDto OdgovorNaPoziv([FromBody] PozivanjaPozvaniDto poziv, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.PracenjeKorisnika))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                        { Content = new StringContent("Nemate privilegiju") });

                PozivanjaPozvaniDto odgovor = ProvajderPodatakaKorisnika.OdogovoriNaPoziv(poziv, sid);

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
        [HttpPut]
        [Route("pracenja/prestani")]
        public IHttpActionResult PrestaniDaPratis([FromUri] int praceni, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.PracenjeKorisnika))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                        { Content = new StringContent("Nemate privilegiju") });

                bool status = ProvajderPodatakaKorisnika.PrestaniDaPratis(ProvajderPodatakaKorisnika.KorisnikIDizSesijaID(sid), praceni);

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
        [HttpPut]
        [Route("odjava")]
        public IHttpActionResult Odjava([FromUri]string sid)
        { 
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                bool uspesno = ProvajderPodatakaKorisnika.OdjaviSe(sid);

                if(uspesno)
                    return Ok("Uspena odjava");

                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Neuspesna odjava") });
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
        [HttpPut]
        [Route("azuriraj")]
        public KorisnikKreiranjeDto Azuriraj([FromBody] KorisnikKreiranjeDto kddto, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.ModifikacijaKorisnik))
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

        //Brisanje korisnika
        [HttpDelete]
        [Route("obrisi")]
        public IHttpActionResult Obrisi([FromUri] int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.BrisanjeKorisnik))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                        { Content = new StringContent("Nemate privilegiju") });

                bool uspesno = ProvajderPodatakaKorisnika.ObrisiIzBaze(id);

                if (uspesno)
                    return Ok("Uspeno brisanje iz baze");

                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Neuspesno brisanje") });
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

        //VratiKorisnicku sliku sa traznem ID-om
        [HttpGet]
        [Route("slika")]
        public HttpResponseMessage SlikaKorisnika([FromUri]int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        {Content = new StringContent("Sesija istekla")});
            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent("ServerGreska: Neuspelo pribavljanje slike")
                };
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }
            return ProvajderPodatakaSlike.VratiSliku(id);                           
        }

        //VratiKorisnicku sliku (trenutno ulogovan korisnik)
        [HttpGet]
        [Route("slika")]
        public HttpResponseMessage SlikaKorisnika([FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                return ProvajderPodatakaSlike.VratiSliku(ProvajderPodatakaKorisnika.KorisnikIDizSesijaID(sid));
            }
            catch(Exception e)
            {
                DnevnikIzuzetaka.Zabelezi(e);
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                { Content = new StringContent("ServerGreska: Neuspelo pribavljanje slike") };
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }
        }

        [HttpPut]
        [Route("postaviSliku")]
        public HttpResponseMessage PostaviSlikuKorisniku([FromUri] int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                var httpRequest = HttpContext.Current.Request;

                foreach (string file in httpRequest.Files)
                {
                    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);

                    var postedFile = httpRequest.Files[file];
                    if (postedFile != null && postedFile.ContentLength > 0)
                    {

                        int MaxContentLength = 1024 * 1024 * 1; //Size = 1 MB

                        IList<string> AllowedFileExtensions = new List<string> { ".jpg"};
                        var ext = postedFile.FileName.Substring(postedFile.FileName.LastIndexOf('.'));
                        var extension = ext.ToLower();
                        if (!AllowedFileExtensions.Contains(extension))
                        {
                            var message = string.Format("Greska: Nedozvoljen format slike.\nDozvoljeni format: .jpg");
                            return Request.CreateResponse(HttpStatusCode.BadRequest, message);
                        }
                        else if (postedFile.ContentLength > MaxContentLength)
                        {
                            var message = string.Format("Greska: Velicina slike mora biti do 1MB");
                            return Request.CreateResponse(HttpStatusCode.BadRequest, message);
                        }
                        else
                        {
                            SesijeProvajder.OtvoriSesiju();
                            string fname = ProvajderPodatakaSlike.PostaviSliku(id);
                            
                            var filePath = HttpContext.Current.Server.MapPath("~/App_Data/SlikeKorisnika/" + fname);
                            postedFile.SaveAs(filePath);
                        }
                    }
                    var message1 = string.Format("Slika uspesno postavljena");
                    return Request.CreateErrorResponse(HttpStatusCode.Created, message1); ;
                }
                var res = string.Format("Please Upload a image.");
                
                return Request.CreateResponse(HttpStatusCode.NotFound, res);
            }
            catch (Exception ex)
            {
                var res = string.Format("GreskaInterna: Postavljanje slike" + ex.Message);
                DnevnikIzuzetaka.Zabelezi(ex);
                return Request.CreateResponse(HttpStatusCode.NotFound, res);
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }


        }

        [HttpGet]
        [Route("predlogUplate")]
        public KorisnikStanjeDto PredloziKorisnikuBrojObrokaZaUplatu([FromUri]int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeObrok))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });

                Korisnik kor = ProvajderPodatakaKorisnika.VratiKorisnika(id);

                if (kor == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("Korisnik nije pronadjen") });

                KorisnikStanjeDto predlog = new KorisnikStanjeDto();

                predlog = ProvajderPodatakaKorisnika.PredlogUplate(id);
                if (predlog != null)
                    return predlog;
                else
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("Greska u racunanju predloga") });
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

        //Prva prijava
        [HttpGet]
        [Route("prvaprijava")]
        public IHttpActionResult PrvaPrijava([FromUri] int id, [FromUri] string sifra)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                bool status = ProvajderPodatakaKorisnika.PrvaPrijava(id, sifra);

                if (status)
                    return Ok("Prijava validna");

                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Neispravna sifra") });
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
        
        //Registracija na android
        [HttpPut]
        [Route("registracija/android")]
        public IHttpActionResult RegistracijaNaAndroid([FromBody] ClientZaRegistracijuDto czrdto)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                bool status = ProvajderPodatakaKorisnika.RegistracijaNaAndroid(czrdto);

                if (status)
                    return Ok("Verifikujte nalog");

                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Korisnik postoji") });
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

        //Sms uplata
        [HttpPost]
        [Route("uplata/sms")]
        public IHttpActionResult SmsUplata([FromUri] int id, [FromUri] int brojObroka, [FromUri] string tip)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                bool status = ProvajderPodatakaObroka.UplatiObrok(id, brojObroka,
                    ProvajderPodatakaObroka.SmsUplate[tip]);

                if (status)
                    return Ok("Uplata uspesna");

                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Neispravna uplata") });
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
        
        //Kreiraje poziva, ne poziva nikoga
        [HttpPost]
        [Route("pozivi/kreiraj")]
        public PozivanjaFullDto NapraviPoziv([FromBody] PozivanjaFullDto pfdto, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.PracenjeKorisnika))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                        { Content = new StringContent("Nemate privilegiju") });

                PozivanjaFullDto s = ProvajderPodatakaKorisnika.NoviPoziv(pfdto, sid);

                if (s == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Neuspesno kreiranje poziva") });
                return s;

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

        //Aktivacija naloga
        //Do ove rute se dolazi iz emaila
        [HttpGet]
        [Route("verifikacija/{id:int}")]
        public IHttpActionResult VerifikovanNalog(int id)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                bool status = ProvajderPodatakaKorisnika.AktivirajNalog(id);

                if (status)
                    return Ok("Verifikacija uspesna");

                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Neispravna verifikacija") });

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

        //Pozivanje jednog korisnika
        [HttpPut]
        [Route("pozovi/jednog")]
        public IHttpActionResult PozoviJednog([FromUri] int idPoziva, [FromUri]int idPozvanog)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                bool status = ProvajderPodatakaKorisnika.DodajUPoziv(idPoziva, idPozvanog);

                if (status)
                    return Ok("Pozivanje uspesno");

                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Pozivanje neuspesno") });

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

        //Obavesti pozivaoca o odgovorima na poziv
        [HttpGet]
        [Route("pozivi/obavesti")]
        public List<OgovorNaPozivDto> ObavestiOOdgovorima([FromUri] int idPoziva, [FromUri] string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.PracenjeKorisnika))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                        { Content = new StringContent("Nemate privilegiju") });

                List<OgovorNaPozivDto> s = ProvajderPodatakaKorisnika.ObavestiOOdgovorima(idPoziva, sid);

                if (s == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Neuspesan zahtev") });
                return s;

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

        //Poziv na osnovu id-a
        [HttpGet]
        [Route("poziv")]
        public PozivanjaFullDto Poziv([FromUri] int idPoziva, [FromUri] string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.PracenjeKorisnika))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                        { Content = new StringContent("Nemate privilegiju") });

                PozivanjaFullDto s = ProvajderPodatakaKorisnika.Poziv(idPoziva, sid);

                if (s == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Neuspesan zahtev") });
                return s;

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

        //Poslednji poziv koji je uputio korisnik
        [HttpGet]
        [Route("pozivi/poslednji")]
        public PozivanjaFullDto PoslednjiPoziv([FromUri] string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.PracenjeKorisnika))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                        { Content = new StringContent("Nemate privilegiju") });

               PozivanjaFullDto s = ProvajderPodatakaKorisnika.PoslednjiPoziv(sid);

                if (s == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Neuspesan zahtev") });
                return s;

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

        //Pozivanje jednog korisnika
        [HttpPut]
        [Route("obroci/posalji")]
        public IHttpActionResult PosaljiObroke([FromUri]int idPrimaoca, [FromBody]KorisnikStanjeDto kdsto, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();


                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.PracenjeKorisnika))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                        { Content = new StringContent("Nemate privilegiju") });

                bool status = ProvajderPodatakaKorisnika.PosaljiObroke(idPrimaoca, kdsto, sid);

                if (status)
                    return Ok("Slanje uspesno");

                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Slanje neuspesno") });

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

        //Zahtev za promenu maila
        [HttpPut]
        [Route("email/zahtev")]
        public IHttpActionResult ZahtevajPromenuEmaila([FromUri]string noviMail, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();


                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.PracenjeKorisnika))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                        { Content = new StringContent("Nemate privilegiju") });

                bool status = ProvajderPodatakaKorisnika.PromeniEmail(noviMail, sid);

                if (status)
                    return Ok("Zahtev poslat");

                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Zahtev neuspesan") });

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

        //Menja email korisniku
        //Do ove rute se dolazi iz emaila
        [HttpGet]
        [Route("mail/reset/")]
        public IHttpActionResult ResetujEmail([FromUri]string pin, [FromUri] int id)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                bool status = ProvajderPodatakaKorisnika.ResetujEmail(pin, id);

                if (status)
                    return Ok("Resetovanje uspesno");

                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Resetovanje neuspesno") });

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
        
        //Zahteva promenu sifre, pin se salje na mail
        [HttpPut]
        [Route("sifra/zahtevaj")]
        public IHttpActionResult ZahtevajPromenuSifre([FromUri]string korisnickoIme)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                bool status = ProvajderPodatakaKorisnika.SifraRecoverySend(korisnickoIme);

                if (status)
                    return Ok("Zahtev poslat");

                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Zahtev neuspesan") });

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

        //Slanje nove sifre uz pin
        [HttpPut]
        [Route("sifra/oporavi")]
        public IHttpActionResult OporavakSifre([FromBody]PassRecoveryDto prdto)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                bool status = ProvajderPodatakaKorisnika.SifraRecoveryConfirm(prdto);

                if (status)
                    return Ok("Sifra promenjena");

                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Promena sifre neuspesna") });

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
