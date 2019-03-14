using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class _Links
    {
        [JsonProperty("next", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Next Next { get; set; }
        [JsonProperty("previous", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Previous Previous { get; set; }
        [JsonProperty("self", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Self Self { get; set; }
        [JsonProperty("hostedAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Hostedaccount HostedAccount { get; set; }
        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Order Order { get; set; }
        [JsonProperty("payment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Payment Payment { get; set; }
        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string File { get; set; }
        [JsonProperty("setPassword", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Setpassword SetPassword { get; set; }
        [JsonProperty("checkout", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Checkout Checkout { get; set; }
        [JsonProperty("payBoleto", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Payboleto Payboleto { get; set; }
        [JsonProperty("payOnlineBankDebitItau", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Payonlinebankdebititau PayOnlineBankDebitItau { get; set; }
    }
}