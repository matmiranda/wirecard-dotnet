using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class BankAccountRequest
    {
        [JsonProperty("bankNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BankNumber { get; set; }
        [JsonProperty("agencyNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AgencyNumber { get; set; }
        [JsonProperty("agencyCheckNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AgencyCheckNumber { get; set; }
        [JsonProperty("accountNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AccountNumber { get; set; }
        [JsonProperty("accountCheckNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AccountCheckNumber { get; set; }
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty("holder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Holder Holder { get; set; }
    }
}