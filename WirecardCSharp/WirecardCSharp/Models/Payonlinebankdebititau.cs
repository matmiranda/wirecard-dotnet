using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Payonlinebankdebititau
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string redirectHref { get; set; }
    }
}