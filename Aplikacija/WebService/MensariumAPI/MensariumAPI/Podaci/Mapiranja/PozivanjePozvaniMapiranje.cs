using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.Mapiranja
{
    public class PozivanjePozvaniMapiranje : ClassMap<PozivanjaPozvani>
    {
        public PozivanjePozvaniMapiranje()
        {
            Table("PozivanjaPozvani");

            CompositeId(x => x.IdPozivanjaPozvani)
                .KeyReference(x => x.IdPoziva, "idPoziva")
                .KeyReference(x => x.IdPozvanog, "idPozvanog");

            Map(x => x.OdgovorPozvanog, "odgovorPozvanog").Nullable();
            
        }
    }
}
