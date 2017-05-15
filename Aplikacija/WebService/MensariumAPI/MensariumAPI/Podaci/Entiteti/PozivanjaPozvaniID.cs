using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumAPI.Podaci.Entiteti
{
    public class PozivanjaPozvaniID
    {
        public virtual Pozivanje IdPoziva { get; set; }
        public virtual Korisnik IdPozvanog { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(PozivanjaPozvaniID))
                return false;

            PozivanjaPozvaniID receivedObject = (PozivanjaPozvaniID) obj;

            if ((IdPoziva.IdPoziva == receivedObject.IdPoziva.IdPoziva) && 
                (IdPozvanog.IdKorisnika == receivedObject.IdPozvanog.IdKorisnika))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
