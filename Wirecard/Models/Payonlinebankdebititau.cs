using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Payonlinebankdebititau
    {
        [JsonProperty("redirectHref", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RedirectHref { get; set; }
    }
}