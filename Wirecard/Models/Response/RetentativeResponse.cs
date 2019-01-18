using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class RetentativeResponse
    {
        [JsonProperty("year", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Year { get; set; }
        [JsonProperty("month", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Month { get; set; }
        [JsonProperty("day", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Day { get; set; }
        [JsonProperty("first_try", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int First_Try { get; set; }
        [JsonProperty("second_try", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Second_Try { get; set; }
        [JsonProperty("third_try", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Third_Try { get; set; }
        [JsonProperty("_finally", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Finally { get; set; }
    }
}