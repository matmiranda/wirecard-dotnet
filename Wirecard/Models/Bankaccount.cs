using System;
using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Bankaccount
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("agencyNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AgencyNumber { get; set; }
        [JsonProperty("holder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Holder Holder { get; set; }
        [JsonProperty("accountNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AccountNumber { get; set; }
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
        [JsonProperty("createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("accountCheckNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AccountCheckNumber { get; set; }
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links _Links { get; set; }
        [JsonProperty("bankName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BankName { get; set; }
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty("agencyCheckNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AgencyCheckNumber { get; set; }
        [JsonProperty("bankNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BankNumber { get; set; }
    }
}