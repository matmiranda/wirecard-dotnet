#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class Checkout
    {
        public Paycheckout payCheckout { get; set; }
        public Paycreditcard payCreditCard { get; set; }
        public Payboleto payBoleto { get; set; }
        public Payonlinebankdebititau payOnlineBankDebitItau { get; set; }
    }
}
