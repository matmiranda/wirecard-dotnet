using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class Order
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("ownId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string OwnId { get; set; }
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
        [JsonProperty("blocked", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Blocked { get; set; }
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Amount Amount { get; set; }
        [JsonProperty("receivers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Receiver> Receivers { get; set; }
        [JsonProperty("customer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Customer Customer { get; set; }
        [JsonProperty("items", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Item> Items { get; set; }
        [JsonProperty("payments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Payment> Payments { get; set; }
        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Event> Events { get; set; }
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links _Links { get; set; }
        [JsonProperty("createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updatedAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("href", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Href { get; set; }
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        [JsonProperty("addresses", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Address> Addresses { get; set; }
        [JsonProperty("entries", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object[] Entries { get; set; }
        [JsonProperty("escrows", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object[] Escrows { get; set; }
        [JsonProperty("platform", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Platform { get; set; }
        [JsonProperty("refunds", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object[] Refunds { get; set; }
    }
}