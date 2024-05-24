using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;
using IPMAWarningsApp.Models;

namespace IPMAWarningsApp.API
{
    public class RestSharpCaller : IAiCaller
    {
        private readonly string _baseUrl;

        public RestSharpCaller(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public async Task<List<Aviso>> GetWarningsAsync()
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest("forecast/warnings/warnings_www.json", Method.GET);
            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                var avisos = JsonConvert.DeserializeObject<List<Aviso>>(response.Content);
                return avisos;
            }

            throw new HttpRequestException($"Erro ao obter dados: {response.StatusCode}");
        }
    }
}
