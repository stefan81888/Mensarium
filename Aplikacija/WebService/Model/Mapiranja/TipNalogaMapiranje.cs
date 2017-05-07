using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Mensarium_Desktop.Entiteti;

namespace Mensarium_Desktop.Mapiranja
{
    class TipNalogaMapiranje : ClassMap<TipNaloga>
    {
        public TipNalogaMapiranje()
        {
            //Mapiranje tabele
            Table("TipNaloga");

            //Mapiranje primarnog kljuca
            Id(x => x.IdTip, "idTip"); // VAZNO: Proveriti da li dbms sam dodaje kljuc pri ovakvom mapiranju

            //Mapiranje svojstava
            Map(x => x.Naziv, "naziv");

            //Mapiranja veza 1:N veza
            HasMany(x => x.Korisnici).KeyColumn("idKorisnik").LazyLoad().Cascade.All().Inverse();

            //Mapiranje veze M:N
            HasManyToMany(x => x.Privilegije)
                .Table("PrivilegijeDodeljivanja")
                .ParentKeyColumn("idPrivilegije")
                .ChildKeyColumn("idTipNaloga")
                .Inverse()
                .Cascade.All();

        }
    }
}
