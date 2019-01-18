using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Summary
    {
        [JsonProperty("count", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Count { get; set; }
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Amount { get; set; }
    }
}