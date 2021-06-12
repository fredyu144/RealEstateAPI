using Newtonsoft.Json;

namespace RealEstateAPI.Models
{
    public class BusinessModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("location")]
        public LocationModel Location { get; set; }
    }
}
