using System.Collections.Generic;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class Installment
    {
        public int addition { get; set; }
        public List<int> quantity { get; set; }
        public int amount { get; set; }
        public int number { get; set; }
    }
}
