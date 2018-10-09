using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Email
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string address { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool confirmed { get; set; }
    }
}
