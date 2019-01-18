using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Merchant
    {
        [JsonProperty("enabled", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Enabled { get; set; }
    }
}