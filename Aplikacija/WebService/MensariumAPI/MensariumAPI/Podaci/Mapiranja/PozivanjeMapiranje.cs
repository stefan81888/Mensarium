using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.Mapiranja
{
    public class PozivanjeMapiranje : ClassMap<Pozivanje>
    {
        public PozivanjeMapiranje()
        {
            Table("Pozivanja");

            Id(x => x.IdPoziva, "idPoziva");

            Map(x => x.DatumPoziva, "datumPoziva");
            Map(x => x.VaziDo, "vaziDo");

            //Pozivanja -> Korisnici
            References(x => x.Pozivaoc, "idPozivaoca");

            //Pozivanja <- PozivanjePozvani (M:N+atributima)
            HasMany(x => x.Pozvani)
                .KeyColumn("idPoziva")
                .Cascade.SaveUpdate()
                .Inverse();
        }

    }
}
