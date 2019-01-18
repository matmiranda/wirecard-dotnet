using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Webhooktofire
    {
        [JsonProperty("$ref", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Ref { get; set; }

        [JsonProperty("$id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Id Id { get; set; }
    }
}