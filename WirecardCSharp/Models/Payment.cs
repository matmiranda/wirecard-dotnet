using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public class Payment
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("acquirerDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Acquirerdetails AcquirerDetails { get; set; }
        [JsonProperty("installmentCount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int InstallmentCount { get; set; }
        [JsonProperty("fundingInstrument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Fundinginstrument FundingInstrument { get; set; }
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Amount Amount { get; set; }
        [JsonProperty("fees", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Fee> Fees { get; set; }
        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Event> Events { get; set; }
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links _Links { get; set; }
        [JsonProperty("updatedAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("payments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Payment> Payments { get; set; }
        [JsonProperty("delayCapture", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool DelayCapture { get; set; }
        [JsonProperty("statementDescriptor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StatementDescriptor { get; set; }
    }
}