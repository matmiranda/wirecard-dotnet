using System;
using System.Collections.Generic;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class ReembolsoResponse
    {
        public string id { get; set; }
        public string status { get; set; }
        public List<Event> events { get; set; }
        public Amount amount { get; set; }
        public string type { get; set; }
        public Refundinginstrument refundingInstrument { get; set; }
        public DateTime createdAt { get; set; }
        public _Links _links { get; set; }
    }
}
