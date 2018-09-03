using System;

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
    }
}
