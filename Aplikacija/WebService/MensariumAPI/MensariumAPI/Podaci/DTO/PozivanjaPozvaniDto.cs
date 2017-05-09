using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;


namespace MensariumAPI.Podaci.DTO
{
    public class PozivanjaPozvaniDto
    {
        public virtual int Id { get; set; }
        public virtual bool OdgovorPozvanog { get; set; } // u bazi tiny int
        public virtual Korisnik Korisnici { get; set; }
        public virtual Pozivanja Pozivi { get; set; }
    }
}