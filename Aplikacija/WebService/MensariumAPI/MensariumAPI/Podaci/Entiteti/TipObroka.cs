using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumAPI.Podaci.Entiteti
{
    public class TipObroka
    {
        public virtual int IdTipObroka { get; protected set; }
        public virtual string Naziv { get; set; }

        //TipObroka <- Obroci
        public virtual IList<Obrok> Obroci { get; set; }

        public TipObroka()
        {
            Obroci = new List<Obrok>();
        }
    }
}
