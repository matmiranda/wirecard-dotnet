using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Payboleto
    {
        [JsonProperty("printHref", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PrintHref { get; set; }
        [JsonProperty("redirectHref", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RedirectHref { get; set; }
    }
}