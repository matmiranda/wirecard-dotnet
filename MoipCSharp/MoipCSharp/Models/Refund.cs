using System;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class Refund
    {
        public string id { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public Amount amount { get; set; }
        public Refundinginstrument refundingInstrument { get; set; }
        public Event[] events { get; set; }
        public _Links _links { get; set; }
        public DateTime createdAt { get; set; }
    }
}
