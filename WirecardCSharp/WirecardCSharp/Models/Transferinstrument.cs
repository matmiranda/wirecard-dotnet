using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Transferinstrument
    {
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string method { get => Method; set => value = Method; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Bankaccount bankAccount { get => BankAccount; set => value = BankAccount; }
        [Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Moipaccount moipAccount { get => MoipAccount; set => value = MoipAccount; }
    }
    public partial class Transferinstrument
    {
        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Method { get; set; }
        [JsonProperty("bankAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Bankaccount BankAccount { get; set; }
        [JsonProperty("moipAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Moipaccount MoipAccount { get; set; }
    }
}
