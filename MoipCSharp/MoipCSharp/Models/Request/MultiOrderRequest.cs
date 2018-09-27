using System.Collections.Generic;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class MultiOrderRequest
    {
        public string ownId { get; set; }
        public List<Order> orders { get; set; }
    }
}
