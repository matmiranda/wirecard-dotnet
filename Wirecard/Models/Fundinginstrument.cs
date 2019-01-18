using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Fundinginstrument
    {
        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Method { get; set; }
        [JsonProperty("creditCard", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Creditcard CreditCard { get; set; }
        [JsonProperty("brand", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Brand { get; set; }
        [JsonProperty("boleto", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Boleto Boleto { get; set; }
        [JsonProperty("onlineBankDebit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Onlinebankdebit OnlineBankDebit { get; set; }
    }
}