using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Mensarium_Desktop.Entiteti;

namespace Mensarium_Desktop.Mapiranja
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
            References(x => x.Student).Column("idKorisnik").LazyLoad();
            References(x => x.Tip).Column("idTipObroka").LazyLoad();
            References(x => x.LokacijaUplate).Column("idMenza").LazyLoad();
            References(x => x.LokacijaIskoriscenja).Column("idMenza").LazyLoad();
        }
    }
}
