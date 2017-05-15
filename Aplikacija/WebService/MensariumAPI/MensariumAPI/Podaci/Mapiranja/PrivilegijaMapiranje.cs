using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.Mapiranja
{
    public class PrivilegijaMapiranje : ClassMap<Privilegija>
    {
        public PrivilegijaMapiranje()
        {
            Table("Privilegije");

            Id(x => x.IdPrivilegije, "idPrivilegije").GeneratedBy.Identity();

            Map(x => x.Opis, "opis");

            //Privilegija <-> TipNaloga M:N
            HasManyToMany(x => x.Nalozi)
                .Table("PrivilegijeDodeljivanja")
                .ParentKeyColumn("idPrivilegije")
                .ChildKeyColumn("idTipNaloga")
                .Inverse()
                .Cascade.SaveUpdate();

        }
    }
}
