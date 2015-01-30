using System;
using System.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using RestSharp;

namespace ChallongeSync
{
    class Program
    {
        private const string URL = "https://api.challonge.com";

        static void Main(string[] args)
        {
            var ChallongeApiKey = ConfigurationManager.AppSettings.Get("challongeAPIKey");

            //Declare Rest Client
            var client = new RestClient(URL);
            var request = new RestRequest("/v1/tournaments.xml", Method.GET);
            request.AddParameter("api_key", ChallongeApiKey);
            request.AddParameter("subdomain", "gigmasters");

            var response = client.Execute<List<Tournament>>(request);


            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //var dataObjects = response.Content.ReadAsAsync<IEnumerable>().Result;
                foreach (Tournament d in response.Data)
                {
                    Console.WriteLine("{0}", d.Name);
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ErrorMessage);
            }
            Console.Read();
        }
    }
}
