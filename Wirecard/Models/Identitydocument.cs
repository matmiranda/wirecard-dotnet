using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Identitydocument
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Number { get; set; }
        [JsonProperty("issuer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Issuer { get; set; }
        [JsonProperty("issueDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string IssueDate { get; set; }
    }
}