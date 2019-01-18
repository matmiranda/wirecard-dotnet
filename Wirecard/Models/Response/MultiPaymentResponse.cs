using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class MultiPaymentResponse
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Amount Amount { get; set; }
        [JsonProperty("installmentCount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int InstallmentCount { get; set; }
        [JsonProperty("payments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Payment> Payments { get; set; }
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links _Links { get; set; }
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        [JsonProperty("createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updatedAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime UpdatedAt { get; set; }
    }
}