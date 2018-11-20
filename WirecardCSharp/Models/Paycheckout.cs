using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Paycheckout
    {
        [JsonProperty("redirectHref", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RedirectHref { get; set; }
    }
}