using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumAPI.Podaci.Entiteti
{
    public class Menza
    {
        public virtual int IdMenza { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual string Lokacija { get; set; }
        public virtual string RadnoVreme { get; set; }
        public virtual bool VanrednoNeRadi { get; set; }
        public virtual double GpsLon { get; set; }
        public virtual double GpsLat { get; set; }

        //Menze <- Obroci
        public virtual IList<Objava> ObjaveKorisnika { get; set; }
        //Menze <- Obroci (lokacijaUplate)
        public virtual IList<Obrok> Uplaceni { get; set; }
        //Menze <- Obroci (lokacijaIskoriscenja)
        public virtual IList<Obrok> Iskorisceni { get; set; }

        public Menza()
        {
            ObjaveKorisnika = new List<Objava>();
            Uplaceni = new List<Obrok>();
            Iskorisceni = new List<Obrok>();
        }
    }
}
