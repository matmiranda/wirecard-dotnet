using System.Collections.Generic;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class PedidoRequest
    {
        public string ownId { get; set; }
        public Amount amount { get; set; }
        public List<Item> items { get; set; }
        public Customer customer { get; set; }
        public List<Receiver> receivers { get; set; }
    }
}
