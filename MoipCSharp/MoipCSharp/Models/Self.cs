using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Self
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string href { get; set; }
    }
}