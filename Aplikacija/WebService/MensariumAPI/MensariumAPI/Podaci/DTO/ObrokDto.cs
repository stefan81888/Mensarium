using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;


namespace MensariumAPI.Podaci.DTO
{
    public class ObrokDto
    {
        public int IdObroka { get; protected set; }
        public bool Iskoriscen { get; set; }
        public DateTime DatumUplacivanja { get; set; }
        public string DatumIskoriscenja { get; set; }
        public KorisnikDto Uplatilac { get; set; }
        public TipObrokaDto Tip { get; set; }
        public MenzaDto LokacijaUplate { get; set; }
        public MenzaDto LokacijaIskoriscenja { get; set; }
    }
}