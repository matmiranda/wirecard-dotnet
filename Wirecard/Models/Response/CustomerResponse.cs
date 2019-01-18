using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class CustomerResponse
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("ownId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string OwnId { get; set; }
        [JsonProperty("fullname", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FullName { get; set; }
        [JsonProperty("createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("birthDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BirthDate { get; set; }
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Email { get; set; }
        [JsonProperty("phone", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Phone Phone { get; set; }
        [JsonProperty("taxDocument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Taxdocument TaxDocument { get; set; }
        [JsonProperty("shippingAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Shippingaddress ShippingAddress { get; set; }
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links Links { get; set; }
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Event> Events { get; set; }
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Amount Amount { get; set; }
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty("refundingInstrument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Refundinginstrument RefundingInstrument { get; set; }
        [JsonProperty("creditCard", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Creditcard CreditCard { get; set; }
        [JsonProperty("card", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Card Card { get; set; }
        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Method { get; set; }
        [JsonProperty("platform", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Platform { get; set; }
        [JsonProperty("updatedAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("items", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Item> Items { get; set; }
        [JsonProperty("addresses", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Address> Addresses { get; set; }
        [JsonProperty("customer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Customer Customer { get; set; }
        [JsonProperty("payments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object[] Payments { get; set; }
        [JsonProperty("escrows", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object[] Escrows { get; set; }
        [JsonProperty("refunds", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object[] Refunds { get; set; }
        [JsonProperty("entries", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object[] Entries { get; set; }
        [JsonProperty("receivers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Receiver> Receivers { get; set; }
        [JsonProperty("fundingInstrument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Fundinginstrument FundingInstrument { get; set; }
        [JsonProperty("fundingInstruments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Fundinginstrument> FundingInstruments { get; set; }
    }
}