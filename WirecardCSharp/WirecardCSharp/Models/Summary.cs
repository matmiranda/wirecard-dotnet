using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Summary
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int count { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int amount { get; set; }
    }
}