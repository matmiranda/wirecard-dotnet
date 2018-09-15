using System.Collections.Generic;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class AtualizarClienteRequest
    {
        public string ownId { get; set; }
        public Amount amount { get; set; }
        public List<Item> items { get; set; }
        public Customer customer { get; set; }
        public Phone phone { get; set; }
    }
}
