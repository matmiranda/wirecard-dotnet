using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class Billing_Info
    {
        [JsonProperty("credit_card", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Credit_Card Credit_Card { get; set; }
        [JsonProperty("credit_cards", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Credit_Card> Credit_Cards { get; set; }
    }
}