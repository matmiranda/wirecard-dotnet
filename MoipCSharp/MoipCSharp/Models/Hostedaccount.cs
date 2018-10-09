using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Hostedaccount
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string redirectHref { get; set; }
    }
}