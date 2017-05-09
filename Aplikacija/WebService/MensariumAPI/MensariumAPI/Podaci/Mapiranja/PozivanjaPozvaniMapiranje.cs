using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.Mapiranja
{
    class PozivanjaPozvaniMapiranje : ClassMap<PozivanjaPozvani>
    {
        public PozivanjaPozvaniMapiranje()
        {
            //Mapiranje tabele
            Table("PozivanjaPozvani");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "id");

            //mapiranje veza N:1 
            References(x => x.Korisnici).Column("idPozvanog").LazyLoad();
            References(x => x.Pozivi).Column("idPoziva").LazyLoad();
        }
    }
}
