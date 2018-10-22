using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Device
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ip { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Geolocation geolocation { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string userAgent { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string fingerprint { get; set; }
    }
}
