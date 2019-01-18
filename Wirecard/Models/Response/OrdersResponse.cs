using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class OrdersResponse
    {
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links _Links { get; set; }
        [JsonProperty("summary", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Summary Summary { get; set; }
        [JsonProperty("orders", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Order> Orders { get; set; }
    }
}