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
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("full/{id:int}")]
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
            return Content(HttpStatusCode.BadRequest, "Obrok nije pronadjen.");
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult VratiSveObroke()
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                IEnumerable<Obrok> ienObroci = ProvajderPodatakaObroka.VratiObroke();
                List<Obrok> listaObroka = ienObroci.ToList();
                List<ObrokFullDto> listaObrokaFull = new List<ObrokFullDto>(listaObroka.Count);

                for (int i = 0; i < listaObroka.Count; ++i)
                {
                    ObrokFullDto obrok = new ObrokFullDto();
                    Obrok o = listaObroka[i];

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
            return Content(HttpStatusCode.BadRequest, "Obroci nisu pronadjeni.");
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("korisnicki/{id:int}")]
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
            return Content(HttpStatusCode.BadRequest, "Stanje korisnika nije pronadjeno");
        }

        [System.Web.Http.HttpPost]
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

        //[System.Web.Http.HttpPut]
        //[System.Web.Http.Route("naplati")]
        //public IHttpActionResult NaplatiObroke([FromBody]ObrokNaplataDto obNapDto)
        //{
        //    int i;
        //    try
        //    {
        //        SesijeProvajder.OtvoriSesiju();

        //        for (i = 0; i < obNapDto.BrojObroka; ++i)
        //        {
        //            Obrok obrokZaSkidanje = ProvajderPodatakaObroka.ObrokZaSkidanjeOvogTipa(obNapDto.IdKorisnika, obNapDto.IdTipa;
        //            if (obrokZaSkidanje != null)
        //            {
        //                Obrok o = ProvajderPodatakaObroka.VratiObrok(obrok)

        //                ProvajderPodatakaObroka.DodajObrok(o);
        //            }
        //            else
        //                break;
        //        }

        //        SesijeProvajder.ZatvoriSesiju();

        //        return Content(HttpStatusCode.OK, "Uspesno je dodato " + (i - 1).ToString() + " obroka.");
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    return Content(HttpStatusCode.BadRequest, "Dodavanje obroka nije uspelo.");
        //}
    }
}
