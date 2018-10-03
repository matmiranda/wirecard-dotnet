using System;
using System.Collections.Generic;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class Payment
    {
        public string id { get; set; }
        public int installmentCount { get; set; }
        public Fundinginstrument fundingInstrument { get; set; }
        public string status { get; set; }
        public Amount amount { get; set; }
        public List<Fee> fees { get; set; }
        public List<Event> events { get; set; }
        public _Links _links { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime createdAt { get; set; }
    }
}
