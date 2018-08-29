#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class CriarMultiPedidoRequest
    {
        public string ownId { get; set; }
        public Order[] orders { get; set; }
    }
}
