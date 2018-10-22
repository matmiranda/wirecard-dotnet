using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Fee
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string type { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int amount { get; set; }
    }
}
