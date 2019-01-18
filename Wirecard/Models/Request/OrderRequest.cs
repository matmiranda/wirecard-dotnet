using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class OrderRequest
    {
        [JsonProperty("ownId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string OwnId { get; set; }
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Amount Amount { get; set; }
        [JsonProperty("items", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Item> Items { get; set; }
        [JsonProperty("customer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Customer Customer { get; set; }
        [JsonProperty("receivers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Receiver> Receivers { get; set; }
    }
}