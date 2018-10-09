using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Current
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int amount { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string currency { get; set; }
    }
}
