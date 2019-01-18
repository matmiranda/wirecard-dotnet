using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Id
    {
        [JsonProperty("$oid", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Oid { get; set; }
    }
}