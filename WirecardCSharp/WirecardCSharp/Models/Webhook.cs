using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Webhook
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string id { get => Id; set => value = Id; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string resourceId { get => ResourceId; set => value = ResourceId; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string _event { get => _Event; set => value = _Event; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string url { get => Url; set => value = Url; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string status { get => Status; set => value = Status; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public DateTime sentAt { get => SentAt; set => value = SentAt; }
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
