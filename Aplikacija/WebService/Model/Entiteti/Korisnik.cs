using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Mensarium_Desktop.Entiteti
{
    public class Korisnik
    {
        public virtual int IdKorisnika { get; set; }
        public virtual string KorisnsickoIme { get; set; }
        public virtual  string Sifra { get; set; }
        public virtual string Email { get; set; }
        public virtual string KorisnickoIme { get; set; }     
        public virtual string Ime { get; set; }
        public virtual string Prezime{ get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual DateTime DatumRegistracije { get; set; }
        public virtual string BrojTelefona { get; set; }
        public virtual string BrojIndeksa { get; set; }
        public virtual DateTime DatumVaziDo { get; set; }
        public virtual bool AktivanNalog { get; set; } //VAZNO: u bazi je tiny int
        public virtual TipNaloga PrivilegijeNaloga { get; set; }
        public virtual Fakultet StudiraFakultet { get; set; }
        public virtual Objave Objava { get; set; }

        public virtual IList<LoginSesije> Sesije { get; set; }
        public virtual IList<Pozivanja> Pozivi { get; set; }
        public virtual IList<PozivanjaPozvani> Pozvani { get; set; }
        public virtual IList<Obrok >Obroci { get; set; }

        public Korisnik()
        {
            Sesije = new List<LoginSesije>();
            Pozivi = new List<Pozivanja>();
            Pozvani = new List<PozivanjaPozvani>();
            Obroci = new List<Obrok>();
        }
    }
}
