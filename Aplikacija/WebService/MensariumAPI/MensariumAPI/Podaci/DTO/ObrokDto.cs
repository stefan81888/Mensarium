using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;


namespace MensariumAPI.Podaci.DTO
{
    public class ObrokDto
    {
        public virtual bool Iskoriscen { get; set; }
        public virtual DateTime DatumUplacivanja { get; set; }
        public virtual string DatumIskoriscenja { get; set; }
        public virtual KorisnikDto Uplatilac { get; set; }
        public virtual TipObrokaDto Tip { get; set; }
        public virtual MenzaDto LokacijaUplate { get; set; }
        public virtual MenzaDto LokacijaIskoriscenja { get; set; }
    }
}