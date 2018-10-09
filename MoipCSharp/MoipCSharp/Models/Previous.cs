using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Previous
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string href { get; set; }
    }
}