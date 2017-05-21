using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.DTO;
using MensariumAPI.Podaci.Entiteti;
using NHibernate;

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
    }
}