using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Subtotals
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int shipping { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int addition { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int discount { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int items { get; set; }
    }
}