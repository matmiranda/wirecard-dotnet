using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class MultiOrderRequest
    {
        [JsonProperty("ownId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string OwnId { get; set; }
        [JsonProperty("orders", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Order> Orders { get; set; }
    }
}