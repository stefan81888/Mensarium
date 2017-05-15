using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumAPI.Podaci.Entiteti
{
    public class PozivanjaPozvani
    {
        public virtual PozivanjaPozvaniID IdPozivanjaPozvani { get; protected set; }
        public virtual bool? OdgovorPozvanog { get; set; }

        public PozivanjaPozvani()
        {
            IdPozivanjaPozvani = new PozivanjaPozvaniID();
        }

    }
}
