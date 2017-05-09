using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumAPI.Podaci.Entiteti
{
    public class Objave
    {
        public virtual int Id { get; set; } //primarni kljuc
        public virtual DateTime DatumObjave { get; set; }    
        public virtual string TekstObjave { get; set; } 
        public virtual Korisnik IdKorisnik { get; set; }
        public virtual Menza Lokacija { get; set; }

        
    }
}
