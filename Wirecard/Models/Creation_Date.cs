using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Creation_Date
    {
        [JsonProperty("month", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Month { get; set; }
        [JsonProperty("hour", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Hour { get; set; }
        [JsonProperty("year", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Year { get; set; }
        [JsonProperty("day", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Day { get; set; }
        [JsonProperty("minute", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Minute { get; set; }
        [JsonProperty("second", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Second { get; set; }
    }
}