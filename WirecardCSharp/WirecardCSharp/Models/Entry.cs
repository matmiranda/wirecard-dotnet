using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public partial class Entry
    {
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string id { get => Id; set => Id = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string external_id { get => External_Id; set => External_Id = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public DateTime scheduledFor { get => ScheduledFor; set => ScheduledFor = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string status { get => Status; set => Status = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Moipaccount moipAccount { get => MoipAccount; set => MoipAccount = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public List<Fee> fees { get => Fees; set => Fees = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string type { get => Type; set => Type = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int grossAmount { get => GrossAmount; set => GrossAmount = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int moipAccountId { get => MoipAccountId; set => MoipAccountId = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public DateTime updatedAt { get => UpdatedAt; set => UpdatedAt = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Installment installment { get => Installment; set => Installment = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public List<Reference> references { get => References; set => References = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string eventId { get => EventId; set => EventId = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public DateTime createdAt { get => CreatedAt; set => CreatedAt = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string description { get => Description; set => Description = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public DateTime settledAt { get => SettledAt; set => SettledAt = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int liquidAmount { get => LiquidAmount; set => LiquidAmount = value; }
    }
    public partial class Entry
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("external_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string External_Id { get; set; }
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
    }
}
