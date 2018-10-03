#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class MultiPaymentRequest
    {
        public int installmentCount { get; set; }
        public Fundinginstrument fundingInstrument { get; set; }
    }
}
