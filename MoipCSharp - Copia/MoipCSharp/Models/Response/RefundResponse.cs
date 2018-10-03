using System;
using System.Collections.Generic;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class RefundResponse
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
        public Creditcard creditCard { get; set; }
        public Card card { get; set; }
        public string method { get; set; }
    }
}
