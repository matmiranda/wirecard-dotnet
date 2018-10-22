using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Reference
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string value { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string type { get; set; }
    }
}