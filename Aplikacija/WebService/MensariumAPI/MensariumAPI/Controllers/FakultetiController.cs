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
	[System.Web.Http.RoutePrefix("api/fakulteti")]
	public class FakultetiController : ApiController
	{
		[System.Web.Http.HttpGet]
		public FakultetFullDto VratiFakultetFull([FromUri]int id, [FromUri]string sid)
		{
			try
			{
				SesijeProvajder.OtvoriSesiju();

			    if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
			        throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
			            { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
					throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });

				Fakultet f = null;
				FakultetFullDto fakultet = new FakultetFullDto();

				f = ProvajderPodatakaFakulteta.VratiFakultet(id);
				if (f == null)
					throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("Fakultet nije pronadjen") });

				fakultet.IdFakultet = f.IdFakultet;
				fakultet.Naziv = f.Naziv;
				return fakultet;
			}
			catch (Exception e)
			{
				if (e is HttpResponseException)
					throw e;
				DnevnikIzuzetaka.Zabelezi(e);
				throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("InternalError: " + e.Message) });
				//throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent("Fakultet nije napravljen!") });
			}
			finally
			{
				SesijeProvajder.ZatvoriSesiju();
			}  
		}

		[System.Web.Http.HttpGet]
		public List<FakultetFullDto> VratiSveFakulteteFull([FromUri]string sid)
		{
			try
			{
				SesijeProvajder.OtvoriSesiju();

			    if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
			        throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
			            { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
					throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });
				
				List<Fakultet> listaFakulteta = ProvajderPodatakaFakulteta.VratiFakultete();
				List<FakultetFullDto> listaFakultetaFull = new List<FakultetFullDto>(listaFakulteta.Count);


				if (listaFakulteta == null)
					throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("Fakulteti nisu pronadjeni") });

				foreach (Fakultet f in listaFakulteta)
				{
					listaFakultetaFull.Add(new FakultetFullDto()
					{
						IdFakultet = f.IdFakultet,
						Naziv = f.Naziv
					});
				}

				return listaFakultetaFull;
			}
			catch(Exception e)
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
		public IHttpActionResult DodajFakultet([FromBody] FakultetFullDto fdto, [FromUri]string sid)
		{
			try
			{
				SesijeProvajder.OtvoriSesiju();

			    if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
			        throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
			            { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
					throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });
				
				Fakultet f = new Fakultet()
				{
					Naziv = fdto.Naziv
				};

				ProvajderPodatakaFakulteta.DodajFakultet(f);
				return Ok("Fakutet uspesno dodat");
			}
			catch (Exception e)
			{
				if (e is HttpResponseException)
					throw e;
				DnevnikIzuzetaka.Zabelezi(e);
				throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("InternalError: " + e.Message) });
				//throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent("Fakultet nije napravljen!") });
			}
			finally
			{
				SesijeProvajder.ZatvoriSesiju();
			}
		}

		[System.Web.Http.HttpPut]
		[System.Web.Http.Route("update")]
		public IHttpActionResult UpdateFakultet([FromBody]FakultetFullDto fdto, [FromUri]string sid)
		{
			try
			{
				SesijeProvajder.OtvoriSesiju();

			    if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
			        throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
			            { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.ModifikacijaFakultet))
					throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });

				Fakultet f = ProvajderPodatakaFakulteta.VratiFakultet(fdto.IdFakultet);
				
				if (f == null)
					throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("Fakultet za modifikaciju nije pronadjen") });
				

				f.Naziv = fdto.Naziv;
				ProvajderPodatakaFakulteta.UpdateFakultet(f);
				return Ok("Fakutet uspesno modifikovan");
				
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
		public IHttpActionResult ObrisiFakultet([FromUri]int id,  [FromUri]string sid)
		{
			try
			{
				SesijeProvajder.OtvoriSesiju();

			    if (!ProvajderPodatakaKorisnika.SesijaValidna(sid))
			        throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
			            { Content = new StringContent("Sesija istekla") });

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(sid, ValidatorPrivilegija.UserPrivilegies.BrisanjeFakultet))
					throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("Nemate privilegiju") });

				Fakultet f = null;
				f = ProvajderPodatakaFakulteta.VratiFakultet(id);
				if (f == null)
					throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("Fakultet za brisanje nije pronadjen") });
				
				ProvajderPodatakaFakulteta.ObrisiFakultet(id);
				return Ok("Fakutet uspesno obrisan");
			
			}
			catch (Exception e)
			{
				if (e is HttpResponseException)
					throw e;
				DnevnikIzuzetaka.Zabelezi(e);
				throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent("Fakultet nije moguce obrisati") });
			}
			finally
			{
				SesijeProvajder.ZatvoriSesiju();
			}
		}
	}
}
