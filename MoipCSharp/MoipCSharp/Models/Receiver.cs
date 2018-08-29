#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class Receiver
    {
        public string type { get; set; }
        public bool feePayor { get; set; }
        public Moipaccount moipAccount { get; set; }
        public Amount amount { get; set; }
    }
}
