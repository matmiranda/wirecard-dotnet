using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Businesssegment
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }
    }
}