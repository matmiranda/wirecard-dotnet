using Newtonsoft.Json;

namespace Wirecard.Models
{
    public class Onlinebankdebit
    {
        [JsonProperty("bankNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BankNumber { get; set; }
        [JsonProperty("expirationDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ExpirationDate { get; set; }
        [JsonProperty("bankName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BankName { get; set; }
        [JsonProperty("returnUri", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ReturnUri { get; set; }
    }
}