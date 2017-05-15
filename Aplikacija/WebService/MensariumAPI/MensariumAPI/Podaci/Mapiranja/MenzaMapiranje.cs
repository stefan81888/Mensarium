using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.Mapiranja
{
    public class MenzaMapiranje : ClassMap<Menza>
    {
        public MenzaMapiranje()
        {
            Table("Menze");

            Id(x => x.IdMenza, "idMenza").GeneratedBy.Identity(); 
            
            Map(x => x.Naziv, "naziv").Not.Nullable();
            Map(x => x.Lokacija, "lokacija").Not.Nullable();
            Map(x => x.RadnoVreme, "radnoVreme");
            Map(x => x.VanrednoNeRadi, "vanrednoNeRadi").Not.Nullable();

            //Menze <- Obroci
            HasMany(x => x.ObjaveKorisnika)
                .KeyColumn("idLokacija")
                .Cascade.SaveUpdate()
                .Inverse();
            //Menze <- Obroci (lokacijaUplate)
            HasMany(x => x.Uplaceni)
                .KeyColumn("lokacijaUplate")
                .Cascade.SaveUpdate()
                .Inverse();
            //Menze <- Obroci (lokacijaIskoriscenja)
            HasMany(x => x.Iskorisceni)
                .KeyColumn("lokacijaIskoriscenja")
                .Cascade.SaveUpdate()
                .Inverse();
            }
    }
}
