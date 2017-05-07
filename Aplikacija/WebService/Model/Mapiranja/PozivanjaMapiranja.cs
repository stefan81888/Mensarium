using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Mensarium_Desktop.Entiteti;

namespace Mensarium_Desktop.Mapiranja
{
    class PozivanjaMapiranja : ClassMap<Pozivanja>
    {
        public PozivanjaMapiranja()
        {
            //Mapiranje tabele
            Table("Pozivanja");

            //mapiranje primarnog kljuca
            Id(x => x.IdPoziva, "idPoziva"); // VAZNO: Proveriti da li dbms sam dodaje kljuc pri ovakvom mapiranju

            //mapiranje svojstava
            Map(x => x.VremeTrajanja, "vremeTrajanja");
            Map(x => x.DatumPoziva, "datumPoziva");

            //mapranja veze N:1  
            HasMany(x => x.Pozvani).KeyColumn("id").LazyLoad().Cascade.All().Inverse();

            //mapiranje veze 1:N 
            References(x => x.Poziva).Column("idKorisnik").LazyLoad();
        }
    }
}
