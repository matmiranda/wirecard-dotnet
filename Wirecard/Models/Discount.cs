using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Discount
    {
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Value { get; set; }
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
    }
}