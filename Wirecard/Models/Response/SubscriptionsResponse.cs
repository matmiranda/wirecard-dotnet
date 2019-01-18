using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class SubscriptionsResponse
    {
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links Links { get; set; }
        [JsonProperty("summary", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Summary Summary { get; set; }
        [JsonProperty("subscriptions", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Subscription> Subscriptions { get; set; }
    }
}