#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class MultiPagamentoRequest
    {
        public int installmentCount { get; set; }
        public Fundinginstrument fundingInstrument { get; set; }
    }
}
