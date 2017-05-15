using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.Mapiranja
{
    public class FakultetMapiranje : ClassMap<Fakultet>
    {
        public FakultetMapiranje()
        {
            Table("Fakulteti");

            Id(x => x.IdFakultet, "idFakultet").GeneratedBy.Identity();

            Map(x => x.Naziv, "naziv").Not.Nullable().Unique();

            //Fakultet -> Korisnici
            HasMany(x => x.Studenti)
                .KeyColumn("fakultet")
                .Cascade.SaveUpdate()
                .Inverse();
            
        }
    }
}
