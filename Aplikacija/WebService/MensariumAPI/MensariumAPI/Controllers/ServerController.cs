using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace MensariumAPI.Controllers
{
    [RoutePrefix("api/server")]
    public class ServerController : ApiController
    {

        [HttpGet]
        public HttpResponseMessage TestPovezivanje()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Uspesno uspostavljena veza sa serverom");
        }

        [System.Web.Http.HttpPost]
        [Route("sms")]
        public HttpResponseMessage SMSServis(FormDataCollection data)
        {

            string sms_text = data.Get("message");
            string secret = data.Get("secret");

            if (secret != "secreta")
                return Request.CreateResponse(HttpStatusCode.OK, "Mensarium SMS Servis GRESKA: Neuspela autentfikacija!");

            //Parsiraj sms_text
            //oblik: MENSARIUM RUCAK _IDKORISNIKA_
            //Vrati obican string...

            return Request.CreateResponse(HttpStatusCode.OK, "Mensarium SMS Servis: " + sms_text + " " + secret);
        }

    }
}
