using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Mensarium_Desktop.Entiteti;

namespace Mensarium_Desktop.Mapiranja
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
            References(x => x.Korisnici).Column("idKorisnik").LazyLoad();
            References(x => x.Pozivi).Column("idPoziva").LazyLoad();
        }
    }
}
