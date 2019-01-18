using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class TransferResponse
    {
        [JsonProperty("ownId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string OwnId { get; set; }
        [JsonProperty("updatedAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("fee", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Fee { get; set; }
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Amount { get; set; }
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("transferInstrument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Transferinstrument TransferInstrument { get; set; }
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
        [JsonProperty("createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Event> Events { get; set; }
        [JsonProperty("entries", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Entry> Entries { get; set; }
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links _Links { get; set; }
    }
}