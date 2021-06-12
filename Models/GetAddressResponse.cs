using Newtonsoft.Json;
using System.Collections.Generic;

namespace RealEstateAPI.Models
{
    public class GetAddressResponse
    {
        [JsonProperty("total")]
        public int Total{ get; set; }
        [JsonProperty("businesses")]
        public List<BusinessModel> BusinessList { get; set; }
    }
}
