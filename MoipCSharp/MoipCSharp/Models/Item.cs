using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Item
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string product { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string category { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int quantity { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string detail { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int price { get; set; }
    }
}
