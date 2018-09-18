#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class ReembolsoRequest
    {
        public string amount { get; set; }
        public Refundinginstrument refundingInstrument { get; set; }
        public Creditcard creditCard { get; set; }
    }
}
