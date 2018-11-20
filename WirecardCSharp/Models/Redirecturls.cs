using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Redirecturls
    {
        [JsonProperty("urlFailure", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UrlFailure { get; set; }
        [JsonProperty("urlSuccess", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UrlSuccess { get; set; }
    }
}