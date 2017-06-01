using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MensariumAPI.Podaci.DTO;
using MensariumAPI.Podaci.ProvajderiPodataka;

namespace MensariumAPI.Controllers
{
    [System.Web.Http.RoutePrefix("api/objave")]
    public class ObjaveController : ApiController
    {
        //Objava korisnika
        [HttpGet]
        [System.Web.Http.Route("prikazi/{id:int}")]
        public IHttpActionResult PrikaziObjavu(int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                ObjavaFullDto o = ProvajderPodatakaObjava.VratiObjavuDto(id);

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.Found, o);
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new ObjavaFullDto());
        }

        //Azuriranje objave korisnika
        [HttpPost]
        [System.Web.Http.Route("objavi/{id:int}")]
        public IHttpActionResult Objavi(int id, [FromBody] ObjavaCUDto ocdto, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                ObjavaCUDto o = ProvajderPodatakaObjava.Objavi(id, ocdto);

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.Found, o);
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new ObjavaFullDto());
        }

        //Prikaz objava korisnika koje korisnik prati
        [HttpGet]
        [System.Web.Http.Route("newsfeed/{id:int}")]
        public IHttpActionResult PrikaziSveObjave(int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                List<ObjavaReadDto> o = ProvajderPodatakaObjava.SveObjave(id);

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.Found, o);
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new ObjavaReadDto());
        }
    }
}
