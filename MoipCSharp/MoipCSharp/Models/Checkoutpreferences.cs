using System.Collections.Generic;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class Checkoutpreferences
    {
        public List<Installment> installments { get; set; }
        public Redirecturls redirectUrls { get; set; }
    }
}
