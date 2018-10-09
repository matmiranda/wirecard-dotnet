using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Parentsname
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string mother { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string father { get; set; }
    }
}