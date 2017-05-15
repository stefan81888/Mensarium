using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumAPI.Podaci.Entiteti
{
    public class TipNaloga
    {
        public virtual int IdTip { get; protected set; }
        public virtual string Naziv { get; set; }

        //TipNaloga <-> Privilegija M:N
        public virtual IList<Privilegija> Privilegije { get; set; }
        //TipNaloga <- Korisnici
        public virtual IList<Korisnik> Korisnici { get; set; }

        public TipNaloga()
        {
            Korisnici = new List<Korisnik>();
            Privilegije = new List<Privilegija>();
        }

    }
}
