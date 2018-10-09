using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Businesssegment
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int id { get; set; }
    }
}