#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class Refundinginstrument
    {
        public Creditcard creditCard { get; set; }
        public string method { get; set; }
        public Moipaccount moipAccount { get; set; }
        public Bankaccount bankAccount { get; set; }
    }
}
