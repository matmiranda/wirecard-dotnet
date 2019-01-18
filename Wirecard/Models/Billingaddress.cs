using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Billingaddress
    {
        [JsonProperty("city", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string City { get; set; }
        [JsonProperty("district", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string District { get; set; }
        [JsonProperty("street", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Street { get; set; }
        [JsonProperty("streetNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StreetNumber { get; set; }
        [JsonProperty("zipCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ZipCode { get; set; }
        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string State { get; set; }
        [JsonProperty("country", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Country { get; set; }
    }
}