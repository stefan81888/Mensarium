using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MensariumDesktop.Model.Components;
using MensariumDesktop.Model.Components.DTOs;
using RestSharp;


namespace MensariumDesktop.Model.Controllers
{
    public class ApiResponse<T> where T: new()
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public string ErrorResponse { get; set; }
        public T ResponseObject { get; set; }
    }


    public static class Api
    {
        static string BaseUrl = MSettings.Server.ServerURL + "api/";
        static string SessionID;
        
        private static ApiResponse<T> Execute<T>(RestRequest request, out T responseData, out string ServerErrorResponse) where T : new()
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(BaseUrl);
            //request.AddParameter("SessionId", SessionID, ParameterType.UrlSegment);
            var response = client.Execute(request);

            if (response.ResponseStatus != ResponseStatus.Completed) //nastala greska na mreznom nivou
            {
                string message = "Greska u komuniciranju sa serverom.\nProveri internet konekciju.\n\n" +
                    "ErrorReason: " + response.ErrorMessage;
                throw new ApplicationException(message, response.ErrorException);
            }

            //deserializacija
            try
            {
                RestSharp.Deserializers.IDeserializer deser;
                if (response.ContentType.ToLower().Contains("json"))
                    deser = new RestSharp.Deserializers.JsonDeserializer();
                else
                    deser = new RestSharp.Deserializers.XmlDeserializer();

                responseData = deser.Deserialize<T>(response);
                ServerErrorResponse = string.Empty;
            }
            catch (Exception ex) //server nije vratio trazeni objekat
            {
                responseData = default(T);
                ServerErrorResponse = response.Content;
            }
            return response.StatusCode;
        }
        private static HttpStatusCode Execute(RestRequest request)
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(BaseUrl);
            //request.AddParameter("SessionId", SessionID, ParameterType.UrlSegment);

            //debug
            //string fullrul = client.BuildUri(request).ToString();

            var response = client.Execute(request);
            if (response.ResponseStatus != ResponseStatus.Completed) //nastala greska na mreznom nivou
            {
                string message = "Greska u komuniciranju sa serverom.\nProveri internet konekciju.\n\n" +
                    "ErrorReason: " + response.ErrorMessage;
                throw new ApplicationException(message, response.ErrorException);
            }

            return response.StatusCode;
        }

        //LOGOVANJE KORISNIKA
        public static SesijaDto LoginUser(ClientLoginDto loginData)
        {
            RestRequest request = new RestRequest(Method.POST);
            request.Resource = "korisnici/prijava";
            request.AddObject(loginData);

            SesijaDto sesija;
            HttpStatusCode status = Execute<SesijaDto>(request, out sesija);

            if (status == HttpStatusCode.BadRequest)
                throw new Exception("LoginUser: Neispravno korisnicko ime ili lozinka");
            return sesija;
        }
        public static bool LogoutUser(string sessionId)
        {
            MessageBox.Show("NOT IMPLEMENTED YET");
            return true;
            RestRequest request = new RestRequest(Method.POST);
            request.Resource = "korisnici/odjava/{sessionid}";
            request.AddObject(sessionId);

            HttpStatusCode status = Execute(request);
            if (status != HttpStatusCode.OK)
                return false;
            return true;  
        }

        //KORISNICI
        public static KorisnikFullDto GetUserFullInfo(int id)
        {
            RestRequest request = new RestRequest();
            request.Resource = "korisnici/full/{id}";
            request.AddParameter("id", id, ParameterType.UrlSegment);

            KorisnikFullDto response;
            HttpStatusCode status = Execute<KorisnikFullDto>(request, out response);

            if (status == HttpStatusCode.BadRequest)
                throw new Exception("GetUserFullInfo: Neuspesno pribavljanje podataka o korisniku!");
            return response;
        }
        public static List<KorisnikFullDto> GetUsersFullInfo()
        {
            RestRequest request = new RestRequest();
            request.Resource = "korisnici/full";

            List<KorisnikFullDto> response;
            HttpStatusCode status = Execute<List<KorisnikFullDto>>(request, out response);

            if (status == HttpStatusCode.BadRequest)
                throw new Exception("GetUsersFullInfo: Neuspesno pribavljanje podatak o korisnicima!");

            return response;
        }
        public static bool SendUserFull(KorisnikFullDto user)
        {
            RestRequest request = new RestRequest(Method.POST);
            request.Resource = "korisnici/dodaj";
            request.AddObject(user);

            HttpStatusCode status = Execute(request);

            if (status != HttpStatusCode.OK)
                return false;
            return true;
        }
        public static bool AddNewUser(KorisnikDodavanjeDto u)
        {
            RestRequest request = new RestRequest(Method.POST);
            request.Resource = "korisnici/dodaj";
            request.AddObject(u);

            HttpStatusCode status = Execute(request);

            if (status != HttpStatusCode.OK)
                return false;
            return true;
        }
        //FAKULTETI
        public static bool AddNewFaculty(FakultetFullDto fax)
        {
            RestRequest request = new RestRequest(Method.POST);
            request.Resource = "fakulteti/dodaj";
            request.AddObject(fax);

            HttpStatusCode status = Execute(request);

            if (status != HttpStatusCode.OK)
                return false;
            return true;
        }
        public static bool UpdateFaculty(FakultetFullDto fax)
        {
            RestRequest request = new RestRequest(Method.PUT);
            request.Resource = "fakulteti/update";
            request.AddObject(fax);

            HttpStatusCode status = Execute(request);

            if (status != HttpStatusCode.OK)
                return false;
            return true;
        }
        public static bool DeleteFaculty(int id)
        {
            RestRequest request = new RestRequest(Method.DELETE);
            request.Resource = "fakulteti/obrisi/{id}";
            request.AddParameter("id", id, ParameterType.UrlSegment);

            HttpStatusCode status = Execute(request);

            if (status != HttpStatusCode.OK)
                return false;
            return true;
        }
        public static List<FakultetFullDto> GetAllFaculties()
        {
            RestRequest request = new RestRequest(Method.GET);
            request.Resource = "fakulteti";
            
            List<FakultetFullDto> list;
            HttpStatusCode status = Execute<List<FakultetFullDto>>(request, out list);

            if(status == HttpStatusCode.BadRequest)
                throw new Exception("GetAllFaculies: Neuspesno pribavljanje liste fakulteta");

            return list;
        }

        //MENZE
        public static List<MenzaFullDto> GetAllMensas()
        {
            RestRequest request = new RestRequest(Method.GET);
            request.Resource = "menze";

            List<MenzaFullDto> list;
            HttpStatusCode status = Execute<List<MenzaFullDto>>(request, out list);

            if (status == HttpStatusCode.BadRequest)
                throw new Exception("GetAllMensas: Neuspesno pribavljanje liste menza");

            return list;
        }

    }
}
