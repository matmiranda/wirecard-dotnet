using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Hostedaccount
    {
        [JsonProperty("redirectHref", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RedirectHref { get; set; }
    }
}