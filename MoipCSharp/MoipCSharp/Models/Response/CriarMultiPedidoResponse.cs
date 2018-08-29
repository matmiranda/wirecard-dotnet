using System;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class CriarMultiPedidoResponse
    {
        public string id { get; set; }
        public string ownId { get; set; }
        public string status { get; set; }
        public DateTime createdAt { get; set; }
        public string updatedAt { get; set; }
        public Amount amount { get; set; }
        public Order[] orders { get; set; }
        public _Links _links { get; set; }
    }
}
