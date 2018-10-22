using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Redirecturls
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string urlFailure { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string urlSuccess { get; set; }
    }
}