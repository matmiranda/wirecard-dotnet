#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class CriarMultiPagamentoRequest
    {
        public int installmentCount { get; set; }
        public Fundinginstrument fundingInstrument { get; set; }
    }
}
