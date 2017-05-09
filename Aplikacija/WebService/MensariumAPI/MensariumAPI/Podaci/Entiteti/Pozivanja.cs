using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumAPI.Podaci.Entiteti
{
    public class Pozivanja
    {
        public virtual int IdPoziva { get; set; }
        public virtual DateTime DatumPoziva { get; set; }
        public virtual string VremeTrajanja { get; set; } // u bazi je time
        public virtual Korisnik Poziva { get; set; } // onaj ko poziva na obrok

        public virtual IList<PozivanjaPozvani> Pozvani { get; set; }

        public Pozivanja()
        {
            Pozvani = new List<PozivanjaPozvani>();
        }
    }
}
