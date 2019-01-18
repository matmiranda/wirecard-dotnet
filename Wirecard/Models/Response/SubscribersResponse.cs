using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class SubscribersResponse
    {
        [JsonProperty("customers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Customer> Customers { get; set; }
    }
}