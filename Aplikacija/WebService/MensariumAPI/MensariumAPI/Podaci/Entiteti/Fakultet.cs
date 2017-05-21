using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumAPI.Podaci.Entiteti
{
    public class Fakultet
    {
        public virtual int IdFakultet { get; protected set; }
        public virtual string Naziv { get; set; }

        //Fakultet <- Korisnici
        public virtual IList<Korisnik> Studenti { get; set; }

        public Fakultet()
        {
            Studenti = new List<Korisnik>();
        }
    }
}
