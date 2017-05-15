using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumAPI.Podaci.Entiteti
{
    public class Objava
    {
        public virtual int IdObjave { get; protected set; }
        //Objave -> Korisnici
        public virtual Korisnik IdKorisnik { get; set; }
        public virtual DateTime? DatumObjave { get; set; }
        public virtual string TekstObjave { get; set; }
        //Objave -> Menze
        public virtual Menza Lokacija { get; set; }

        public Objava()
        {
            TekstObjave = "";
        }
    }
}
