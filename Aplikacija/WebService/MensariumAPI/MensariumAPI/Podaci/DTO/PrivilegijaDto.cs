using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;


namespace MensariumAPI.Podaci.DTO
{
    public class PrivilegijaDto
    {
        public virtual string Opis { get; set; }

        public virtual IList<TipNalogaDto> Nalozi { get; set; }

        public PrivilegijaDto()
        {
            Nalozi = new List<TipNalogaDto>();
        }
    }
}