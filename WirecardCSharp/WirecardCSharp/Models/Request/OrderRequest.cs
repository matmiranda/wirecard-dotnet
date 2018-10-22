using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public class OrderRequest
    {
        public string ownId { get; set; }
        public Amount amount { get; set; }
        public List<Item> items { get; set; }
        public Customer customer { get; set; }
        public List<Receiver> receivers { get; set; }
    }
}
