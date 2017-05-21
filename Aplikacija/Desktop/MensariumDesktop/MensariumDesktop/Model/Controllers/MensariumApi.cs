using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MensariumDesktop.Model.Components.DTOs;
using RestSharp;

namespace MensariumDesktop.Model.Controllers
{
    public static class MensariumApi
    {
        static string BaseUrl = MensariumConfig.ServerURL + "api/";
        //static string SessionID = MensariumConfig.LoggedUser.SessionID;

        public static T Execute<T>(RestRequest request) where T : new()
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(BaseUrl);
            //request.AddParameter("SessionId", SessionID, ParameterType.UrlSegment);

            var response = client.Execute<T>(request);
            
            //Da li je uspeno zahtev dostavljen i odgovoren
            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var MensariumException = new ApplicationException(message, response.ErrorException);
                throw MensariumException;
            }

            return response.Data;
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
    }
}
