using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Credit_Card
    {
        [JsonProperty("first_six_digits", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string First_Six_Digits { get; set; }
        [JsonProperty("last_four_digits", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Last_Four_Digits { get; set; }
        [JsonProperty("holder_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Holder_Name { get; set; }
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Number { get; set; }
        [JsonProperty("expiration_month", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Expiration_Month { get; set; }
        [JsonProperty("expiration_year", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Expiration_Year { get; set; }
        [JsonProperty("brand", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Brand { get; set; }
        [JsonProperty("vault", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Vault { get; set; }
    }
}