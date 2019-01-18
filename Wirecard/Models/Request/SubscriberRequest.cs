using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class SubscriberRequest
    {
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Email { get; set; }
        [JsonProperty("fullname", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FullName { get; set; }
        [JsonProperty("cpf", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Cpf { get; set; }
        [JsonProperty("phone_area_code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Phone_Area_Code { get; set; }
        [JsonProperty("phone_number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Phone_Number { get; set; }
        [JsonProperty("birthdate_day", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BirthDate_Day { get; set; }
        [JsonProperty("birthdate_month", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BirthDate_Month { get; set; }
        [JsonProperty("birthdate_year", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BirthDate_Year { get; set; }
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Address Address { get; set; }
        [JsonProperty("billing_info", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Billing_Info Billing_Info { get; set; }
    }
}