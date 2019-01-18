using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Future
    {
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Amount { get; set; }
        [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Currency { get; set; }
    }
}