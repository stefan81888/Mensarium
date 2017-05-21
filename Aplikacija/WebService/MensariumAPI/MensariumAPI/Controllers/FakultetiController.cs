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
    [System.Web.Http.RoutePrefix("api/fakulteti")]
    public class FakultetiController : ApiController
    {
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("full/{id:int}")]
        public IHttpActionResult VratiFakultetFull(int id)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                Fakultet f = ProvajderPodatakaFakulteta.VratiFakultet(id);
                FakultetFullDto fakultet = new FakultetFullDto();
                if (ValidatorFakulteta.FakultetPostoji(f))
                {
                    fakultet.IdFakultet = f.IdFakultet;
                    fakultet.Naziv = f.Naziv;
                }
                SesijeProvajder.ZatvoriSesiju();

                if (fakultet != null)
                    return Content(HttpStatusCode.Found, fakultet);
            }
            catch(Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, new FakultetFullDto());
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult VratiSveFakulteteFull()
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                IEnumerable<Fakultet> ienFakulteti = ProvajderPodatakaFakulteta.VratiFakultete();
                List<Fakultet> listaFakulteta = ienFakulteti.ToList();
                List<FakultetFullDto> listaFakultetaFull = new List<FakultetFullDto>(listaFakulteta.Count);

                for (int i = 0; i < listaFakulteta.Count; ++i)
                {
                    FakultetFullDto fakultet = new FakultetFullDto();
                    Fakultet f = listaFakulteta[i];

                    fakultet.IdFakultet = f.IdFakultet;
                    fakultet.Naziv = f.Naziv;

                    listaFakultetaFull.Add(fakultet);
                }
                SesijeProvajder.ZatvoriSesiju();

                if (listaFakultetaFull != null)
                    return Content(HttpStatusCode.Found, listaFakultetaFull);
            }
            catch(Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, new List<FakultetFullDto>());
        }

        [HttpPost]
        [Route("dodaj")]
        public IHttpActionResult DodajFakultet([FromBody] FakultetFullDto fdto)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                Fakultet f = new Fakultet()
                {
                    Naziv = fdto.Naziv
                };

                ProvajderPodatakaFakulteta.DodajFakultet(f);

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.OK, "Fakultet uspesno dodat.");
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, "Dodavanje fakulteta nije uspelo.");
        }

        [System.Web.Http.HttpPut]
        [System.Web.Http.Route("update")]
        public IHttpActionResult UpdateFakultet([FromBody]FakultetFullDto fdto)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                Fakultet f = ProvajderPodatakaFakulteta.VratiFakultet(fdto.IdFakultet);
                if (ValidatorFakulteta.FakultetPostoji(f))
                {
                    f.Naziv = fdto.Naziv;
                    ProvajderPodatakaFakulteta.UpdateFakultet(f);
                }

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.OK, "Fakultet uspesno modifikovan.");
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, "Modifikovanje fakulteta nije uspelo.");
        }

        [System.Web.Http.HttpDelete]
        [System.Web.Http.Route("obrisi/{id:int}")]
        public IHttpActionResult ObrisiFakultet(int id)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

              
                ProvajderPodatakaFakulteta.ObrisiFakultet(id);

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.OK, "Fakultet uspesno obrisan.");
            }
            catch (Exception e)
            {

            }
            return Content(HttpStatusCode.BadRequest, "Brisanje fakulteta nije uspelo.");
        }
    }
}
