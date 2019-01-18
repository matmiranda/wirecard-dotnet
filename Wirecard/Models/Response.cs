using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Response
    {
        [JsonProperty("headers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Headers Headers { get; set; }
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Status { get; set; }
    }
}