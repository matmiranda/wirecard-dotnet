using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Refundinginstrument
    {
        [JsonProperty("creditCard", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Creditcard CreditCard { get; set; }
        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Method { get; set; }
        [JsonProperty("moipAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Moipaccount MoipAccount { get; set; }
        [JsonProperty("bankAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Bankaccount BankAccount { get; set; }
    }
}