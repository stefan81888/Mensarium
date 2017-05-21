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
        [HttpGet]
        [System.Web.Http.Route("prikazi/{id:int}")]
        public IHttpActionResult PrikaziSveObjave(int id)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                ObjavaFullDto o = ProvajderPodatakaObjava.VratiObjavu(id);

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.Found, o);
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new ObjavaFullDto());
        }

        [HttpPost]
        [System.Web.Http.Route("objavi/{id:int}")]
        public IHttpActionResult Objavi(int id, [FromBody] ObjavaCUDto ocdto)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                //ObjavaFullDto o = ProvajderPodatakaObjava.VratiObjavu(id);

                SesijeProvajder.ZatvoriSesiju();

                return Content(HttpStatusCode.Found, "");
            }
            catch (Exception e)
            {
            }
            return Content(HttpStatusCode.BadRequest, new ObjavaFullDto());
        }
    }
}
