using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.Mapiranja
{
    public class ObjavaMapiranje : ClassMap<Objava>
    {
        public ObjavaMapiranje()
        {
            Table("Objave");

            Id(x => x.IdObjave, "idObjave");

            Map(x => x.DatumObjave, "datumObjave");
            Map(x => x.TekstObjave, "textObjave");

            //Objave -> Korisnici
            References(x => x.IdKorisnik).Column("idKorisnika").Unique();
            //Objave -> Menze
            References(x => x.Lokacija).Column("idLokacija");
        }
    }
}
