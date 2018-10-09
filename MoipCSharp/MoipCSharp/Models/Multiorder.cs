using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Multiorder
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string href { get; set; }
    }
}