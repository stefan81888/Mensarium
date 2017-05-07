using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Mensarium_Desktop.Entiteti;
using Mensarium_Desktop.Sloj_podataka;

namespace Mensarium_Desktop.Mapiranja
{
    class MenzaMapiranje : ClassMap<Menza>
    {
        public MenzaMapiranje()
        {
            //Mapiranje tabele
            Table("Menze");

            //Mapiranje primarnog kljuca
            Id(x => x.IdMenza, "idMenza"); // VAZNO: Proveriti da li dbms sam dodaje kljuc pri ovakvom mapiranju

            //Mapiranje svojstava
            Map(x => x.Naziv, "naziv");
            Map(x => x.Lokacija, "lokacija");
            Map(x => x.RadnoVreme, "radnoVreme");
            Map(x => x.VanrednoNeRadi, "vanrednoNeRadi");

            //Mapiranje veze 1:N 
            HasMany(x => x.Lokacija).KeyColumn("idKorisnika").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Uplaceni).KeyColumn("idObrok").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Iskorisceni).KeyColumn("idObrok").LazyLoad().Cascade.All().Inverse();
        }
    }
}
