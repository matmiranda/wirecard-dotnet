using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Email
    {
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Address { get; set; }
        [JsonProperty("confirmed", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Confirmed { get; set; }
        [JsonProperty("merchant", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Merchant Merchant { get; set; }
        [JsonProperty("customer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Customer Customer { get; set; }
    }
}