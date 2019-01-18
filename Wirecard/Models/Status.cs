using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Status
    {
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Code { get; set; }
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
    }
}