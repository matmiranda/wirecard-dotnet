using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public partial class Payment
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string id { get => Id; set => Id = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int installmentCount { get => InstallmentCount; set => InstallmentCount = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Fundinginstrument fundingInstrument { get => FundingInstrument; set => FundingInstrument = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string status { get => Status; set => Status = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Amount amount { get => Amount; set => Amount = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public List<Fee> fees { get => Fees; set => Fees = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public List<Event> events { get => Events; set => Events = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public _Links _links { get => _Links; set => _Links = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public DateTime updatedAt { get => UpdatedAt; set => UpdatedAt = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public DateTime createdAt { get => CreatedAt; set => CreatedAt = value; }
    }
    public partial class Payment
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
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
    }
}
