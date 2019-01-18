using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Payment_Method
    {
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Code { get; set; }
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        [JsonProperty("credit_card", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Credit_Card Credit_Card { get; set; }
    }
}