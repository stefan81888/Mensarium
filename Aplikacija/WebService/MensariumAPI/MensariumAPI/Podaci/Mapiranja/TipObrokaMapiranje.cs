using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.Mapiranja
{
    class TipObrokaMapiranje : ClassMap<TipObroka>
    {
        public TipObrokaMapiranje()
        {
            //Mapiranje tabele
            Table("TipObroka");

            //Mapiranje primarnog kljuca
            Id(x => x.IdTipObroka, "idTipObroka"); 

            //Mapiranje svojstava
            Map(x => x.Naziv, "naziv");
           
            //Mapiranje veze 1:N
            HasMany(x => x.Obroci).KeyColumn("idObrok").LazyLoad().Cascade.All().Inverse();
        }
    }
}
