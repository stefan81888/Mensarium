using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.Mapiranja
{
    public class TipObrokaMapiranje : ClassMap<TipObroka>
    {
        public TipObrokaMapiranje()
        {
            Table("TipObroka");

            Id(x => x.IdTipObroka, "idTipObroka").GeneratedBy.Identity();

            Map(x => x.Naziv, "naziv").Not.Nullable();

            //TipObroka <- Obroci
            HasMany(x => x.Obroci)
                .KeyColumn("tipObroka")
                .Cascade.SaveUpdate()
                .Inverse();
        }
    }
}
