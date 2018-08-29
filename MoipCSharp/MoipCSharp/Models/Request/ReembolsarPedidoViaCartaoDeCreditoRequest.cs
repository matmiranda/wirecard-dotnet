using System;
using System.Collections.Generic;
using System.Text;

namespace MoipCSharp.Models
{
    public class ReembolsarPedidoViaCartaoDeCreditoRequest
    {
        public string amount { get; set; }
        public Refundinginstrument refundingInstrument { get; set; }
        public Creditcard creditCard { get; set; }
    }
}
