using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Merchant
    {
        [JsonProperty("enabled", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Enabled { get; set; }
    }
}