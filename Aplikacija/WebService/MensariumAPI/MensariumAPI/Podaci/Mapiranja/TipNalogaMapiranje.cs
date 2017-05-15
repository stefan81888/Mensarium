using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.Mapiranja
{
    public class TipNalogaMapiranje : ClassMap<TipNaloga>
    {
        public TipNalogaMapiranje()
        {
            Table("TipNaloga");

            Id(x => x.IdTip, "idTip").GeneratedBy.Identity();

            Map(x => x.Naziv, "naziv").Not.Nullable().Unique();

            //TipNaloga <- Korisnici
            HasMany(x => x.Korisnici).KeyColumn("tipNaloga")
                .Cascade.SaveUpdate()
                .Inverse();

            //TipNaloga <-> Privilegija M:N
            HasManyToMany(x => x.Privilegije)
                .Table("PrivilegijeDodeljivanja")
                .ParentKeyColumn("idTipNaloga")
                .ChildKeyColumn("idPrivilegije")
                .Cascade.SaveUpdate();

        }
    }
}
