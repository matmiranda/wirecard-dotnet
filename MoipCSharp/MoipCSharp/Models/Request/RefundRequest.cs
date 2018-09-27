#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class RefundRequest
    {
        public string amount { get; set; }
        public Refundinginstrument refundingInstrument { get; set; }
        public Creditcard creditCard { get; set; }
    }
}
