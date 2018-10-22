using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public class OrdersResponse
    {
        public _Links _links { get; set; }
        public Summary summary { get; set; }
        public List<Order> orders { get; set; }
    }
}