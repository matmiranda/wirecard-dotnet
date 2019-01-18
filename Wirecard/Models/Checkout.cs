using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Checkout
    {
        [JsonProperty("payCheckout", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Paycheckout PayCheckout { get; set; }
        [JsonProperty("payCreditCard", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Paycreditcard PayCreditCard { get; set; }
        [JsonProperty("payBoleto", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Payboleto PayBoleto { get; set; }
        [JsonProperty("payOnlineBankDebitItau", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Payonlinebankdebititau PayOnlineBankDebitItau { get; set; }
    }
}