using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Keys
    {
        [JsonProperty("basicAuth", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Basicauth BasicAuth { get; set; }
        [JsonProperty("encryption", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Encryption { get; set; }
    }
}