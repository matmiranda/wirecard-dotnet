using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Device
    {
        [JsonProperty("ip", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Ip { get; set; }
        [JsonProperty("geolocation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Geolocation Geolocation { get; set; }
        [JsonProperty("userAgent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UserAgent { get; set; }
        [JsonProperty("fingerprint", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Fingerprint { get; set; }
    }
}