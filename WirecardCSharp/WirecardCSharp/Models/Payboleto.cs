using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Payboleto
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string redirectHref { get; set; }
    }
}