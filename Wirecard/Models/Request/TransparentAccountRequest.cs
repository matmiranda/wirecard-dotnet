using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class TransparentAccountRequest
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Email Email { get; set; }
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Person Person { get; set; }
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty("transparentAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool TransparentAccount { get; set; }
        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Company Company { get; set; }
    }
}