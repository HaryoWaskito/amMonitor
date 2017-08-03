using FlexerApp.Models;
using RestSharp;
using System;
using System.Text;

namespace FlexerApp.Controllers
{
    public class Controller
    {
        public bool LoginToServer(LoginModel login)
        {
            bool isSuccessLogin = false;
            try
            {
                var requestBody = new StringBuilder();
                var client = new RestClient("http://35.186.145.215:2345/login");
                var request = new RestRequest(Method.POST);

                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/x-www-form-urlencoded");

                requestBody.AppendFormat("\"Email\" : \"{0}\",", login.Email);
                requestBody.AppendFormat("\"Password\" : \"{0}\",", login.Password);
                requestBody.AppendFormat("\"LocationType\" : \"{0}\",", login.LocationType);
                requestBody.AppendFormat("\"IPAddress\" : \"{0}\",", login.IPAddress);
                requestBody.AppendFormat("\"City\" : \"{0}\",", login.City);
                requestBody.AppendFormat("\"Lat\" : {0},", login.Lat);
                requestBody.AppendFormat("\"Long\" : {0}", login.Long);

                request.AddParameter("application/json", string.Concat("{", requestBody.ToString(), "}"), ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);
                isSuccessLogin = response.StatusCode.ToString() == "OK" ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return isSuccessLogin;
        }      
    }
}
