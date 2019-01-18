using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Receiversdebited
    {
        [JsonProperty("Amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int amount { get; set; }
        [JsonProperty("moipAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MoipAccount { get; set; }
    }
}