using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Mensarium.Components;
using MensariumDesktop.Model.Components.DTOs;
using RestSharp;

namespace Mensarium.Api
{
    public static class Api
    {
        //static string BaseUrl = MSettings.Server.ServerURL + "api/";
        static string BaseUrl = "http://d1190e1d.ngrok.io/api/";

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

        private static HttpStatusCode Execute<T>(RestRequest request, out T responseData) where T : new()
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(BaseUrl);
            //request.AddParameter("SessionId", SessionID, ParameterType.UrlSegment);
            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                string message = "Greska u komuniciranju sa serverom. Proveri internet konekciju.\n\n" + response.ErrorMessage;
                var Exception = new ApplicationException(message, response.ErrorException);
                throw Exception;
            }

            responseData = response.Data;
            return response.StatusCode;
        }

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

        public static List<FakultetFullDto> GetAllFaculties()
        {
            RestRequest request = new RestRequest(Method.GET);
            request.Resource = "fakulteti";

            List<FakultetFullDto> list;
            HttpStatusCode status = Execute<List<FakultetFullDto>>(request, out list);

            if (status == HttpStatusCode.BadRequest)
                throw new Exception("GetAllFaculies: Neuspesno pribavljanje liste fakulteta");

            return list;
        }
    }
}