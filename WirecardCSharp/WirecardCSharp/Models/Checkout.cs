using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Checkout
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Paycheckout payCheckout { get => PayCheckout; set => value = PayCheckout; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Paycreditcard payCreditCard { get => PayCreditCard; set => value = PayCreditCard; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Payboleto payBoleto { get => PayBoleto; set => value = PayBoleto; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Payonlinebankdebititau payOnlineBankDebitItau { get => PayOnlineBankDebitItau; set => value = PayOnlineBankDebitItau; }
    }
    public partial class Checkout
    {
        [JsonProperty("payCheckout", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Paycheckout PayCheckout { get; set; }
        [JsonProperty("payCreditCard", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Paycreditcard PayCreditCard { get; set; }
        [JsonProperty("payBoleto", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Payboleto PayBoleto { get; set; }
        [JsonProperty("payOnlineBankDebitItau", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Payonlinebankdebititau PayOnlineBankDebitItau { get; set; }
    }
}
