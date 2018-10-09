using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Paycheckout
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string redirectHref { get; set; }
    }
}