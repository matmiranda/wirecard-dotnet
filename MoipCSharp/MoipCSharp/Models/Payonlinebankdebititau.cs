using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Payonlinebankdebititau
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string redirectHref { get; set; }
    }
}