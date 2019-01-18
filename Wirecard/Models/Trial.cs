using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Trial
    {
        [JsonProperty("days", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Days { get; set; }
        [JsonProperty("enabled", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Enabled { get; set; }
        [JsonProperty("hold_setup_fee", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Hold_Setup_Fee { get; set; }
    }
}