using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumAPI.Podaci.Entiteti
{
    public class Privilegija
    {
        public virtual int IdPrivilegije { get; protected set; }
        public virtual string Opis { get; set; }

        //Privilegija <-> TipNaloga M:N
        public virtual IList<TipNaloga> Nalozi { get; set; }

        public Privilegija()
        {
            Nalozi = new List<TipNaloga>();
        }
    }
}
