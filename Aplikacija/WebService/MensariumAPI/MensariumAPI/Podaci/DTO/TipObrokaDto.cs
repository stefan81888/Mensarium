using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;


namespace MensariumAPI.Podaci.DTO
{
    public class TipObrokaDto
    {
        public virtual int IdTipObroka { get; set; }
        public virtual string Naziv { get; set; }

        public virtual IList<Obrok> Obroci { get; set; }

        public TipObrokaDto()
        {
            Obroci = new List<Obrok>();
        }
    }
}