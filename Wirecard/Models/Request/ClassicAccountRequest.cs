using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class ClassicAccountRequest
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Email Email { get; set; }
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Person Person { get; set; }
        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Company Company { get; set; }
        [JsonProperty("businessSegment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Businesssegment BusinessSegment { get; set; }
        [JsonProperty("site", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Site { get; set; }
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty("tosAcceptance", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public TosAcceptance TosAcceptance { get; set; }
    }
}