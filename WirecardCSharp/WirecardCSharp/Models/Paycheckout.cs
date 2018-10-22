using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Paycheckout
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string redirectHref { get; set; }
    }
}