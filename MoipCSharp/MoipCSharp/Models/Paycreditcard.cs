using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Paycreditcard
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string redirectHref { get; set; }
    }
}