using RestSharp;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConventionalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
            try
            {
                var login = new LoginModel();

                login.Email = "karjo@gmail.com";// EmailControl.Text;
                login.Password = "tes123";//PasswordControl.Text; // Masa gara- gara isi password-nya test123 (ada "t"-nya returnnya syntax error)
                login.LocationType = "GPS";
                login.IPAddress = "172.16.80.88";
                login.City = "Jakarta";
                login.Lat = float.Parse("0.0");
                login.Long = float.Parse("0.0");

                var requestBody = new StringBuilder();
                var client = new RestClient("http://35.186.145.215:2345/login");
                var request = new RestRequest(Method.POST);
                //request.AddHeader("postman-token", "c851c8b6-b19e-147f-4b50-ed29d327b36b");
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

        //static async Task<Uri> TryToLogin(LoginModel login)
        //{

        //    HttpResponseMessage response = await client.PostAsJsonAsync("login", login);
        //    response.EnsureSuccessStatusCode();

        //    // Return the URI of the created resource.
        //    return response.Headers.Location;
        //}

    }
}
