using Newtonsoft.Json;
using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public class NotificationRequest
    {
        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Events { get; set; }
        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Target { get; set; }
        [JsonProperty("media", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Media { get; set; }
    }
}