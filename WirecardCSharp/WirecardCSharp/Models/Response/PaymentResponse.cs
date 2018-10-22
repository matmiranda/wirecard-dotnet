using System;
using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public class PaymentResponse
    {
        public string id { get; set; }
        public string status { get; set; }
        public bool delayCapture { get; set; }
        public Amount amount { get; set; }
        public int installmentCount { get; set; }
        public string statementDescriptor { get; set; }
        public Fundinginstrument fundingInstrument { get; set; }
        public List<Fee> fees { get; set; }
        public List<Event> events { get; set; }
        public List<Receiver> receivers { get; set; }
        public Device device { get; set; }
        public _Links _links { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string type { get; set; }
        public Refundinginstrument refundingInstrument { get; set; }
        public string description { get; set; }
        public Cancellationdetails cancellationDetails { get; set; }
    }
}
