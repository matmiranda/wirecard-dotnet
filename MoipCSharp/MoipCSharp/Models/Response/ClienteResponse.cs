using System;
using System.Collections.Generic;

namespace MoipCSharp.Models
{
    #pragma warning disable IDE1006
    public class ClienteResponse
    {
        public string id { get; set; }
        public string ownId { get; set; }
        public string fullname { get; set; }
        public DateTime createdAt { get; set; }
        public string birthDate { get; set; }
        public string email { get; set; }
        public Phone phone { get; set; }
        public Taxdocument taxDocument { get; set; }
        public Shippingaddress shippingAddress { get; set; }
        public _Links _links { get; set; }


        public string status { get; set; }
        public List<Event> events { get; set; }
        public Amount amount { get; set; }
        public string type { get; set; }
        public Refundinginstrument refundingInstrument { get; set; }
        public Creditcard creditCard { get; set; }
        public Card card { get; set; }
        public string method { get; set; }





        public string platform { get; set; }
        public DateTime updatedAt { get; set; }
        public List<Item> items { get; set; }
        public List<Address> addresses { get; set; }
        public Customer customer { get; set; }
        public object[] payments { get; set; }
        public object[] escrows { get; set; }
        public object[] refunds { get; set; }
        public object[] entries { get; set; }
        public List<Receiver> receivers { get; set; }
    }
}
