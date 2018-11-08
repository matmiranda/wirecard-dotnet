using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Transfer
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int fee { get => Fee; set => Fee = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int amount { get => Amount; set => Amount = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public DateTime updatedAt { get => UpdatedAt; set => UpdatedAt = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string id { get => Id; set => Id = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Transferinstrument transferInstrument { get => TransferInstrument; set => TransferInstrument = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string status { get => Status; set => Status = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public DateTime createdAt { get => CreatedAt; set => CreatedAt = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public _Links _links { get => _Links; set => _Links = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string role { get => Role; set => Role = value; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string ownId { get => OwnId; set => OwnId = value; }
    }
    public partial class Transfer
    {
        [JsonProperty("fee", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Fee { get; set; }
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Amount { get; set; }
        [JsonProperty("updatedAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("transferInstrument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Transferinstrument TransferInstrument { get; set; }
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
        [JsonProperty("createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links _Links { get; set; }
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Role { get; set; }
        [JsonProperty("ownId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string OwnId { get; set; }
    }
}
