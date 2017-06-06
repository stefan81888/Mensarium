using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MensariumAPI.Podaci;
using MensariumAPI.Podaci.DTO;
using MensariumAPI.Podaci.ProvajderiPodataka;

namespace MensariumAPI.Controllers
{
    [RoutePrefix("api/objave")]
    public class ObjaveController : ApiController
    {
        //Objava korisnika
        [HttpGet]
        [Route("prikazi")]
        public ObjavaFullDto PrikaziObjavu(int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();
                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Nemate privilegiju") });

                ObjavaFullDto o = ProvajderPodatakaObjava.VratiObjavuDto(id);

                if(o == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                    { Content = new StringContent("Objava ne postoji") });

                return o;
            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("InternalError: " + e.Message) });
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }
        }

        //Azuriranje objave korisnika
        [HttpPost]
        [Route("objavi")]
        public ObjavaCUDto Objavi(int id, [FromBody] ObjavaCUDto ocdto, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                    { Content = new StringContent("Nemate privilegiju") });

                ObjavaCUDto o = ProvajderPodatakaObjava.Objavi(id, ocdto);

                if(o == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                    { Content = new StringContent("Fakultet nije pronadjen") });

                return o;
            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("InternalError: " + e.Message) });
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }
        }

        //Prikaz objava korisnika koje korisnik prati
        [HttpGet]
        [Route("pracenih")]
        public List<ObjavaReadDto> PrikaziSveObjave(int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden)
                        { Content = new StringContent("Nemate privilegiju") });

                List<ObjavaReadDto> o = ProvajderPodatakaObjava.SveObjave(id);

                if (o.Count == 0)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Korisnik nema objavu") });

                return o;
            }
            catch (Exception e)
            {
                if (e is HttpResponseException)
                    throw e;
                DnevnikIzuzetaka.Zabelezi(e);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("InternalError: " + e.Message) });
            }
            finally
            {
                SesijeProvajder.ZatvoriSesiju();
            }
        }
    }
}
