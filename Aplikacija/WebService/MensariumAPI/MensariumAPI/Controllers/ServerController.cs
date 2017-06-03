using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MensariumAPI.Controllers
{
    [RoutePrefix("server")]
    public class ServerController : ApiController
    {

        [HttpGet]
        public HttpResponseMessage jeNaVezi()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Uspesno uspostavljena veza sa serverom");
        }
    }
}
