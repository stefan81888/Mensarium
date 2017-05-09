using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.Mapiranja
{
    class FakultetMapiranje : ClassMap<Fakultet>
    {
        public FakultetMapiranje()
        {
            //Mapiranje tabele
            Table("Fakulteti");

            //mapiranje primarnog kljuca
            Id(x => x.IdFakultet, "idFakultet"); // VAZNO: Proveriti da li dbms sam dodaje kljuc pri ovakvom mapiranju

            //mapiranje svojstava
            Map(x => x.Naziv, "naziv");

            //mapiranje veze 1:N 
            HasMany(x => x.Studenti).KeyColumn("idKorisnik").LazyLoad().Cascade.All().Inverse();

        }
    }
}
