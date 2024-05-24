using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IPMAWarningsApp.Models;
using RestSharp;
using Newtonsoft.Json;

namespace IPMAWarningsApp.API
{
    public class RestSharpCaller : IAiCaller
    {
        private readonly RestClient _client;

        public RestSharpCaller(string baseUrl)
        {
            _client = new RestClient(baseUrl);
        }

        public async Task<List<Aviso>> GetWarningsAsync()
        {
            var request = new RestRequest("forecast/warnings/warnings_www.json", Method.Get);
            var response = await _client.ExecuteAsync(request);

            if (!response.IsSuccessful)
            {
                throw new Exception("Failed to fetch data from API");
            }

            return JsonConvert.DeserializeObject<List<Aviso>>(response.Content);
        }
    }
}
