using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class Installment
    {
        [JsonProperty("addition", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Addition { get; set; }
        [JsonProperty("quantity", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<int> Quantity { get; set; }
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Amount { get; set; }
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Number { get; set; }
    }
}