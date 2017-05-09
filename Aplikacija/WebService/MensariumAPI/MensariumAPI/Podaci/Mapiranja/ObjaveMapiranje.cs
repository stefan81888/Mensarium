using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.Mapiranja
{
    class ObjaveMapiranje : ClassMap<Objave>
    {
        public ObjaveMapiranje()
        {
            //Mapiranje tabele
            Table("Objave");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "idKorisnika"); 

            //Mapiranje svojstava
            Map(x => x.DatumObjave, "datumObjave");
            Map(x => x.TekstObjave, "textObjave");


            //Mapiranje veze 1:1
            HasOne(x => x.IdKorisnik); 
            

            //Mapiranje veze 1:N
            References(x => x.Lokacija).Column("idLokacija").LazyLoad();
        }
    }
}
