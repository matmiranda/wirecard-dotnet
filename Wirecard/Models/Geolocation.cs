using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Geolocation
    {
        [JsonProperty("latitude", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Latitude { get; set; }
        [JsonProperty("longitude", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Longitude { get; set; }
    }
}