using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensarium_Desktop.Entiteti
{
    public class Menza
    {
        public virtual int IdMenza { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Lokacija { get; set; }
        public virtual string RadnoVreme { get; set; }
        public virtual bool VanrednoNeRadi { get; set; } // u bazi je tinyint

        public virtual IList<Objave> Objava { get; set; }
        public virtual IList<Menza> Uplaceni { get; set; }
        public virtual IList<Menza> Iskorisceni { get; set; }

        public Menza()
        {
            Objava = new List<Objave>();
            Uplaceni = new List<Menza>();
            Iskorisceni = new List<Menza>();
        }
    }
}
