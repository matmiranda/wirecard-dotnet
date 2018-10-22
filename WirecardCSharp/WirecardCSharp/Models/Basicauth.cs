using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Basicauth
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string secret { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string token { get; set; }
    }
}
