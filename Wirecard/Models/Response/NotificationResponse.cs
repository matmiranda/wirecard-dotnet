using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class NotificationResponse
    {
        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Events { get; set; }
        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Target { get; set; }
        [JsonProperty("media", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Media { get; set; }
        [JsonProperty("token", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Token { get; set; }
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
    }
}