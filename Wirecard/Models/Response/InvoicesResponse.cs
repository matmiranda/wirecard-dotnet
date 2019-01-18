using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class InvoicesResponse
    {
        [JsonProperty("invoices", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Invoice> Invoices { get; set; }
    }
}