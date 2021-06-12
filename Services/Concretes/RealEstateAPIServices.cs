using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RealEstateAPI.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RealEstateAPI.Services
{
    public class RealEstateAPIServices : IRealEstateAPIServices
    {
        private HttpClient _httpClient;
        private APIConfig _apiConfig;
        public RealEstateAPIServices(IOptions<APIConfig> apiConfig)
        {
            _apiConfig = apiConfig.Value;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_apiConfig.BaseAddress)
            };
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiConfig.BearerToken);
        }
        public async Task<GetAddressResponse> GetAddressAsync(string address)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"v3/businesses/search?location={address}");
            return JsonConvert.DeserializeObject<GetAddressResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
