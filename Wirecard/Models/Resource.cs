using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class Resource
    {
        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Order Order { get; set; }
        [JsonProperty("payment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Payment Payment { get; set; }
        [JsonProperty("multiorder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Multiorder Multiorder { get; set; }
        [JsonProperty("transfer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Transfer Transfer { get; set; }
        [JsonProperty("refund", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Refund Refund { get; set; }
        [JsonProperty("escrow", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Escrow Escrow { get; set; }
        [JsonProperty("createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Amount { get; set; }
        [JsonProperty("entries", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object[] Entries { get; set; }
        [JsonProperty("ownId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string OwnId { get; set; }
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links _Links { get; set; }
        [JsonProperty("fee", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Fee { get; set; }
        [JsonProperty("cancellationDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Cancellationdetails CancellationDetails { get; set; }
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("transferInstrument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Transferinstrument TransferInstrument { get; set; }
        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Event> Events { get; set; }
        [JsonProperty("updatedAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }
    }
}