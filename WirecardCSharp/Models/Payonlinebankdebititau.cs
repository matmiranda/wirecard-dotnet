using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Payonlinebankdebititau
    {
        [JsonProperty("redirectHref", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RedirectHref { get; set; }
    }
}