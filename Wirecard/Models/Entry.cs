using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class Entry
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("external_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string External_Id { get; set; }
        [JsonProperty("reschedule", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object[] Reschedule { get; set; }
        [JsonProperty("scheduledFor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime ScheduledFor { get; set; }
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
        [JsonProperty("moipAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Moipaccount MoipAccount { get; set; }
        [JsonProperty("fees", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Fee> Fees { get; set; }
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty("grossAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int GrossAmount { get; set; }
        [JsonProperty("moipAccountId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MoipAccountId { get; set; }
        [JsonProperty("updatedAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("installment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Installment Installment { get; set; }
        [JsonProperty("references", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Reference> References { get; set; }
        [JsonProperty("eventId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string EventId { get; set; }
        [JsonProperty("createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        [JsonProperty("settledAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime SettledAt { get; set; }
        [JsonProperty("liquidAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int LiquidAmount { get; set; }
        [JsonProperty("blocked", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Blocked { get; set; }
    }
}