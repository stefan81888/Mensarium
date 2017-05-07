using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensarium_Desktop.Entiteti
{
    public class Pracenja
    {
        public virtual int Id { get; set; } //primarni kljuc
        public virtual Korisnik Pratilac { get; set; }

        public virtual IList<Korisnik> Praceni { get; set; }

        public Pracenja()
        {
            Praceni = new List<Korisnik>();
        }
    }
}
