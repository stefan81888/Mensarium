using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.Mapiranja
{
    public class LoginSesijaMapiranje : ClassMap<LoginSesija>
    {
        public LoginSesijaMapiranje()
        {
            Table("LoginSesije");
            
            Id(x => x.IdLogin, "idLogin").GeneratedBy.Identity(); 
            
            Map(x => x.IdSesije, "idSesije").Unique().Not.Nullable();
            Map(x => x.DatumPrijavljivanja, "datumPrijavljivanja").Not.Nullable();
            Map(x => x.ValidnaDo, "ValidnaDo").Not.Nullable();

            //LoginSesija -> Korisnici
            References(x => x.KorisnikSesije).Column("idKorisnika");
        }
    }
}

