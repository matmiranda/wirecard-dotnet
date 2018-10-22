namespace WirecardCSharp.Models
{
    public class PaymentRequest
    {
        public int installmentCount { get; set; }
        public string statementDescriptor { get; set; }
        public Fundinginstrument fundingInstrument { get; set; }
        public Device device { get; set; }
    }
}
