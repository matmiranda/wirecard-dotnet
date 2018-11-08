using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public partial class WebhooksResponse
    {
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public List<Webhook> webhooks { get => WebHooks; set => WebHooks = value; }
    }
    public partial class WebhooksResponse
    {
        [JsonProperty("webhooks", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Webhook> WebHooks { get; set; }
    }
}
