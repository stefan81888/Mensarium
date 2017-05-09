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
            //Mapiranje tabele
            Table("Korisnici");

            //Mapiranje primarnog kljuca
            Id(x => x.IdKorisnika, "idKorisnik"); // VAZNO: Proveriti da li dbms sam dodaje kljuc pri ovakvom mapiranju

            //Mapiranje svojstava
            Map(x => x.KorisnickoIme, "korisnickoIme");
            Map(x => x.Email, "email");
            Map(x => x.Sifra, "lozinka");
            Map(x => x.Ime, "ime");
            Map(x => x.Prezime, "prezime");
            Map(x => x.DatumRodjenja, "datumRodjenja");
            Map(x => x.DatumRegistracije, "datumRegistracije");
            Map(x => x.DatumVaziDo, "datumVaziDo");
            Map(x => x.BrojIndeksa, "brojIndeksa");
            Map(x => x.BrojTelefona, "brojTelefona");
            Map(x => x.AktivanNalog, "aktivanNalog");

            //Mapiranje veze 1:1
            HasOne(x => x.Objava);

            //Mapiranje veza N:1
            References(x => x.PrivilegijeNaloga).Column("tipNaloga").LazyLoad();
            References(x => x.StudiraFakultet).Column("fakultet").LazyLoad();

            //Mapiranje veza 1:N
            HasMany(x => x.Sesije).KeyColumn("idLogin").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Pozivi).KeyColumn("idPoziva").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Pozvani).KeyColumn("id").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Obroci).KeyColumn("idObrok").LazyLoad().Cascade.All().Inverse();
        }
    }
}
