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
		public IHttpActionResult VratiFakultetFull([FromUri]int idFakulteta, [FromUri]string idSesije)
		{
			try
			{
				SesijeProvajder.OtvoriSesiju();
				if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(idSesije, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
				{
					SesijeProvajder.ZatvoriSesiju();
					return Content(HttpStatusCode.BadRequest, "Nemate dozvolu za ovu radnju.");
				}

				Fakultet f = ProvajderPodatakaFakulteta.VratiFakultet(idFakulteta);
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
		public IHttpActionResult VratiSveFakulteteFull([FromUri]string idSesije)
		{
			try
			{
				SesijeProvajder.OtvoriSesiju();
				if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(idSesije, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
				{
					SesijeProvajder.ZatvoriSesiju();
					return Content(HttpStatusCode.BadRequest, "Nemate dozvolu za ovu radnju.");
				}

				List<Fakultet> listaFakulteta = ProvajderPodatakaFakulteta.VratiFakultete();
				List<FakultetFullDto> listaFakultetaFull = new List<FakultetFullDto>(listaFakulteta.Count);

				foreach (Fakultet f in listaFakulteta)
				{
					listaFakultetaFull.Add(new FakultetFullDto()
					{
						IdFakultet = f.IdFakultet,
						Naziv = f.Naziv
					});
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
		public IHttpActionResult DodajFakultet([FromBody] FakultetFullDto fdto, [FromUri]string idSesije)
		{
			try
			{
				SesijeProvajder.OtvoriSesiju();
                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(idSesije, ValidatorPrivilegija.UserPrivilegies.CitanjeFakultet))
                {
                    SesijeProvajder.ZatvoriSesiju();
                    return Content(HttpStatusCode.BadRequest, "Nemate dozvolu za ovu radnju.");
                }

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
        public IHttpActionResult UpdateFakultet([FromBody]FakultetFullDto fdto, [FromUri]string idSesije)
		{
			try
			{
				SesijeProvajder.OtvoriSesiju();

                if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(idSesije, ValidatorPrivilegija.UserPrivilegies.ModifikacijaFakultet))
                {
                    SesijeProvajder.ZatvoriSesiju();
                    return Content(HttpStatusCode.BadRequest, "Nemate dozvolu za ovu radnju.");
                }

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
		[System.Web.Http.Route("obrisi")]
		public IHttpActionResult ObrisiFakultet([FromUri]int idFakulteta,  [FromUri]string idSesije)
		{
			try
			{
				SesijeProvajder.OtvoriSesiju();

				if (!ValidatorPrivilegija.KorisnikImaPrivilegiju(idSesije, ValidatorPrivilegija.UserPrivilegies.BrisanjeFakultet))
				{
					SesijeProvajder.ZatvoriSesiju();
					return Content(HttpStatusCode.BadRequest, "Nemate dozvolu za ovu radnju.");
				}
				
				ProvajderPodatakaFakulteta.ObrisiFakultet(idFakulteta);
				SesijeProvajder.ZatvoriSesiju();

				return Content(HttpStatusCode.OK, "Fakultet uspesno obrisan.");
			}
			catch (Exception e)
			{
				return Content(HttpStatusCode.BadRequest, "Operacija neuspela. Razlog: " + e.Message);
			}
			return Content(HttpStatusCode.BadRequest, "Brisanje fakulteta nije uspelo.");
		}

		
	}
}
