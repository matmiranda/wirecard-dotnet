using Newtonsoft.Json;

namespace MoipCSharp.Models
{
    public class Checkout
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Paycheckout payCheckout { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Paycreditcard payCreditCard { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Payboleto payBoleto { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Payonlinebankdebititau payOnlineBankDebitItau { get; set; }
    }
}