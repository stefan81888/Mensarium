using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Mensarium_Desktop.Entiteti;

namespace Mensarium_Desktop.Mapiranja
{
    class PracenjaMapiranje : ClassMap<Pracenja>
    {
        public PracenjaMapiranje()
        {
            //Mapiranje tabele
            Table("Pracenja");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "id"); // VAZNO: Proveriti da li dbms sam dodaje kljuc pri ovakvom mapiranju

            //VAZNO: Mapiranje unarne veze
            References(x => x.Pratilac).Column("idKorisnika").LazyLoad();
            HasMany(x => x.Praceni).KeyColumn("idKorisnik").LazyLoad().Cascade.All();
        }
    }
}
