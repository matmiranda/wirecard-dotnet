namespace MoipCSharp.Models
{
#pragma warning disable IDE1006
    public class CriarClienteRequest
    {
        public string ownId { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public string birthDate { get; set; }
        public Taxdocument taxDocument { get; set; }
        public Phone phone { get; set; }
        public Shippingaddress shippingAddress { get; set; }
    }
}