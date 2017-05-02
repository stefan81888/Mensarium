using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Mensarium_Desktop.Entiteti;

namespace Mensarium_Desktop.Mapiranja
{
    class LoginSesijeMapiranje : ClassMap<LoginSesije>
    {
        public LoginSesijeMapiranje()
        {
            //Mapiranje tabele
            Table("LoginSesije");

            //mapiranje primarnog kljuca
            Id(x => x.IdLogin,"idLogin"); // VAZNO: Proveriti da li dbms sam dodaje kljuc pri ovakvom mapiranju

            //mapiranje svojstava
            Map(x => x.IdSesije, "idSesije");
            Map(x => x.DatumPrijavljivanja, "datumPrijavljivanja");
            Map(x => x.ValidnaDo, "ValidnoDo");

            //Mapiranje veze N:1 
            References(x => x.KorisnikSesije).Column("idKorisnik").LazyLoad();
        }
    }
}
