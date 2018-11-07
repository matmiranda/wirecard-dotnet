using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public partial class LaunchResponse
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string external_id { get => External_Id; set => value = External_Id; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public object[] reschedule { get => Reschedule; set => value = Reschedule; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public DateTime scheduledFor { get => ScheduledFor; set => value = ScheduledFor; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string status { get => Status; set => value = Status; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Moipaccount moipAccount { get => MoipAccount; set => value = MoipAccount; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public List<Fee> fees { get => Fees; set => value = Fees; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string type { get => Type; set => value = Type; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int grossAmount { get => GrossAmount; set => value = GrossAmount; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int moipAccountId { get => MoipAccountId; set => value = MoipAccountId; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public DateTime updatedAt { get => UpdatedAt; set => value = UpdatedAt; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int id { get => Id; set => value = Id; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Installment installment { get => Installment; set => value = Installment; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public List<Reference> references { get => References; set => value = References; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string eventId { get => EventId; set => value = EventId; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public DateTime createdAt { get => CreatedAt; set => value = CreatedAt; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string description { get => Description; set => value = Description; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public bool blocked { get => Blocked; set => value = Blocked; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public DateTime settledAt { get => SettledAt; set => value = SettledAt; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int liquidAmount { get => LiquidAmount; set => value = LiquidAmount; }
    }
    public partial class LaunchResponse
    {
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
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }
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
        [JsonProperty("blocked", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Blocked { get; set; }
        [JsonProperty("settledAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime SettledAt { get; set; }
        [JsonProperty("liquidAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int LiquidAmount { get; set; }
    }
}
