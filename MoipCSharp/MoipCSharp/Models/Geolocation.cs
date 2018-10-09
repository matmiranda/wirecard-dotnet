using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Geolocation
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float latitude { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float longitude { get; set; }
    }
}
