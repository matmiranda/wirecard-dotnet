using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class NotificationRequest
    {
        [JsonProperty("resourceId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ResourceId { get; set; }
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Event { get; set; }
        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Events { get; set; }
        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Target { get; set; }
        [JsonProperty("media", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Media { get; set; }
        [JsonProperty("notification", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Notification Notification { get; set; }
    }
}