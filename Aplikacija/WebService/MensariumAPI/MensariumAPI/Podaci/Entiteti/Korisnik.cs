using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumAPI.Podaci.Entiteti
{
    public class Korisnik
    {
        public virtual int IdKorisnika { get; protected set; }
        public virtual string Sifra { get; set; }
        public virtual string Email { get; set; }
        public virtual string KorisnickoIme { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual DateTime DatumRegistracije { get; set; }
        public virtual string BrojTelefona { get; set; }
        public virtual string BrojIndeksa { get; set; }
        public virtual DateTime? DatumVaziDo { get; set; }
        public virtual bool AktivanNalog { get; set; }
        public virtual string Slika { get; set; }
        public virtual bool Obrisan { get; set; }

        //Korisnik -> TipNaloga
        public virtual TipNaloga TipNaloga { get; set; }
        //Korisnik -> Fakulteti
        public virtual Fakultet StudiraFakultet { get; set; }
        //Korisnik <- Objave
        public virtual Objava Objava { get; set; }
        //Korisnik <- LoginSesije
        public virtual IList<LoginSesija> Sesije { get; set; }
        //Korisnik <- Pozivanja
        public virtual IList<Pozivanje> Pozivi { get; set; }
        //Korisnik -> Korisnik
        public virtual IList<Korisnik> Prati { get; set; }
        //Korisnik <- Korisnik
        public virtual IList<Korisnik> PracenOd { get; set; }
        //Korisnik <- Obroci
        public virtual IList<Obrok> Obroci { get; set; }
        //Korisnik <-- PozivanjaPozvani
        public virtual IList<PozivanjaPozvani> PozivanjaOd { get; set; }

        public Korisnik()
        {
            Sesije = new List<LoginSesija>();
            Pozivi = new List<Pozivanje>();
            Obroci = new List<Obrok>();
            PozivanjaOd = new List<PozivanjaPozvani>();

            AktivanNalog = true;
            Obrisan = false;

            //
            Prati = new List<Korisnik>();
            PracenOd = new List<Korisnik>();
        }
    }
}
