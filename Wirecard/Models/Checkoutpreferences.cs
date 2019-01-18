using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class Checkoutpreferences
    {
        [JsonProperty("installments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Installment> Installments { get; set; }
        [JsonProperty("redirectUrls", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Redirecturls RedirectUrls { get; set; }
    }
}