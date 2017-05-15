using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumAPI.Podaci.Entiteti
{
    public class Pozivanje
    {
        public virtual int IdPoziva { get; protected set; }
        public virtual DateTime DatumPoziva { get; set; }
        public virtual DateTime VaziDo { get; set; }

        //Pozivanja -> Korisnici
        public virtual Korisnik Pozivaoc { get; set; }

        //Pozivanja <- PozivanjePozvani (M:N+atributima)
        public virtual IList<PozivanjaPozvani> Pozvani { get; set; }

        public Pozivanje()
        {
            Pozvani = new List<PozivanjaPozvani>();
        }
    }
}
