using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using MensariumAPI.Podaci.DTO;
using MensariumAPI.Podaci.Entiteti;
using MensariumAPI.Podaci.ProvajderiPodataka;

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
            
            string[] sadraj = sms_text.Split(' ');

            if (sadraj[0] != "MENSARIUM")
                return null;

            int id = int.Parse(sadraj[1]);
            string tip = sadraj[2];
            int brojObroka = int.Parse(sadraj[3]);
            try
            {
                SesijeProvajder.OtvoriSesiju();

                bool status = ProvajderPodatakaObroka.UplatiObrok(id, brojObroka,
                    ProvajderPodatakaObroka.SmsUplate[tip]);

                if (!status)
                    return Request.CreateResponse(HttpStatusCode.OK, "Greska: nevalidni parametri");

                Korisnik k = ProvajderPodatakaKorisnika.VratiKorisnika(id);

                KorisnikStanjeDto stanje = ProvajderPodatakaKorisnika.Stanje(k);

                string odgovor = string.Format("Uspešno ste uplatili {0} obroka tipa {1} Stanje:     " +
                                               "Doručak:    {2}   Ručak:    {3}   Večera:   {4}",
                    brojObroka, 
                    tip.ToLower(),
                    stanje.BrojDorucka,
                    stanje.BrojRuckova,
                    stanje.BrojVecera);

                return Request.CreateResponse(HttpStatusCode.OK, odgovor);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "SMS SERVIS INTERNA GRESKA. POKUSAJTE KASNIJE");
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }
            
        }

    }
}
