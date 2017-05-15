using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.DTO
{
    public class FakultetDto
    {
        public virtual string Naziv { get; set; }

        public virtual IList<KorisnikDto> Studenti { get; set; }

        public FakultetDto()
        {
            Studenti = new List<KorisnikDto>();
        }
    }
}