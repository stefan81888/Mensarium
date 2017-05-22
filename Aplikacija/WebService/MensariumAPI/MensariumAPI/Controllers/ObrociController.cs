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
    [System.Web.Http.RoutePrefix("api/obroci")]
    public class ObrociController : ApiController
    {
        [HttpGet]
        [Route("full/{id:int}")]
        public IHttpActionResult VratiObrokFull(int id)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                Obrok o = ProvajderPodatakaObroka.VratiObrok(id);
                ObrokFullDto obrok = new ObrokFullDto();
                if (ValidatorObroka.ObrokPostoji(o))
                {
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
                }

                SesijeProvajder.ZatvoriSesiju();

                if (obrok != null)
                    return Content(HttpStatusCode.Found, obrok);
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, new ObrokFullDto());
        }

        [HttpGet]
        public IHttpActionResult VratiSveObroke()
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                List<Obrok> listaObroka = ProvajderPodatakaObroka.VratiObroke();
                List<ObrokFullDto> listaObrokaFull = new List<ObrokFullDto>(listaObroka.Count);

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
                SesijeProvajder.ZatvoriSesiju();

                if (listaObrokaFull != null)
                    return Content(HttpStatusCode.Found, listaObrokaFull);
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, new List<ObrokFullDto>());
        }

        [HttpGet]
        [Route("korisnicki/{id:int}")]
        public IHttpActionResult VratiKorisnikovoStanjeObroka(int id)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                Korisnik k = ProvajderPodatakaKorisnika.VratiKorisnika(id);

                KorisnikStanjeDto korisnik = new KorisnikStanjeDto();
                if (ValidatorKorisnika.KorisnikPostoji(k))
                {
                    ISession s = SesijeProvajder.Sesija;
                    List<Obrok> obr = ProvajderPodatakaObroka.VratiObroke().ToList(); 

                    int doruckovi = (from o in obr
                                               where (o.Uplatilac.IdKorisnika == id && o.Tip.IdTipObroka == 1 )
                                               select o
                                               ).Count();

                    int ruckovi = (from o in obr
                                   where (o.Uplatilac.IdKorisnika == id && o.Tip.IdTipObroka == 2)
                                   select o
                                               ).Count();

                    int vecere = (from o in obr
                                   where (o.Uplatilac.IdKorisnika == id && o.Tip.IdTipObroka == 3)
                                   select o
                                               ).Count();

                    korisnik.BrojDorucka = doruckovi;
                    korisnik.BrojRuckova = ruckovi;
                    korisnik.BrojVecera = vecere;
                }
                SesijeProvajder.ZatvoriSesiju();
                if (korisnik != null)
                    return Content(HttpStatusCode.Found, korisnik);
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, new KorisnikStanjeDto());
        }

        [HttpPost]
        [System.Web.Http.Route("uplati")]
        public IHttpActionResult UplatiObroke([FromBody]ObrokUplataDto obUpDto)
        {
            int i;
            try
            {
                SesijeProvajder.OtvoriSesiju();

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

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.OK, "Uspesno je dodato " + (i - 1).ToString() + " obroka.");
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, "Dodavanje obroka nije uspelo.");
        }

        [HttpPut]
        [Route("naplati")]
        public IHttpActionResult NaplatiObroke([FromBody]ObrokNaplataDto obNapDto)
        {
            int i;
            try
            {
                SesijeProvajder.OtvoriSesiju();

                for (i = 0; i < obNapDto.BrojObroka; ++i)
                {
                    Obrok obrokZaSkidanje = ProvajderPodatakaObroka.ObrokZaSkidanjeOvogTipa(obNapDto.IdKorisnika, obNapDto.IdTipa);
                    if (obrokZaSkidanje != null)
                        ProvajderPodatakaObroka.PojediObrok(obrokZaSkidanje.IdObroka, obNapDto.IdLokacijeIskoriscenja);
                    else
                        break;
                }

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.OK, "Uspesno je skunuto " + (i - 1).ToString() + " obroka.");
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, "Skidanje obroka nije uspelo.");
        }

        [HttpGet]
        [Route("danasUplaceni/{id:int}")]
        public IHttpActionResult DanasUplaceniObrociKorisnika(int id)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                List<Obrok> danasUplaceniObrociOvogKorisnika = ProvajderPodatakaObroka.DanasUplaceniNeiskorisceniObrociKorisnika(id).ToList();
                List<ObrokDanasUplacenDto> listaDanasUplacenihObroka = new List<ObrokDanasUplacenDto>(danasUplaceniObrociOvogKorisnika.Count);

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

                SesijeProvajder.ZatvoriSesiju();

                if (listaDanasUplacenihObroka != null)
                    return Content(HttpStatusCode.Found, listaDanasUplacenihObroka);
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, new List<ObrokDanasUplacenDto>());
        }

        [HttpGet]
        [Route("danasSkinuti/{id:int}")]
        public IHttpActionResult DanasSkinutiObrociKorisnika(int id)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                List<Obrok> danasSkinutiObrociOvogKorisnika = ProvajderPodatakaObroka.DanasSkinutiObrociKorisnika(id).ToList();
                List<ObrokDanasSkinutDto> listaDanasSkinutihObroka = new List<ObrokDanasSkinutDto>(danasSkinutiObrociOvogKorisnika.Count);

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

                SesijeProvajder.ZatvoriSesiju();

                if (listaDanasSkinutihObroka != null)
                    return Content(HttpStatusCode.Found, listaDanasSkinutihObroka);
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, new List<ObrokDanasSkinutDto>());
        }

        [HttpPut]
        [Route("vratiPogresnoSkinute")]
        public IHttpActionResult VratiPogresnoSkinuteObroke([FromBody]int[] niz)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                for (int i = 0; i < niz.Count(); ++i)
                {
                    Obrok o = ProvajderPodatakaObroka.VratiObrok(niz[i]);
                    o.DatumIskoriscenja = null;
                    o.Iskoriscen = false;
                    o.LokacijaIskoriscenja = null;

                    ProvajderPodatakaObroka.UpdateObrok(o);
                }

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.OK, "Uspesno vraceni izabrani obroci.");
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, "Izabrani obroci nisu vraceni.");
        }

        [HttpPut]
        [Route("skiniPogresnoUplacene")]
        public IHttpActionResult SkiniPogresnoUplaceneObroke([FromBody]int[] niz)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                for (int i = 0; i < niz.Count(); ++i)
                    ProvajderPodatakaObroka.ObrisiObrok(niz[i]);

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.OK, "Uspesno vraceni izabrani obroci.");
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, "Izabrani obroci nisu vraceni.");
        }
    }
}
