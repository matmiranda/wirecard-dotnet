using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Multiorder
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string href { get; set; }
    }
}