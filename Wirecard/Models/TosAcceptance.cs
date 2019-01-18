using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class TosAcceptance
    {
        [JsonProperty("acceptedAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AcceptedAt { get; set; }
        [JsonProperty("ip", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Ip { get; set; }
        [JsonProperty("userAgent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UserAgent { get; set; }
    }
}