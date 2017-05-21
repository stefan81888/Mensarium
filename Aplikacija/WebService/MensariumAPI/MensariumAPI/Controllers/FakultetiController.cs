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
    public class FakultetiController : ApiController
    {
        [HttpGet]
        public FakultetFullDto VratiFakultetFull(int id)
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
            return fakultet;
        }

        [HttpGet]
        public List<FakultetFullDto> VratiSveFakulteteFull()
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
            return listaFakultetaFull;
        }

        [HttpPost]
        [Route("dodaj")]
        public void DodajFakultet([FromBody]FakultetFullDto fdto)
        {
            SesijeProvajder.OtvoriSesiju();

            Fakultet f = new Fakultet()
            {
                Naziv = fdto.Naziv
            };

            ProvajderPodatakaFakulteta.DodajFakultet(f);

            SesijeProvajder.ZatvoriSesiju();
        }

        [HttpPut]
        [Route("update")]
        public void UpdateFakultet([FromBody]FakultetFullDto fdto)
        {
            SesijeProvajder.OtvoriSesiju();

            Fakultet f = ProvajderPodatakaFakulteta.VratiFakultet(fdto.IdFakultet);
            if (ValidatorFakulteta.FakultetPostoji(f))
            {
                f.Naziv = fdto.Naziv;
                ProvajderPodatakaFakulteta.UpdateFakultet(f);
            }

            SesijeProvajder.ZatvoriSesiju();
        }
    }
}
