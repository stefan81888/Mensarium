using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.Mapiranja
{
    class ObrokMapiranje : ClassMap<Obrok>
    {
        public ObrokMapiranje()
        {
            //Mapiranje tabele
            Table("Obroci");

            //Mapiranje primarnog kljuca
            Id(x => x.IdObroka, "idObrok"); // VAZNO: Proveriti da li dbms sam dodaje kljuc pri ovakvom mapiranju

            //Mapiranje svojstava
            Map(x => x.Iskoriscen, "iskoriscen");
            Map(x => x.DatumIskoriscenja, "datumIskoriscenja");
            Map(x => x.DatumUplacivanja, "datumUplacivanja");

            //Mapiranje veze N:1
            References(x => x.Student).Column("idUplatioca").LazyLoad();
            References(x => x.Tip).Column("tipObroka").LazyLoad();
            References(x => x.LokacijaUplate).Column("lokacijaUplate").LazyLoad();
            References(x => x.LokacijaIskoriscenja).Column("lokacijaIskoriscenja").LazyLoad();
        }
    }
}
