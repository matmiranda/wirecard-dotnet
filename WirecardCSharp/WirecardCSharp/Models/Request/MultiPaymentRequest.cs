namespace WirecardCSharp.Models
{
    public class MultiPaymentRequest
    {
        public int installmentCount { get; set; }
        public Fundinginstrument fundingInstrument { get; set; }
    }
}
