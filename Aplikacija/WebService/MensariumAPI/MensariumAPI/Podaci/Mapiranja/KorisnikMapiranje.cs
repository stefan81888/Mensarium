using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.Mapiranja
{
    public class KorisnikMapiranje : ClassMap<Korisnik>
    {
        KorisnikMapiranje()
        {
            
            Table("Korisnici");
            Id(x => x.IdKorisnika, "idKorisnik").GeneratedBy.Identity();

            Map(x => x.KorisnickoIme, "korisnickoIme").Unique();
            Map(x => x.Email, "email").Unique();
            Map(x => x.Sifra, "lozinka").Not.Nullable();
            Map(x => x.Ime, "ime").Not.Nullable();
            Map(x => x.Prezime, "prezime").Not.Nullable();
            Map(x => x.DatumRodjenja, "datumRodjenja").Not.Nullable();
            Map(x => x.DatumRegistracije, "datumRegistracije").Not.Nullable();
            Map(x => x.DatumVaziDo, "datumVaziDo");
            Map(x => x.BrojIndeksa, "brojIndeksa");
            Map(x => x.BrojTelefona, "brojTelefona");
            Map(x => x.AktivanNalog, "aktivanNalog").Not.Nullable();
            Map(x => x.Slika, "slika");
            Map(x => x.Obrisan, "obrisan").Not.Nullable();
            
            //Korisnik <- Objave
            HasOne(x => x.Objava)
                .PropertyRef(x=> x.IdKorisnik);
            //Korisnik -> TipNaloga
            References(x => x.TipNaloga).Column("tipNaloga");
            //Korisnik -> Fakulteti
            References(x => x.StudiraFakultet).Column("fakultet");
            //Korisnik -> Korisnik
            HasManyToMany(x => x.Prati)
                .ParentKeyColumn("idPratilac")
                .ChildKeyColumn("idPraceni")
                .Table("Pracenja")
                .Cascade.SaveUpdate();
            //Korisnik <- Korisnik
            HasManyToMany(x => x.PracenOd)
                .ParentKeyColumn("idPraceni")
                .ChildKeyColumn("idPratilac")
                .Table("Pracenja")
                .Inverse()
                .Cascade.SaveUpdate();
            //Korisnik <- LoginSesije
            HasMany(x => x.Sesije)
                .KeyColumn("idKorisnika")
                .Cascade.All() //kad se obrise korisnik -> brisi sve sesije
                .Inverse();
            //Korisnik <- Pozivanja
            HasMany(x => x.Pozivi)
                .KeyColumn("idPozivaoca")
                .Cascade.All() //kad se obrise korisnik -> brisi sva pozivanja
                .Inverse();
            //Korisnik <-- PozivanjaPozvani
            HasMany(x => x.PozivanjaOd)
                .KeyColumn("idPozvanog")
                .Cascade.SaveUpdate() //TO-DO: PROVERI
                .Inverse();
            //Korisnik <- Obroci
            HasMany(x => x.Obroci)
                .KeyColumn("idUplatioca")
                .Cascade.SaveUpdate()
                .Inverse();
        }
    }
}
