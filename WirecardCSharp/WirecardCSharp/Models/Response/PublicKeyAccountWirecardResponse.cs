using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class PublicKeyAccountWirecardResponse
    {
        [JsonProperty("keys", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Keys keys { get; set; }
    }
}
