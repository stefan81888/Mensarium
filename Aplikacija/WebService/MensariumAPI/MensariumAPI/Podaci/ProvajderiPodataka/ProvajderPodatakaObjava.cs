using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.DTO;
using MensariumAPI.Podaci.Entiteti;
using NHibernate;
using NHibernate.Linq;

namespace MensariumAPI.Podaci.ProvajderiPodataka
{
    public class ProvajderPodatakaObjava
    {
        public static ObjavaFullDto VratiObjavuDto(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            Korisnik k = s.Load<Korisnik>(id);
            Objava o = k.Objava;
            ObjavaFullDto odto = new ObjavaFullDto()
            {
                IdObjave = o.IdObjave,
                IdKorisnika = o.IdKorisnik.IdKorisnika,
                IdLokacije = o.Lokacija.IdMenza,
                TekstObjave = o.TekstObjave,
                DatumObjave = o.DatumObjave.Value
            };

            return odto;
        }

        public static ObjavaCUDto Objavi(int id , ObjavaCUDto ocudto)
        {
           
            ISession s = SesijeProvajder.Sesija;
            Korisnik ko = s.Load<Korisnik>(id);

            Objava o;
            if (ko.Objava != null)
            {
                o = ko.Objava;
            }
            else
            {
                o = NapraviObjavu(ko);
            }

            List<Menza> menze = s.Query<Menza>().Select(k => k).ToList();


            Menza m = (from k in menze
                where k.IdMenza == ocudto.IdLokacije
                select k) as Menza;


            o.TekstObjave = ocudto.TekstObjave;
            o.Lokacija = m;

            s.Save(m);
            s.Flush();

            return ocudto;
        }

        public static List<ObjavaReadDto> SveObjave(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            Korisnik ko = s.Load<Korisnik>(id);

            List<ObjavaReadDto> listaObjava = new List<ObjavaReadDto>();

            List<Korisnik> lista = ko.Prati.ToList();

            foreach (var v in lista )
            {
                ObjavaReadDto objava = new ObjavaReadDto()
                {
                    TekstObjave = v.Objava.TekstObjave,
                    ImeKorisnika = v.Objava.IdKorisnik.KorisnickoIme,
                    PrezimeKorisnika = v.Objava.IdKorisnik.Prezime,
                    IdKorisnika = v.IdKorisnika,
                    IdLokacije = v.Objava.Lokacija.IdMenza
                };

                if (v.Objava.DatumObjave.HasValue)
                   objava.DatumObjave = v.Objava.DatumObjave.Value;

                listaObjava.Add(objava);
            }

           listaObjava.Sort((x,y) => y.DatumObjave.CompareTo(x.DatumObjave));

            return listaObjava;
        }

        public static Objava NapraviObjavu(Korisnik ko) 
        {
            ISession s = SesijeProvajder.Sesija;

            Objava o = new Objava()
            {
                IdKorisnik = ko
            };

            s.Save(ko);
            s.Save(o);
            s.Flush();

            List<Objava> lista = s.Query<Objava>().Select(k => k).ToList();

            Objava ob = (from l in lista
                where l.IdKorisnik == ko
                select l) as Objava;

            s.Close();

            return ob;
        }

        public static Objava VrtatiObjavu(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            Objava o = s.Load<Objava>(id);

            s.Close();

            return o;
        }

        

    }
}