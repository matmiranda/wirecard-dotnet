using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class SignatureRequest
    {
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Amount { get; set; }
        [JsonProperty("setup_fee", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Setup_Fee { get; set; }
        [JsonProperty("max_qty", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Max_Qty { get; set; }
        [JsonProperty("interval", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Interval Interval { get; set; }
        [JsonProperty("billing_cycles", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Billing_Cycles { get; set; }
        [JsonProperty("trial", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Trial Trial { get; set; }
        [JsonProperty("payment_method", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Payment_Method { get; set; }
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