using Newtonsoft.Json;
using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public class SubscriptionsResponse
    {
        [JsonProperty("subscriptions", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Subscription> Subscriptions { get; set; }
    }
}