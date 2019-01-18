using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Mainactivity
    {
        [JsonProperty("cnae", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Cnae { get; set; }
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
    }
}