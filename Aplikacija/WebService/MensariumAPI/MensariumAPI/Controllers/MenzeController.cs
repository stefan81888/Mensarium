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
    [System.Web.Http.RoutePrefix("api/menze")]
    public class MenzeController : ApiController
    {
        [HttpGet]
        [Route("full/{id:int}")]
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
            return Content(HttpStatusCode.BadRequest, new MenzaFullDto());
        }

        [HttpGet]
        public IHttpActionResult VratiSveMenze()
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                List<Menza> listaMenzi = ProvajderPodatakaMenzi.VratiMenze();
                List<MenzaFullDto> listaMenziFull = new List<MenzaFullDto>(listaMenzi.Count);

                foreach (Menza m in listaMenzi)
                {
                    listaMenziFull.Add(new MenzaFullDto()
                    {
                        IdMenze = m.IdMenza,
                        Naziv = m.Naziv,
                        Lokacija = m.Lokacija,
                        RadnoVreme = m.RadnoVreme,
                        VanrednoNeRadi = m.VanrednoNeRadi
                    });
                }

                SesijeProvajder.ZatvoriSesiju();

                if (listaMenziFull != null)
                    return Content(HttpStatusCode.Found, listaMenziFull);
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, new List<MenzaFullDto>());
        }

        [HttpPost]
        [Route("dodaj")]
        public IHttpActionResult DodajMenzu([FromBody]MenzaFullDto mdto)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                ProvajderPodatakaMenzi.DodajMenzu(new Menza()
                {
                    Lokacija = mdto.Lokacija,
                    Naziv = mdto.Naziv,
                    RadnoVreme = mdto.RadnoVreme,
                    VanrednoNeRadi = mdto.VanrednoNeRadi
                });

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.OK, "Menza uspesno dodata.");
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, "Dodavanje menze nije uspelo.");
        }

        [HttpGet]
        [Route("guzvaZaJelo/{idMenze:int}")]
        public IHttpActionResult GuzvaZaJelo(int idMenze)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                int procenatGuzveZaJelo = Convert.ToInt32(ProvajderPodatakaMenzi.BrojObrokaSkinutihUPoslednjihPetMinuta(idMenze) * 0.3);
                if (procenatGuzveZaJelo > 100)
                    procenatGuzveZaJelo = 100;

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.Found, procenatGuzveZaJelo);
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, -1);
        }

        [HttpGet]
        [Route("guzvaZaUplatu/{idMenze:int}")]
        public IHttpActionResult GuzvaZaUplatu(int idMenze)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                int procenatGuzveZaUplatu = Convert.ToInt32(ProvajderPodatakaMenzi.BrojObrokaUplacenihUPoslednjihPetMinuta(idMenze) * 0.1);
                if (procenatGuzveZaUplatu > 100)
                    procenatGuzveZaUplatu = 100;

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.Found, procenatGuzveZaUplatu);
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, -1);
        }
    }
}