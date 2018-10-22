using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Taxdocument
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string type { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string number { get; set; }
    }
}