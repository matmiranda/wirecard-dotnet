using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Unavailable
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int amount { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string currency { get; set; }
    }
}