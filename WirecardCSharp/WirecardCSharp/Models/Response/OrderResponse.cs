using System;
using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public class OrderResponse
    {
        public string id { get; set; }
        public string ownId { get; set; }
        public string status { get; set; }
        public string platform { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public Amount amount { get; set; }
        public List<Item> items { get; set; }
        public List<Address> addresses { get; set; }
        public Customer customer { get; set; }
        public List<Payment> payments { get; set; }
        public object[] escrows { get; set; }
        public object[] refunds { get; set; }
        public List<Entry> entries { get; set; }
        public List<Event> events { get; set; }
        public List<Receiver> receivers { get; set; }
        public Checkoutpreferences checkoutPreferences { get; set; }
        public _Links _links { get; set; }
    }
}