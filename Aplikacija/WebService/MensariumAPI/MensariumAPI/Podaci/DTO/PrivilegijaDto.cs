using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;


namespace MensariumAPI.Podaci.DTO
{
    public class PrivilegijaDto
    {
        public virtual int IdPrivilegije { get; set; }
        public virtual string Opis { get; set; }

        public virtual IList<TipNaloga> Nalozi { get; set; }

        public PrivilegijaDto()
        {
            Nalozi = new List<TipNaloga>(); 
        }
    }
}