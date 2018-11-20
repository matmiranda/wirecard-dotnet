using Newtonsoft.Json;
using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public class WebhooksResponse
    {
        [JsonProperty("webhooks", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Webhook> WebHooks { get; set; }
    }
}