using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MensariumDesktop.Model.Components.DTOs;
using RestSharp;

namespace MensariumDesktop.Model.Controllers
{
    public static class Api
    {
        static string BaseUrl = MSettings.ServerURL + "api/";
        static string SessionID;
        
        private static T Execute<T>(RestRequest request) where T : new()
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(BaseUrl);
            //request.AddParameter("SessionId", SessionID, ParameterType.UrlSegment);

            var response = client.Execute<T>(request);
            
            //Uspensa komunikacija?
            if (response.ErrorException != null)
            {
                throw new Exception("Neuspesna komunikacija sa serverom.\n" +
                                    "Proverite internet konekciju i pokusajte ponovo.");
            }
            return response.Data;
        }

        private static HttpStatusCode Execute(RestRequest request)
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(BaseUrl);
            //request.AddParameter("SessionId", SessionID, ParameterType.UrlSegment);

            var response = client.Execute(request);
            
            //Uspesna komunikacija?
            if (response.ErrorException != null)
            {
                throw new Exception("Neuspesna komunikacija sa serverom.\n" +
                                    "Proverite internet konekciju i pokusajte ponovo.");
            }

            return response.StatusCode;
        }

        public static KorisnikFullDto GetUserFullInfo(int id)
        {
            RestRequest request = new RestRequest();
            request.Resource = "korisnici/full/{id}";
            request.AddParameter("id", id, ParameterType.UrlSegment);

            return Execute<KorisnikFullDto>(request);
        }

        public static List<KorisnikFullDto> GetUsersFullInfo()
        {
            RestRequest request = new RestRequest();
            request.Resource = "korisnici/full";

            return Execute<List<KorisnikFullDto>>(request);
        }

        public static HttpStatusCode SendUserFull(KorisnikFullDto user)
        {
            RestRequest request = new RestRequest(Method.POST);
            request.Resource = "korisnici/dodaj";
            request.AddObject(user);

            HttpStatusCode status = Execute(request);
            return status;
        }
    }
}
