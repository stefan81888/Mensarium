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
using MensariumAPI.Podaci;

namespace MensariumAPI.Controllers
{
    [System.Web.Http.RoutePrefix("api/menze")]
    public class MenzeController : ApiController
    {
        [HttpGet]
        public MenzaFullDto VratiMenzuFull([FromUri]int id, [FromUri]string sid)
        {

            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeMenza))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });

                Menza m = null;
                MenzaFullDto menza = new MenzaFullDto();

                m = ProvajderPodatakaMenzi.VratiMenzu(id);
                if (m == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("Menza nije pronadjena") });

                menza.IdMenze = m.IdMenza;
                menza.Naziv = m.Naziv;
                menza.Lokacija = m.Lokacija;
                menza.RadnoVreme = m.RadnoVreme;
                menza.VanrednoNeRadi = m.VanrednoNeRadi;
                menza.GpsLat = m.GpsLat;
                menza.GpsLong = m.GpsLon;

                return menza;
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

        [HttpGet]
        public List<MenzaFullDto> VratiSveMenze([FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeMenza))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });
                

                List<Menza> listaMenzi = ProvajderPodatakaMenzi.VratiMenze();
                List<MenzaFullDto> listaMenziFull = new List<MenzaFullDto>(listaMenzi.Count);

                if (listaMenzi.Count == 0)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("Menze nisu pronadjene") });


                foreach (Menza m in listaMenzi)
                {
                    listaMenziFull.Add(new MenzaFullDto()
                    {
                        IdMenze = m.IdMenza,
                        Naziv = m.Naziv,
                        Lokacija = m.Lokacija,
                        RadnoVreme = m.RadnoVreme,
                        VanrednoNeRadi = m.VanrednoNeRadi,
                        GpsLat = m.GpsLat,
                        GpsLong = m.GpsLon
                    });
                }

                return listaMenziFull;
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

        [HttpPost]
        [Route("dodaj")]
        public IHttpActionResult DodajMenzu([FromBody]MenzaFullDto mdto, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.DodavanjeMenza))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });
                
                ProvajderPodatakaMenzi.DodajMenzu(new Menza()
                {
                    Lokacija = mdto.Lokacija,
                    Naziv = mdto.Naziv,
                    RadnoVreme = mdto.RadnoVreme,
                    VanrednoNeRadi = mdto.VanrednoNeRadi,
                    GpsLat = mdto.GpsLat,
                    GpsLon =  mdto.GpsLong 
                });

                return Ok("Menza uspesno dodata");
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

        [HttpGet]
        [Route("guzvaMenza")]
        public int GuzvaZaJelo([FromUri]int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeGuzvaMenza))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });

                Menza m = null;

                m = ProvajderPodatakaMenzi.VratiMenzu(id);
                if (m == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("Menza nije pronadjena") });

                int procenatGuzveZaJelo = Convert.ToInt32(ProvajderPodatakaMenzi.BrojObrokaSkinutihUPoslednjihPetMinuta(id) * 0.3);
                if (procenatGuzveZaJelo > 100)
                    procenatGuzveZaJelo = 100;
                return procenatGuzveZaJelo;
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

        [HttpGet]
        [Route("guzvaUplata")]
        public int GuzvaZaUplatu([FromUri]int id, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeGuzvaMenza))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });

                Menza m = null;

                m = ProvajderPodatakaMenzi.VratiMenzu(id);
                if (m == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("Menza nije pronadjena") });

                int procenatGuzveZaUplatu = Convert.ToInt32(ProvajderPodatakaMenzi.BrojObrokaUplacenihUPoslednjihPetMinuta(id) * 0.1);
                if (procenatGuzveZaUplatu > 100)
                    procenatGuzveZaUplatu = 100;

                return procenatGuzveZaUplatu;
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

        [HttpPut]
        [Route("update")]
        public IHttpActionResult UpdateMenzu([FromBody]MenzaFullDto mdto, [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.ModifikacijaMenza))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });

                Menza m = ProvajderPodatakaMenzi.VratiMenzu(mdto.IdMenze);

                if (m == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("Menza za modifikaciju nije pronadjena") });

                m.Naziv = mdto.Naziv;
                m.Lokacija = mdto.Lokacija;
                m.RadnoVreme = mdto.RadnoVreme;
                m.VanrednoNeRadi = mdto.VanrednoNeRadi;
                m.GpsLat = mdto.GpsLat;
                m.GpsLon = mdto.GpsLong;

                ProvajderPodatakaMenzi.UpdateMenzu(m);
                return Ok("Menza uspesno modifikovana");
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

        [System.Web.Http.HttpDelete]
		[System.Web.Http.Route("obrisi")]
		public IHttpActionResult ObrisiMenzu([FromUri]int id,  [FromUri]string sid)
        {
            try
            {
                SesijeProvajder.OtvoriSesiju();

                if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
                        { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.BrisanjeMenza))
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });

                Menza m = null;
                m = ProvajderPodatakaMenzi.VratiMenzu(id);
                if (m == null)
                    throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("Menza za brisanje nije pronadjena") });

                ProvajderPodatakaMenzi.ObrisiMenzu(id);
                return Ok("Menza uspesno obrisana");
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