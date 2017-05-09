using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.Mapiranja
{
    class PrivilegijaMapiranje : ClassMap<Privilegija>
    {
        public PrivilegijaMapiranje()
        {
            //Mapiranje tabele
            Table("Privilegije");

            //Mapiranje primarnog kljuca
            Id(x => x.IdPrivilegije, "Privilegije.idPrivilegije"); // VAZNO: Proveriti da li dbms sam dodaje kljuc pri ovakvom mapiranju

            //mapiranje svojstava
            Map(x => x.Opis, "opis");

            //mapiranje veze M:N 
            HasManyToMany(x => x.Nalozi)
                .Table("PrivilgijeDodeljivanja")
                .ParentKeyColumn("idPrivilegije")
                .ChildKeyColumn("idTipNaloga")
                .Cascade.All();

        }
    }
}
