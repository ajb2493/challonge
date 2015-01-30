using System;
using System.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ChallongeSync
{
    class Program
    {
        private const string URL = "https://api.challonge.com/v1/tournaments.json";

        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);


            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            
            var ChallongeApiKey = ConfigurationManager.AppSettings.Get("challongeAPIKey");
            var urlParams = String.Format("?api_key={0}&subdomain=gigmasters",ChallongeApiKey);

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParams).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                Console.WriteLine(response.Content.ReadAsStringAsync());
                var data = response.Content.ReadAsAsync<IEnumerable<Object>>().Result;
                //var dataObjects = response.Content.ReadAsAsync<IEnumerable>().Result;
                foreach (var d in data)
                {
                    //Console.WriteLine("{0}", d.Name);
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            Console.Read();
        }
    }
}
