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
        #region INTERNAL
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
        #endregion
        
        #region KORISNICI
        public static KorisnikFullDto GetUserFullInfo(int id)
        {
            RestRequest request = new RestRequest();
            request.Resource = "korisnici/full";
            request.AddParameter("id", id, ParameterType.QueryString);

            ApiResponse<KorisnikFullDto> response = Execute<KorisnikFullDto>(request);

            if (response.HttpStatusCode != HttpStatusCode.OK && response.HttpStatusCode != HttpStatusCode.Redirect)
                throw new Exception("GetUserFullInfo: Neuspesno pribavljanje podataka o korisniku!" + "\n" + response.HttpStatusCode.ToString());

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
        public static KorisnikFollowDto FollowUser(int idFollower, int idFollowing)
        {
            RestRequest request = new RestRequest(Method.GET);
            request.Resource = "zaprati/{idFollower}/{idFollowing}";
            request.AddParameter("idFollower", idFollower, ParameterType.UrlSegment);
            request.AddParameter("idFollowing", idFollowing, ParameterType.UrlSegment);

            ApiResponse<KorisnikFollowDto> response = Execute<KorisnikFollowDto>(request);

            if (response.HttpStatusCode != HttpStatusCode.OK && response.HttpStatusCode != HttpStatusCode.Redirect)
                throw new Exception("LoginUser: Neispravno korisnicko ime ili lozinka" + "\n" + response.HttpStatusCode.ToString());

            return response.ResponseObject;

        }
        public static KorisnikKreiranjeDto AddNewUser(KorisnikKreiranjeDto u)
        {
            RestRequest request = new RestRequest(Method.POST);
            request.Resource = "korisnici/dodaj";
            request.AddObject(u);

            var response = Execute<KorisnikKreiranjeDto>(request);
            if (response.HttpStatusCode != HttpStatusCode.OK && response.HttpStatusCode != HttpStatusCode.Redirect)
                throw new Exception("LoginUser: Neispravno korisnicko ime ili lozinka" + "\n" + response.HttpStatusCode.ToString());

            return response.ResponseObject;
        }
        public static KorisnikFullDto AndroidUserRegistration(ClientZaRegistracijuDto c)
        {
            RestRequest request = new RestRequest(Method.PUT);
            request.Resource = "korisnici/update";
            request.AddObject(c);

            var response = Execute<KorisnikFullDto>(request);
            if (response.HttpStatusCode != HttpStatusCode.OK && response.HttpStatusCode != HttpStatusCode.Redirect)
                throw new Exception("LoginUser: Neispravno korisnicko ime ili lozinka" + "\n" + response.HttpStatusCode.ToString());

            return response.ResponseObject;
        }
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
        //public static List<KorisnikFollowDto> UsersThatFollows(int userId)
        //{
        //    RestRequest request = new RestRequest(Method.GET);
        //    request.Resource = "pracenja";
        //    request.AddParameter("id", userId, ParameterType.QueryString);

        //    request
        //}
        public static bool LogoutUser(string sessionId)
        {
            RestRequest request = new RestRequest(Method.PUT);
            request.Resource = "korisnici/odjava";

            ApiResponse<object> response = Execute(request);
            return (response.HttpStatusCode == HttpStatusCode.OK || response.HttpStatusCode == HttpStatusCode.Redirect);
        }

        #endregion

        #region FAKULTETI
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

            if (response.HttpStatusCode != HttpStatusCode.OK && response.HttpStatusCode != HttpStatusCode.Redirect)
                throw new Exception("GetAllFaculies: Neuspesno pribavljanje liste fakulteta");

            return response.ResponseObject;
        }
        public static FakultetFullDto GetFacultyInfo(int id)
        {
            RestRequest request = new RestRequest(Method.GET);
            request.Resource = "fakulteti";
            request.AddParameter("id", id, ParameterType.QueryString);

            ApiResponse<FakultetFullDto> response = Execute<FakultetFullDto>(request);
            if (response.HttpStatusCode != HttpStatusCode.OK && response.HttpStatusCode != HttpStatusCode.Redirect)
                throw new Exception("GetFacultyInfo: Neuspesno pribavljanje informacije o fakultetu");

            return response.ResponseObject;
        }
        #endregion

        #region MENZE
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
        public static int CrowdInPaymentCounter(int id)
        {
            RestRequest request = new RestRequest(Method.GET);
            request.Resource = "menze/guzvaUplata";
            request.AddParameter("id", id, ParameterType.QueryString);

            ApiResponse<int> response = Execute<int>(request);
            if (response.HttpStatusCode != HttpStatusCode.OK && response.HttpStatusCode != HttpStatusCode.Redirect)
                throw new Exception("CrowdInPaymentCounter: Neuspesno pribavljanje informacije o guzvi na salteru");

            return response.ResponseObject;

        }
        public static bool UpdateMenza(MenzaFullDto m)
        {
            throw new Exception("Not implemented on server");
            RestRequest request = new RestRequest(Method.PUT);
            request.AddObject(m);

            var response = Execute(request);
            return (response.HttpStatusCode == HttpStatusCode.OK || response.HttpStatusCode == HttpStatusCode.Redirect);
        }
        #endregion

        #region OBROCI
        public static ObrokFullDto GetMealInfo(int id)
        {
            RestRequest request = new RestRequest(Method.GET);
            request.Resource = "obroci";
            request.AddParameter("id", id, ParameterType.QueryString);

            ApiResponse<ObrokFullDto> response = Execute<ObrokFullDto>(request);
            if (response.HttpStatusCode != HttpStatusCode.OK && response.HttpStatusCode != HttpStatusCode.Redirect)
                throw new Exception("GetMeal: Neuspesno pribavljanje informacije o obroku");

            return response.ResponseObject;
        }
        public static List<ObrokFullDto> GetAllMealsInfo()
        {
            RestRequest request = new RestRequest(Method.GET);
            request.Resource = "obroci";

            ApiResponse<List<ObrokFullDto>> response = Execute<List<ObrokFullDto>>(request);
            if (response.HttpStatusCode != HttpStatusCode.OK && response.HttpStatusCode != HttpStatusCode.Redirect)
                throw new Exception("GetAllMeals: Neuspesno pribavljanje informacije o obrocima");

            return response.ResponseObject;
        }
        public static bool AddMeal(ObrokUplataDto meal)
        {
            RestRequest request = new RestRequest(Method.POST);
            request.Resource = "obroci/uplati";
            request.AddObject(meal);

            var response = Execute(request);
            return (response.HttpStatusCode == HttpStatusCode.OK || response.HttpStatusCode == HttpStatusCode.Redirect);
        }
        public static bool UseMeal(ObrokNaplataDto m)
        {
            RestRequest request = new RestRequest(Method.PUT);
            request.Resource = "obroci/naplati";
            request.AddObject(m);

            var response = Execute(request);
            return (response.HttpStatusCode == HttpStatusCode.OK || response.HttpStatusCode == HttpStatusCode.Redirect);
        }
        public static List<ObrokDanasUplacenDto> TodayAddedMeals(int mealTypeId)
        {
            RestRequest request = new RestRequest(Method.GET);
            request.Resource = "obroci/danasUplaceni";
            request.AddParameter("id", mealTypeId, ParameterType.QueryString);

            ApiResponse<List<ObrokDanasUplacenDto>> response = Execute<List<ObrokDanasUplacenDto>>(request);
            if (response.HttpStatusCode != HttpStatusCode.OK && response.HttpStatusCode != HttpStatusCode.Redirect)
                throw new Exception("TodayAddedMeals: Neuspesno pribavljanje informacije o obrocima");

            return response.ResponseObject;
        }
        public static List<ObrokDanasSkinutDto> TodayUsedMeals(int mealTypeId)
        {
            RestRequest request = new RestRequest(Method.GET);
            request.Resource = "obroci/danasSkinuti";
            request.AddParameter("id", mealTypeId, ParameterType.QueryString);

            ApiResponse<List<ObrokDanasSkinutDto>> response = Execute<List<ObrokDanasSkinutDto>>(request);
            if (response.HttpStatusCode != HttpStatusCode.OK && response.HttpStatusCode != HttpStatusCode.Redirect)
                throw new Exception("TodayAddedMeals: Neuspesno pribavljanje informacije o obrocima");

            return response.ResponseObject;
        }
        public static bool UndoUseMeals(int[] mealsId) //netestirano
        {
            RestRequest request = new RestRequest(Method.PUT);
            request.Resource = "obroci/vratiPogresnoSkinute";
            request.AddObject(mealsId);

            var response = Execute(request);
            return (response.HttpStatusCode == HttpStatusCode.OK || response.HttpStatusCode == HttpStatusCode.Redirect);
        }
        public static bool UndoAddMeals(int[] mealsId) //netestirano
        {
            RestRequest request = new RestRequest(Method.PUT);
            request.Resource = "obroci/skiniPogresnoUplacene";
            request.AddObject(mealsId);

            var response = Execute(request);
            return (response.HttpStatusCode == HttpStatusCode.OK || response.HttpStatusCode == HttpStatusCode.Redirect);
        }
        #endregion
    }
}
