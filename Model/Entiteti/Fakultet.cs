using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensarium_Desktop.Entiteti
{
    public class Fakultet
    {
        public virtual int IdFakultet { get; set; }
        public virtual string Naziv { get; set; }

        public virtual IList<Korisnik> Studenti { get; set; }

        public Fakultet()
        {
            Studenti = new List<Korisnik>();
        }
    }
}
