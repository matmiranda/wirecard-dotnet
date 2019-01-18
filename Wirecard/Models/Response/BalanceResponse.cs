using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class BalanceResponse
    {
        [JsonProperty("unavailable", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Unavailable { get; set; }
        [JsonProperty("future", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Future { get; set; }
        [JsonProperty("current", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Current { get; set; }
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links _Links { get; set; }
        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Date { get; set; }
    }
}