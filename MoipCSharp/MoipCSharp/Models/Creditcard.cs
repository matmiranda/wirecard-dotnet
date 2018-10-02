#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class Creditcard
    {
        public string id { get; set; }
        public string brand { get; set; }
        public string first6 { get; set; }
        public string last4 { get; set; }
        public bool store { get; set; }
        public string expirationMonth { get; set; }
        public string expirationYear { get; set; }
        public string number { get; set; }
        public string cvc { get; set; }
        public Holder holder { get; set; }
        public string hash { get; set; }
        public Phone phone { get; set; }
    }
}
