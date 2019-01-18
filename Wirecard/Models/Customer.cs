using System;
using Newtonsoft.Json;

namespace Wirecard.Models
{    
    public class Customer
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("ownId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string OwnId { get; set; }
        [JsonProperty("fullname", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FullName { get; set; }
        [JsonProperty("createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("birthDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BirthDate { get; set; }
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Email { get; set; }
        [JsonProperty("fundingInstrument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Fundinginstrument FundingInstrument { get; set; }
        [JsonProperty("phone", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Phone Phone { get; set; }
        [JsonProperty("taxDocument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Taxdocument TaxDocument { get; set; }
        [JsonProperty("shippingAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Shippingaddress ShippingAddress { get; set; }
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public _Links _Links { get; set; }
        [JsonProperty("updatedAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("moipAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Moipaccount MoipAccount { get; set; }
        [JsonProperty("creation_time", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Creation_time { get; set; }
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Address Address { get; set; }
        [JsonProperty("birthdate_year", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int BirthDate_Year { get; set; }
        [JsonProperty("creation_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Creation_Date { get; set; }
        [JsonProperty("birthdate_month", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BirthDate_Month { get; set; }
        [JsonProperty("billing_info", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Billing_Info Billing_Info { get; set; }
        [JsonProperty("cpf", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Cpf { get; set; }
        [JsonProperty("phone_number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Phone_Number { get; set; }
        [JsonProperty("birthdate_day", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int BirthDate_Day { get; set; }
        [JsonProperty("phone_area_code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Phone_Area_Code { get; set; }
        [JsonProperty("enabled", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Enabled { get; set; }
    }
}