#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class ListarTodasContasBancariasResponse
    {
        public Summary summary { get; set; }
        public Bankaccount[] bankAccounts { get; set; }
        public _Links _links { get; set; }
    }
}
