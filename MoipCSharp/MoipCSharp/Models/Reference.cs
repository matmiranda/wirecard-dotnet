using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Reference
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string value { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string type { get; set; }
    }
}