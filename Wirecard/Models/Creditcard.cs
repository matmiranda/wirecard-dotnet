using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Creditcard
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("brand", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Brand { get; set; }
        [JsonProperty("first6", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string First6 { get; set; }
        [JsonProperty("last4", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Last4 { get; set; }
        [JsonProperty("store", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Store { get; set; }
        [JsonProperty("expirationMonth", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ExpirationMonth { get; set; }
        [JsonProperty("expirationYear", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ExpirationYear { get; set; }
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Number { get; set; }
        [JsonProperty("cvc", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Cvc { get; set; }
        [JsonProperty("holder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Holder Holder { get; set; }
        [JsonProperty("hash", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Hash { get; set; }
        [JsonProperty("phone", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Phone Phone { get; set; }
    }
}