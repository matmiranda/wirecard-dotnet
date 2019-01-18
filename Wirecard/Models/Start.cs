using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Start
    {
        [JsonProperty("month", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Month { get; set; }
        [JsonProperty("year", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Year { get; set; }
        [JsonProperty("day", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Day { get; set; }
    }
}