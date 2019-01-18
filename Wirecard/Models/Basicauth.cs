using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Basicauth
    {
        [JsonProperty("secret", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Secret { get; set; }
        [JsonProperty("token", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Token { get; set; }
    }
}