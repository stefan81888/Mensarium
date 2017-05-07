using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensarium_Desktop.Entiteti
{
    public class PozivanjaPozvani
    {
        public virtual int Id { get; set; }
        public virtual bool OdgovorPozvanog { get; set; } // u bazi tiny int
        public virtual Korisnik Korisnici { get; set; }
        public virtual Pozivanja Pozivi { get; set; }
    }
}
