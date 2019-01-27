using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Summary
    {
        [JsonProperty("count", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Count { get; set; }
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Amount { get; set; }
        [JsonProperty("creditSum", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int CreditSum { get; set; }
        [JsonProperty("debitSum", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int DebitSum { get; set; }
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        [JsonProperty("entrySum", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int EntrySum { get; set; }
        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Date { get; set; }
        [JsonProperty("entryCount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int EntryCount { get; set; }
    }
}