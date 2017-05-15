using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;


namespace MensariumAPI.Podaci.DTO
{
    public class TipNalogaDto
    {
        public virtual string Naziv { get; set; }

        public virtual IList<PrivilegijaDto> Privilegije { get; set; }
        public virtual IList<KorisnikDto> Korisnici { get; set; }

        public TipNalogaDto()
        {
            Korisnici = new List<KorisnikDto>();
            Privilegije = new List<PrivilegijaDto>();
        }
    }
}