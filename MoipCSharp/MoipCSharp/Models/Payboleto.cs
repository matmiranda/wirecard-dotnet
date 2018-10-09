using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Payboleto
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string redirectHref { get; set; }
    }
}