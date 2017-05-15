using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.DTO
{
    public class PozivanjeDto
    {
        public virtual DateTime DatumPoziva { get; set; }
        public virtual DateTime VaziDo { get; set; }

        //Pozivanja -> Korisnici
        public virtual KorisnikDto Pozivalac { get; set; }

        //Pozivanja <- PozivanjePozvani (M:N+atributima)
        public virtual IList<PozivanjaPozvaniDto> Pozvani { get; set; }

        public PozivanjeDto()
        {
            Pozvani = new List<PozivanjaPozvaniDto>();
        }
    }
}