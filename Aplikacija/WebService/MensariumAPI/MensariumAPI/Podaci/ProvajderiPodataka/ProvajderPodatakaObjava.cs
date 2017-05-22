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
        public static ObjavaFullDto VratiObjavu(int id)
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
            Objava o = ko.Objava;

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

            foreach (var v in ko.Prati.ToList())
            {
                ObjavaReadDto objava = new ObjavaReadDto()
                {
                    TekstObjave = v.Objava.TekstObjave,
                    ImeKorisnika = v.Objava.IdKorisnik.KorisnickoIme,
                    PrezimeKorisnika = v.Objava.IdKorisnik.Prezime,
                    IdKorisnika = v.IdKorisnika,
                    IdLokacije = v.Objava.Lokacija.IdMenza
                };

                if (v.Objava.DatumObjave != null)
                   objava.DatumObjave = (DateTime)v.Objava.DatumObjave;

                listaObjava.Add(objava);
            }

            listaObjava.OrderByDescending(x => x.DatumObjave);

            return listaObjava;
        }

    }
}