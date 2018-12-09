using Newtonsoft.Json;
using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public class InvoicesResponse
    {
        [JsonProperty("invoices", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Invoice> Invoices { get; set; }
    }
}