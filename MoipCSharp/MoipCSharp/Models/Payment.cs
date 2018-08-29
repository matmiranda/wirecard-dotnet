#pragma warning disable IDE1006

using System;

namespace MoipCSharp.Models
{
    public class Payment
    {
        public string id { get; set; }
        public int installmentCount { get; set; }
        public Fundinginstrument fundingInstrument { get; set; }
        public string status { get; set; }
        public Amount amount { get; set; }
        public Fee[] fees { get; set; }
        public Event[] events { get; set; }
        public _Links _links { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime createdAt { get; set; }
    }
}
