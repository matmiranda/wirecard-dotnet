using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Setpassword
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string href { get; set; }
    }
}