using System;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class Order
    {
        public string id { get; set; }
        public string ownId { get; set; }
        public string status { get; set; }
        public bool blocked { get; set; }
        public Amount amount { get; set; }
        public Receiver[] receivers { get; set; }
        public Customer customer { get; set; }
        public Item[] items { get; set; }
        public Payment[] payments { get; set; }
        public Event[] events { get; set; }
        public _Links _links { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string href { get; set; }
        public string title { get; set; }
    }
}
