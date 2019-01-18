using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Subtotals
    {
        [JsonProperty("shipping", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Shipping { get; set; }
        [JsonProperty("addition", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Addition { get; set; }
        [JsonProperty("discount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Discount { get; set; }
        [JsonProperty("items", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Items { get; set; }
    }
}