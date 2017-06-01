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
    
    public static class Api
    {
        private class ApiResponse<T>
        {
            public HttpStatusCode HttpStatusCode { get; set; }
            public string ErrorResponse { get; set; }
            public T ResponseObject { get; set; }
        }
        static string BaseUrl = MSettings.Server.ServerURL + "api/";
               
        private static ApiResponse<T> Execute<T>(RestRequest request, bool includeSid = true) where T : new()
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(BaseUrl);

            if (includeSid)
                request.AddQueryParameter("sid", MSettings.CurrentSession.SessionID);
                
            Console.WriteLine("RequestedURL: " + client.BuildUri(request).ToString());

            var response = client.Execute(request);

            if (response.ResponseStatus != ResponseStatus.Completed) //nastala greska na mreznom nivou
            {
                string message = "Greska u komuniciranju sa serverom.\nProveri internet konekciju.\n\n" +
                                 "ErrorReason: " + response.ErrorMessage;
                throw new ApplicationException(message, response.ErrorException);
            }

            ApiResponse<T> executeResut = new ApiResponse<T>();
            //deserializacija
            try
            {
                RestSharp.Deserializers.IDeserializer deser;
                if (response.ContentType.ToLower().Contains("json"))
                    deser = new RestSharp.Deserializers.JsonDeserializer();
                else
                    deser = new RestSharp.Deserializers.XmlDeserializer();

                executeResut.ResponseObject = deser.Deserialize<T>(response);
                executeResut.ErrorResponse = string.Empty;
                executeResut.HttpStatusCode = response.StatusCode;
            }
            catch (Exception ex) //server nije vratio trazeni objekat
            {
                executeResut.ResponseObject = default(T);
                executeResut.ErrorResponse = response.Content;
                executeResut.HttpStatusCode = response.StatusCode;
            }
            return executeResut;
        }
        private static ApiResponse<object> Execute(RestRequest request, bool includeSid = true)
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(BaseUrl);
            if (includeSid)
                request.AddQueryParameter("sid", MSettings.CurrentSession.SessionID);

            //debug
            Console.WriteLine("ExecuteURL " + client.BuildUri(request).ToString());

            var response = client.Execute(request);
            if (response.ResponseStatus != ResponseStatus.Completed) //nastala greska na mreznom nivou
            {
                string message = "Greska u komuniciranju sa serverom.\nProveri internet konekciju.\n\n" +
                    "ErrorReason: " + response.ErrorMessage;
                throw new ApplicationException(message, response.ErrorException);
            }

            ApiResponse<object> executeResult = new ApiResponse<object>();
            executeResult.ResponseObject = null;
            executeResult.HttpStatusCode = response.StatusCode;
            executeResult.ErrorResponse = response.Content;
            return executeResult;

        }

        //LOGOVANJE KORISNIKA
        public static SesijaDto LoginUser(ClientLoginDto loginData)
        {
            RestRequest request = new RestRequest(Method.POST);
            request.Resource = "korisnici/prijava";
            request.AddObject(loginData);
            
            ApiResponse<SesijaDto> response = Execute<SesijaDto>(request, false);
            
            if (response.HttpStatusCode != HttpStatusCode.OK && response.HttpStatusCode != HttpStatusCode.Redirect)
                throw new Exception("LoginUser: Neispravno korisnicko ime ili lozinka" + "\n" + response.HttpStatusCode.ToString());

            return response.ResponseObject;
        }
        public static bool LogoutUser(string sessionId)
        {
            RestRequest request = new RestRequest(Method.PUT);
            request.Resource = "korisnici/odjava";
            
            ApiResponse<object> response = Execute(request);
            return (response.HttpStatusCode == HttpStatusCode.OK || response.HttpStatusCode == HttpStatusCode.Redirect);
        }

        //KORISNICI
        public static KorisnikFullDto GetUserFullInfo(int id)
        {
            RestRequest request = new RestRequest();
            request.Resource = "korisnici/full";
            request.AddParameter("id", id, ParameterType.QueryString);

            ApiResponse<KorisnikFullDto> response = Execute<KorisnikFullDto>(request);

            if (response.HttpStatusCode != HttpStatusCode.OK && response.HttpStatusCode != HttpStatusCode.Redirect)
                throw new Exception("GetUserFullInfo: Neuspesno pribavljanje podataka o korisniku!" +"\n" + response.HttpStatusCode.ToString());

            return response.ResponseObject;
        }
        public static List<KorisnikFullDto> GetUsersFullInfo()
        {
            RestRequest request = new RestRequest();
            request.Resource = "korisnici/full";

            ApiResponse<List<KorisnikFullDto>> response = Execute<List<KorisnikFullDto>>(request);

            if (response.HttpStatusCode != HttpStatusCode.OK && response.HttpStatusCode != HttpStatusCode.Redirect)
                throw new Exception("GetUsersFullInfo: Neuspesno pribavljanje podatak o korisnicima!" + "\n" + response.HttpStatusCode.ToString());

            return response.ResponseObject;
        }
        public static bool SendUserFull(KorisnikFullDto user)
        {
            RestRequest request = new RestRequest(Method.POST);
            request.Resource = "korisnici/dodaj";
            request.AddObject(user);

            var response = Execute(request);
            return (response.HttpStatusCode == HttpStatusCode.OK || response.HttpStatusCode == HttpStatusCode.Redirect);
        }
        public static bool AddNewUser(KorisnikDodavanjeDto u)
        {
            RestRequest request = new RestRequest(Method.POST);
            request.Resource = "korisnici/dodaj";
            request.AddObject(u);

            var response = Execute(request);
            return (response.HttpStatusCode == HttpStatusCode.OK || response.HttpStatusCode == HttpStatusCode.Redirect);
        }
        //FAKULTETI
        public static bool AddNewFaculty(FakultetFullDto fax)
        {
            RestRequest request = new RestRequest(Method.POST);
            request.Resource = "fakulteti/dodaj";
            request.AddObject(fax);

            var response = Execute(request);
            return (response.HttpStatusCode == HttpStatusCode.OK || response.HttpStatusCode == HttpStatusCode.Redirect);

        }
        public static bool UpdateFaculty(FakultetFullDto fax)
        {
            RestRequest request = new RestRequest(Method.PUT);
            request.Resource = "fakulteti/update";
            request.AddObject(fax);

            var response = Execute(request);
            return (response.HttpStatusCode == HttpStatusCode.OK || response.HttpStatusCode == HttpStatusCode.Redirect);
        }
        public static bool DeleteFaculty(int id)
        {
            RestRequest request = new RestRequest(Method.DELETE);
            request.Resource = "fakulteti/obrisi";
            request.AddParameter("id", id, ParameterType.QueryString);

            var response = Execute(request);
            return (response.HttpStatusCode == HttpStatusCode.OK);
        }
        public static List<FakultetFullDto> GetAllFaculties()
        {
            RestRequest request = new RestRequest(Method.GET);
            request.Resource = "fakulteti";
            
            ApiResponse<List<FakultetFullDto>> response = Execute<List<FakultetFullDto>>(request);

            if(response.HttpStatusCode != HttpStatusCode.OK && response.HttpStatusCode != HttpStatusCode.Redirect)
                throw new Exception("GetAllFaculies: Neuspesno pribavljanje liste fakulteta");
      
            return response.ResponseObject;
        }

        //MENZE
        public static List<MenzaFullDto> GetAllMensas()
        {
            RestRequest request = new RestRequest(Method.GET);
            request.Resource = "menze";

            ApiResponse<List<MenzaFullDto>> response = Execute<List<MenzaFullDto>>(request);

            if (response.HttpStatusCode != HttpStatusCode.OK && response.HttpStatusCode != HttpStatusCode.Redirect)
                throw new Exception("GetAllMensas: Neuspesno pribavljanje liste menza");

            return response.ResponseObject;
        }
        public static MenzaFullDto GetMensaInfo(int id)
        {
            RestRequest request = new RestRequest(Method.GET);
            request.Resource = "menze";
            request.AddParameter("id", id, ParameterType.QueryString);

            ApiResponse<MenzaFullDto> response = Execute<MenzaFullDto>(request);
            if (response.HttpStatusCode != HttpStatusCode.OK && response.HttpStatusCode != HttpStatusCode.Redirect)
                throw new Exception("GetMensas: Neuspesno pribavljanje informacije o menzi");

            return response.ResponseObject;
        }
        public static bool AddNewMensa(MenzaFullDto m)
        {
            RestRequest request = new RestRequest(Method.POST);
            request.Resource = "menze/dodaj";
            request.AddObject(m);

            var response = Execute(request);
            return (response.HttpStatusCode == HttpStatusCode.OK || response.HttpStatusCode == HttpStatusCode.Redirect);
        }
        public static bool DeleteMensa(int id)
        {
            throw new Exception("Not implemented on server");
            RestRequest request = new RestRequest(Method.DELETE);
            request.Resource = "menze/obrisi";
            request.AddParameter("id", id, ParameterType.QueryString);

            var response = Execute(request);
            return (response.HttpStatusCode == HttpStatusCode.OK || response.HttpStatusCode == HttpStatusCode.Redirect);
        }
        public static int CrowdInMensa(int id)
        {
            RestRequest request = new RestRequest(Method.GET);
            request.Resource = "menze/guzvaMenza";
            request.AddParameter("id", id, ParameterType.QueryString);

            ApiResponse<int> response = Execute<int>(request);
            if (response.HttpStatusCode != HttpStatusCode.OK && response.HttpStatusCode != HttpStatusCode.Redirect)
                throw new Exception("CrowdInMensa: Neuspesno pribavljanje informacije o guzvi u menzi");

            return response.ResponseObject;

        }
        public static int CrowdInPaymentCounter (int id)
        {
            RestRequest request = new RestRequest(Method.GET);
            request.Resource = "menze/guzvaUplata";
            request.AddParameter("id", id, ParameterType.QueryString);

            ApiResponse<int> response = Execute<int>(request);
            if (response.HttpStatusCode != HttpStatusCode.OK && response.HttpStatusCode != HttpStatusCode.Redirect)
                throw new Exception("CrowdInPaymentCounter: Neuspesno pribavljanje informacije o guzvi na salteru");

            return response.ResponseObject;

        }
    }
}
