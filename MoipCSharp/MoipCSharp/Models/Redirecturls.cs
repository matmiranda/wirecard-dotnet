using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Redirecturls
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string urlFailure { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string urlSuccess { get; set; }
    }
}