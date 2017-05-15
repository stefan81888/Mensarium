using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.DTO
{
    public class KorisnikDto
    {
        public virtual string KorisnsickoIme { get; set; }
        public virtual string Sifra { get; set; }
        public virtual string Email { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual DateTime DatumRegistracije { get; set; }
        public virtual string BrojTelefona { get; set; }
        public virtual string BrojIndeksa { get; set; }
        public virtual DateTime DatumVaziDo { get; set; }
        public virtual bool AktivanNalog { get; set; } //VAZNO: u bazi je tiny int
        public virtual TipNalogaDto PrivilegijeNaloga { get; set; }
        public virtual FakultetDto StudiraFakultet { get; set; }
        public virtual ObjaveDto Objava { get; set; }

        public virtual IList<LoginSesijeDto> Sesije { get; set; }
        public virtual IList<PozivanjaDto> Pozivi { get; set; }
        public virtual IList<PozivanjaPozvaniDto> PozvaniOd { get; set; }
        public virtual IList<ObrokDto> Obroci { get; set; }
        public virtual IList<KorisnikDto> Prati { get; set; }
        public virtual IList<KorisnikDto> PracenOd { get; set; }

        public KorisnikDto()
        {
            Sesije = new List<LoginSesijeDto>();
            Pozivi = new List<PozivanjaDto>();
            PozvaniOd = new List<PozivanjaPozvaniDto>();
            Obroci = new List<ObrokDto>();
            PracenOd = new List<KorisnikDto>();
            Prati = new List<KorisnikDto>();
        }
    }
}