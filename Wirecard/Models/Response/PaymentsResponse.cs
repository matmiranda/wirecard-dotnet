using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class PaymentsResponse
    {
        [JsonProperty("payments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Payment> Payments { get; set; }
    }
}