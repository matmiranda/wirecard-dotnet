using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Coupon
    {
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }
        [JsonProperty("discount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Discount Discount { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }
        [JsonProperty("duration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Duration Duration { get; set; }
        [JsonProperty("expiration_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Expiration_Date Expiration_Date { get; set; }
        [JsonProperty("max_redemptions", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Max_Redemptions { get; set; }
        [JsonProperty("in_use", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool In_Use { get; set; }
        [JsonProperty("creation_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Creation_Date Creation_Date { get; set; }
    }
}