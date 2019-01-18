using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class PublicKeyAccountWirecardResponse
    {
        [JsonProperty("keys", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Keys keys { get; set; }
    }
}