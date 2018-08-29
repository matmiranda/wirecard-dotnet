#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class ListarTodosOsPedidosResponse
    {
        public _Links _links { get; set; }
        public Summary summary { get; set; }
        public Order[] orders { get; set; }
    }
}
