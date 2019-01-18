using System;
using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Webhook
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