using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Best_Invoice_Date
    {
        [JsonProperty("day_of_month", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Day_Of_Month { get; set; }
        [JsonProperty("month_of_year", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Month_Of_Year { get; set; }
    }
}