using MensariumAPI.Podaci.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace MensariumAPI.Podaci.ProvajderiPodataka
{
    public class ProvajderPodatakaSlike
    {
        public static HttpResponseMessage VratiSliku(int id)
        {
            
            string FileName = string.Format("~/App_Data/SlikeKorisnika/{0}.jpg", id);
            if (!System.IO.File.Exists(HttpContext.Current.Server.MapPath(FileName)))
                FileName = string.Format("~/App_Data/SlikeKorisnika/{0}.jpg", "default");
            try
            {
                byte[] Slika = System.IO.File.ReadAllBytes(HttpContext.Current.Server.MapPath(FileName));
                var result = new HttpResponseMessage(HttpStatusCode.OK);
                result.Content = new ByteArrayContent(Slika);
                result.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpg");
                return result;
            }
            catch(Exception e)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                    { Content = new StringContent("ServerGreska: Neuspelo pribavljanje slike") };
            }
        }

        public static string PostaviSliku(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            Korisnik k = ProvajderPodatakaKorisnika.VratiKorisnika(id);
            k.Slika = k.IdKorisnika + ".jpg";
            s.Save(k);
            s.Flush();
            return k.Slika;
        }
    }
}