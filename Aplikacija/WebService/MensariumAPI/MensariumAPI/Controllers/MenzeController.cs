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
    public class MenzeController : ApiController
    {
        [System.Web.Http.HttpGet]
        public IHttpActionResult VratiMenzuFull(int id)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                Menza m = ProvajderPodatakaMenzi.VratiMenzu(id);
                MenzaFullDto menza = new MenzaFullDto();
                if (ValidatorMenze.MenzaPostoji(m))
                {
                    menza.IdMenze = m.IdMenza;
                    menza.Naziv = m.Naziv;
                    menza.Lokacija = m.Lokacija;
                    menza.RadnoVreme = m.RadnoVreme;
                    menza.VanrednoNeRadi = m.VanrednoNeRadi;
                }
                
                SesijeProvajder.ZatvoriSesiju();

                if (menza != null)
                    return Content(HttpStatusCode.Found, menza);
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, "Menza nije pronadjena.");
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult VratiSveMenze()
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                IEnumerable<Menza> ienMenze = ProvajderPodatakaMenzi.VratiMenze();
                List<Menza> listaMenzi = ienMenze.ToList();
                List<MenzaFullDto> listaMenziFull = new List<MenzaFullDto>(listaMenzi.Count);

                for (int i = 0; i < listaMenzi.Count; ++i)
                {
                    MenzaFullDto menza = new MenzaFullDto();
                    Menza m = listaMenzi[i];

                    menza.IdMenze = m.IdMenza;
                    menza.Naziv = m.Naziv;
                    menza.Lokacija = m.Lokacija;
                    menza.RadnoVreme = m.RadnoVreme;
                    menza.VanrednoNeRadi = m.VanrednoNeRadi;

                    listaMenziFull.Add(menza);
                }
                SesijeProvajder.ZatvoriSesiju();

                if (listaMenziFull != null)
                    return Content(HttpStatusCode.Found, listaMenziFull);
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, "Menze nisu pronadjene.");
        }

    }
}
