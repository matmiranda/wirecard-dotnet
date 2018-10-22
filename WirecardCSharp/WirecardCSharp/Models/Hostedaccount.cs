using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Hostedaccount
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string redirectHref { get; set; }
    }
}