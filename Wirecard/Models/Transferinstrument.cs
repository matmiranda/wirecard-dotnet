using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Transferinstrument
    {
        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Method { get; set; }
        [JsonProperty("bankAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Bankaccount BankAccount { get; set; }
        [JsonProperty("moipAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Moipaccount MoipAccount { get; set; }
    }
}