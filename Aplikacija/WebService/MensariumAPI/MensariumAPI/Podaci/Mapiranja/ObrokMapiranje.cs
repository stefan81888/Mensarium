using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.Mapiranja
{
    public class ObrokMapiranje : ClassMap<Obrok>
    {
        public ObrokMapiranje()
        {
            Table("Obroci");

            Id(x => x.IdObroka, "idObrok").GeneratedBy.Identity();
            Map(x => x.Iskoriscen, "iskoriscen").Not.Nullable();
            Map(x => x.DatumIskoriscenja, "datumIskoriscenja");
            Map(x => x.DatumUplacivanja, "datumUplacivanja").Not.Nullable();

            //Obroci -> Korisnici
            References(x => x.Uplatilac).Column("idUplatioca");
            //Obroci -> TipObroka
            References(x => x.Tip).Column("tipObroka");
            //Obroci -> Menze
            References(x => x.LokacijaUplate).Column("lokacijaUplate");
            //Obroci -> Menze
            References(x => x.LokacijaIskoriscenja).Column("lokacijaIskoriscenja");
        }
    }
}
