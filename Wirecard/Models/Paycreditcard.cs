using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Paycreditcard
    {
        [JsonProperty("redirectHref", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RedirectHref { get; set; }
    }
}