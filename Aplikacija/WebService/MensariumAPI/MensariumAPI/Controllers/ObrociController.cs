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
using MensariumAPI.Podaci;


namespace MensariumAPI.Controllers
{
    [System.Web.Http.RoutePrefix("api/obroci")]
    public class ObrociController : ApiController
    {
        [HttpGet]
        public ObrokFullDto VratiObrokFull([FromUri]int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeObrok))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });

                Obrok o = null;
                ObrokFullDto obrok = new ObrokFullDto();

                o = ProvajderPodatakaObroka.VratiObrok(id);
                if (o == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("Obrok nije pronadjen") });
                
                    obrok.IdObroka = o.IdObroka;
                    obrok.Iskoriscen = o.Iskoriscen;
                    obrok.DatumUplacivanja = o.DatumUplacivanja;
                    if (o.DatumIskoriscenja != null)
                        obrok.DatumIskoriscenja = o.DatumIskoriscenja;
                    obrok.IdUplatioca = o.Uplatilac.IdKorisnika;
                    obrok.IdTipaObroka = o.Tip.IdTipObroka;
                    obrok.IdLokacijeUplate = o.LokacijaUplate.IdMenza;
                    if (o.LokacijaIskoriscenja != null)
                        obrok.IdLokacijeIskoriscenja = o.LokacijaIskoriscenja.IdMenza;
                

                SesijeProvajder.ZatvoriSesiju();

                return obrok;
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
        public List<ObrokFullDto> VratiSveObroke([FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeObrok))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });
                

                List<Obrok> listaObroka = ProvajderPodatakaObroka.VratiObroke();
                List<ObrokFullDto> listaObrokaFull = new List<ObrokFullDto>(listaObroka.Count);

                if (listaObroka.Count == 0)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("Obroci nisu pronadjeni") });


                foreach(Obrok o in listaObroka)
                {
                    ObrokFullDto obrok = new ObrokFullDto();

                    obrok.IdObroka = o.IdObroka;
                    obrok.Iskoriscen = o.Iskoriscen;
                    obrok.DatumUplacivanja = o.DatumUplacivanja;
                    if (o.DatumIskoriscenja != null)
                        obrok.DatumIskoriscenja = o.DatumIskoriscenja;
                    obrok.IdUplatioca = o.Uplatilac.IdKorisnika;
                    obrok.IdTipaObroka = o.Tip.IdTipObroka;
                    obrok.IdLokacijeUplate = o.LokacijaUplate.IdMenza;
                    if (o.LokacijaIskoriscenja != null)
                        obrok.IdLokacijeIskoriscenja = o.LokacijaIskoriscenja.IdMenza;

                    listaObrokaFull.Add(obrok);
                }
                return listaObrokaFull;
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

        [HttpPost]
        [System.Web.Http.Route("uplati")]
        public IHttpActionResult UplatiObroke([FromBody]ObrokUplataDto obUpDto, [FromUri]string sid)
        {
            int i;
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.DodavanjeObrok))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });
                

                for (i = 0; i < obUpDto.BrojObroka; ++i)
                {
                    if (!ProvajderPodatakaObroka.KorisnikDostigaoLimitZaOvajMesecZaOvajObrok(obUpDto.IdKorisnika, obUpDto.IdTipa))
                    {
                        Obrok o = new Obrok
                        {
                            Iskoriscen = false,
                            DatumUplacivanja = DateTime.Now,
                            DatumIskoriscenja = null,
                            Uplatilac = ProvajderPodatakaKorisnika.VratiKorisnika(obUpDto.IdKorisnika),
                            Tip = ProvajderPodatakaTipovaObroka.VratiTipObroka(obUpDto.IdTipa),
                            LokacijaUplate = ProvajderPodatakaMenzi.VratiMenzu(obUpDto.IdLokacijeUplate),
                            LokacijaIskoriscenja = null
                        };

                        ProvajderPodatakaObroka.DodajObrok(o);
                    }
                    else
                        break;
                    
                }
                if (i == 0)
                    return Ok("Ne moze se uopste uplatiti, dostignut je limit.");
                else
                    return Ok("Uspesno je dodato " + i + " obroka.");
                
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

        [HttpPut]
        [Route("naplati")]
        public IHttpActionResult NaplatiObroke([FromBody]ObrokNaplataDto obNapDto, [FromUri]string sid)
        {
            int i = 1;
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.ModifikacijaObrok))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });
                
                /*for (i = 0; i < obNapDto.BrojObroka; ++i)
                {
                    Obrok obrokZaSkidanje = ProvajderPodatakaObroka.ObrokZaSkidanjeOvogTipa(obNapDto.IdKorisnika, obNapDto.IdTipa);
                    if (obrokZaSkidanje != null)
                        ProvajderPodatakaObroka.PojediObrok(obrokZaSkidanje.IdObroka, obNapDto.IdLokacijeIskoriscenja);
                    else
                        break;
                }
                */
                while (i <= obNapDto.BrojObroka )
                {
                    Obrok obrokZaSkidanje = ProvajderPodatakaObroka.ObrokZaSkidanjeOvogTipa(obNapDto.IdKorisnika, obNapDto.IdTipa);
                    if (obrokZaSkidanje != null)
                    {
                        ProvajderPodatakaObroka.PojediObrok(obrokZaSkidanje.IdObroka, obNapDto.IdLokacijeIskoriscenja);
                        ++i;
                    }
                    else break;
                    
                }

                if (i == 1)
                    return Ok("Ne moze se skunuti, nema obroka");
                else
                    return Ok("Uspesno je skunuto " + (i - 1).ToString() + " obroka.");
             
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
        [Route("danasUplaceni")]
        public List<ObrokDanasUplacenDto> DanasUplaceniObrociKorisnika([FromUri]int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeObrok))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });


                List<Obrok> danasUplaceniObrociOvogKorisnika = ProvajderPodatakaObroka.DanasUplaceniNeiskorisceniObrociKorisnika(id);
                List<ObrokDanasUplacenDto> listaDanasUplacenihObroka = new List<ObrokDanasUplacenDto>(danasUplaceniObrociOvogKorisnika.Count);

                //if (danasUplaceniObrociOvogKorisnika.Count == 0)
                //    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("Obroci nisu pronadjeni") });


                foreach (Obrok o in danasUplaceniObrociOvogKorisnika)
                {
                    listaDanasUplacenihObroka.Add(new ObrokDanasUplacenDto()
                    {
                        DatumUplacivanja = o.DatumUplacivanja,
                        IdLokacijeUplate = o.LokacijaUplate.IdMenza,
                        IdObroka = o.IdObroka,
                        IdTipaObroka = o.Tip.IdTipObroka
                    });
                }

                return listaDanasUplacenihObroka;
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
        [Route("danasSkinuti")]
        public List<ObrokDanasSkinutDto> DanasSkinutiObrociKorisnika([FromUri]int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeObrok))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });


                List<Obrok> danasSkinutiObrociOvogKorisnika = ProvajderPodatakaObroka.DanasSkinutiObrociKorisnika(id);
                List<ObrokDanasSkinutDto> listaDanasSkinutihObroka = new List<ObrokDanasSkinutDto>(danasSkinutiObrociOvogKorisnika.Count);

                //if (danasSkinutiObrociOvogKorisnika.Count == 0)
                //    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("Obroci nisu pronadjeni") });


                foreach (Obrok o in danasSkinutiObrociOvogKorisnika)
                {
                    listaDanasSkinutihObroka.Add(new ObrokDanasSkinutDto()
                    {
                        DatumIskoriscenja = (DateTime) o.DatumIskoriscenja,
                        IdLokacijeIskoriscenja = o.LokacijaIskoriscenja.IdMenza,
                        IdObroka = o.IdObroka,
                        IdTipaObroka = o.Tip.IdTipObroka
                    });
                }
                return listaDanasSkinutihObroka;
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

        [System.Web.Http.HttpPut]
        [Route("vratiPogresnoSkinute")]
        public IHttpActionResult VratiPogresnoSkinuteObroke([FromUri]int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.ModifikacijaObrok))
                   throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });
                
                
                    Obrok o = ProvajderPodatakaObroka.VratiObrok(id);
                    if (o != null && ProvajderPodatakaObroka.DanasSkinutiObrociKorisnika(o.Uplatilac.IdKorisnika).Contains(o))
                    {
                        o.DatumIskoriscenja = null;
                        o.Iskoriscen = false;
                        o.LokacijaIskoriscenja = null;

                        ProvajderPodatakaObroka.UpdateObrok(o);
                    }
                
                return Ok("Korekcija uspesno obavljena.");
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

        [HttpPut]
        [Route("skiniPogresnoUplacene")]
        public IHttpActionResult SkiniPogresnoUplaceneObroke([FromUri]int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.BrisanjeObrok))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });

                
                
                    Obrok o = ProvajderPodatakaObroka.VratiObrok(id);
                    if (o != null && ProvajderPodatakaObroka.DanasUplaceniNeiskorisceniObrociKorisnika(o.Uplatilac.IdKorisnika).Contains(o))
                        ProvajderPodatakaObroka.ObrisiObrok(id);
                
                return Ok("Korekcija uspesno obavljena.");
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
        [Route("cena")]
        public KorisnikStanjeDto VratiCenuObroka([FromUri]string sid)
        {
            
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeObrok))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });

                //za demo
                return new KorisnikStanjeDto() { BrojDorucka = 40, BrojRuckova = 72, BrojVecera = 59 };

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
