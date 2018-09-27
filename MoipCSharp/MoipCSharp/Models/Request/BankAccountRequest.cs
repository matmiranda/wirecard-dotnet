#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class BankAccountRequest
    {
        public string bankNumber { get; set; }
        public string agencyNumber { get; set; }
        public string agencyCheckNumber { get; set; }
        public string accountNumber { get; set; }
        public string accountCheckNumber { get; set; }
        public string @type { get; set; }
        public Holder holder { get; set; }
    }
}
