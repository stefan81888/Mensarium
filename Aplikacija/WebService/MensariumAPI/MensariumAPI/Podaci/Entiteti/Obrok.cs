using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumAPI.Podaci.Entiteti
{
    public class Obrok
    {
        public virtual int IdObroka { get; set; }
        public virtual bool Iskoriscen { get; set; }
        public virtual DateTime DatumUplacivanja { get; set; }
        public virtual string DatumIskoriscenja { get; set; }
        public virtual Korisnik Student { get; set; }
        public virtual TipObroka Tip { get; set; }
        public virtual Menza LokacijaUplate { get; set; }
        public virtual Menza LokacijaIskoriscenja { get; set; }
    }
}
