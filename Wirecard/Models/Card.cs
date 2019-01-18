using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Card
    {
        [JsonProperty("brand", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Brand { get; set; }
        [JsonProperty("store", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Store { get; set; }
    }
}