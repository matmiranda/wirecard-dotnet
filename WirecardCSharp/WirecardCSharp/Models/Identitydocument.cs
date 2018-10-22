using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Identitydocument
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string type { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string number { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string issuer { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string issueDate { get; set; }
    }
}