using System;
using System.Collections.Generic;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class CartaoCreditoResponse
    {
        public string id { get; set; }
        public string status { get; set; }
        public List<Event> events { get; set; }
        public Amount amount { get; set; }
        public string type { get; set; }
        public Refundinginstrument refundingInstrument { get; set; }
        public DateTime createdAt { get; set; }
        public _Links _links { get; set; }
        public Creditcard creditCard { get; set; }
        public Card card { get; set; }
        public string method { get; set; }
    }
}
