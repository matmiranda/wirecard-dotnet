using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public class MultiOrderRequest
    {
        public string ownId { get; set; }
        public List<Order> orders { get; set; }
    }
}
