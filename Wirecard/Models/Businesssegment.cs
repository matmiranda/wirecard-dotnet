using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Businesssegment
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }
    }
}