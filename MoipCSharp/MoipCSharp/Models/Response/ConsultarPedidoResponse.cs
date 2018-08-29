using System;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class ConsultarPedidoResponse
    {
        public string id { get; set; }
        public string ownId { get; set; }
        public string status { get; set; }
        public string platform { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public Amount amount { get; set; }
        public Item[] items { get; set; }
        public Address[] addresses { get; set; }
        public Customer customer { get; set; }
        public object[] payments { get; set; }
        public object[] escrows { get; set; }
        public object[] refunds { get; set; }
        public object[] entries { get; set; }
        public Event[] events { get; set; }
        public Receiver[] receivers { get; set; }
        public Checkoutpreferences checkoutPreferences { get; set; }
        public _Links _links { get; set; }
    }
}
