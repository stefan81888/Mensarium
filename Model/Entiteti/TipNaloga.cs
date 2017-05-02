using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensarium_Desktop.Entiteti
{
     public class TipNaloga
    {
        public virtual int IdTip { get; set; }
        public virtual string Naziv { get; set; }

        public virtual IList<Privilegija> Privilegije { get; set; }
        public virtual IList<Korisnik> Korisnici { get; set; }

        public TipNaloga()
        {
            Korisnici = new List<Korisnik>();
            Privilegije = new List<Privilegija>();
        }

    }
}
