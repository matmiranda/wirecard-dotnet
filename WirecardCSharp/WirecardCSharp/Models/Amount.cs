using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Amount
    {
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string currency { get => Currency; set => Currency = value; }
        public Subtotals subtotals { get => Subtotals; set => Subtotals = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int @fixed { get => Fixed; set => Fixed = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int percentual { get => Percentual; set => Percentual = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int paid { get => Paid; set => Paid = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int total { get => Total; set => Total = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int fees { get => Fees; set => Fees = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int refunds { get => Refunds; set => Refunds = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int liquid { get => Liquid; set => Liquid = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int otherReceivers { get => OtherReceivers; set => OtherReceivers = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int addition { get => Addition; set => Addition = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int deduction { get => Deduction; set => Deduction = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public int gross { get => Gross; set => Gross = value; }
    }
    public partial class Amount
    {
        [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Currency { get; set; }
        public Subtotals Subtotals { get; set; }
        [JsonProperty("fixed", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Fixed { get; set; }
        [JsonProperty("percentual", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Percentual { get; set; }
        [JsonProperty("paid", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Paid { get; set; }
        [JsonProperty("total", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Total { get; set; }
        [JsonProperty("fees", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Fees { get; set; }
        [JsonProperty("refunds", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Refunds { get; set; }
        [JsonProperty("liquid", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Liquid { get; set; }
        [JsonProperty("otherReceivers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int OtherReceivers { get; set; }
        [JsonProperty("addition", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Addition { get; set; }
        [JsonProperty("deduction", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Deduction { get; set; }
        [JsonProperty("gross", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Gross { get; set; }
    }
}
