using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class PaymentRequest
    {
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int installmentCount { get => InstallmentCount; set => InstallmentCount = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string statementDescriptor { get => StatementDescriptor; set => StatementDescriptor = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Fundinginstrument fundingInstrument { get => FundingInstrument; set => FundingInstrument = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public Device device { get => Device; set => Device = value; }
    }
    public partial class PaymentRequest
    {
        [JsonProperty("installmentCount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int InstallmentCount { get; set; }
        [JsonProperty("statementDescriptor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StatementDescriptor { get; set; }
        [JsonProperty("fundingInstrument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Fundinginstrument FundingInstrument { get; set; }
        [JsonProperty("device", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Device Device { get; set; }
    }
}
