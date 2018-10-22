using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Cancellationdetails
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string code { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string description { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string cancelledBy { get; set; }
    }
}