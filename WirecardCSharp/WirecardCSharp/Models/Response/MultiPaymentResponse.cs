using System;
using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public class MultiPaymentResponse
    {
        public string id { get; set; }
        public string status { get; set; }
        public Amount amount { get; set; }
        public int installmentCount { get; set; }
        public List<Payment> payments { get; set; }
        public _Links _links { get; set; }
        public string description { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
