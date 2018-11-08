using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Webhook
    {
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string id { get => Id; set => Id = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string resourceId { get => ResourceId; set => ResourceId = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string _event { get => _Event; set => _Event = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string url { get => Url; set => Url = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string status { get => Status; set => Status = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public DateTime sentAt { get => SentAt; set => SentAt = value; }
    }
    public partial class Webhook
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("resourceId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ResourceId { get; set; }
        [JsonProperty("_event", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string _Event { get; set; }
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url { get; set; }
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
        [JsonProperty("sentAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime SentAt { get; set; }
    }
}
