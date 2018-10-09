using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Next
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string href { get; set; }
    }
}