using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Event
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string type { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime createdAt { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string description { get; set; }
    }
}