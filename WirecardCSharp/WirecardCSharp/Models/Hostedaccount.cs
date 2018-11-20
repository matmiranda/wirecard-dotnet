using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Hostedaccount
    {
        [JsonProperty("redirectHref", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RedirectHref { get; set; }
    }
}