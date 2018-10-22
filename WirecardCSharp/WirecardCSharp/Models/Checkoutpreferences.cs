using Newtonsoft.Json;
using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public class Checkoutpreferences
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Installment> installments { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Redirecturls redirectUrls { get; set; }
    }
}