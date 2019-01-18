using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Paycheckout
    {
        [JsonProperty("redirectHref", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RedirectHref { get; set; }
    }
}