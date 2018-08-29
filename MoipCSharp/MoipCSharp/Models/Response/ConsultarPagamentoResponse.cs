using System;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class ConsultarPagamentoResponse
    {
        public string id { get; set; }
        public string status { get; set; }
        public bool delayCapture { get; set; }
        public Amount amount { get; set; }
        public int installmentCount { get; set; }
        public string statementDescriptor { get; set; }
        public Fundinginstrument fundingInstrument { get; set; }
        public Fee[] fees { get; set; }
        public Event[] events { get; set; }
        public Receiver[] receivers { get; set; }
        public Device device { get; set; }
        public _Links _links { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
