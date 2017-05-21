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
    public class ObrociController : ApiController
    {
        [System.Web.Http.HttpGet]
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

    }
}
