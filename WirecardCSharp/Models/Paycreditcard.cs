using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Paycreditcard
    {
        [JsonProperty("redirectHref", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RedirectHref { get; set; }
    }
}