﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Mensarium_Desktop.Entiteti;

namespace Mensarium_Desktop.Mapiranja
{
    class ObjaveMapiranje : ClassMap<Objave>
    {
        public ObjaveMapiranje()
        {
            //Mapiranje tabele
            Table("Objave");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "idKorisnika"); 

            //Mapiranje svojstava
            Map(x => x.DatumObjave, "datumObjave");
            Map(x => x.TekstObjave, "textObjave");


            //Mapiranje veze 1:1
            HasOne(x => x.IdKorisnik).Column("idKorisnik").Cascade.All();

            //Mapiranje veze 1:N
            References(x => x.Lokacija).Column("idMenza").LazyLoad();
        }
    }
}
