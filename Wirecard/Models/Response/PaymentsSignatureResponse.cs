using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Models
{
    public class PaymentsSignatureResponse
    {
        [JsonProperty("payments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<PaymentSignature> Payments { get; set; }
    }
}