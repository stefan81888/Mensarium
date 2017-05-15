using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumAPI.Podaci.Entiteti
{
    public class Obrok
    {
        public virtual int IdObroka { get; protected set; }
        public virtual bool Iskoriscen { get; set; }
        public virtual DateTime DatumUplacivanja { get; set; }
        public virtual DateTime? DatumIskoriscenja { get; set; }
        
        //Obroci -> Korisnici
        public virtual Korisnik Uplatilac { get; set; }
        //Obroci -> TipObroka
        public virtual TipObroka Tip { get; set; }
        //Obroci -> Menze
        public virtual Menza LokacijaUplate { get; set; }
        //Obroci -> Menze
        public virtual Menza LokacijaIskoriscenja { get; set; }

        public Obrok()
        {
            Iskoriscen = false;
            DatumIskoriscenja = null;
        }
    }
}
