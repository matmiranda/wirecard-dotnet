using System.Collections.Generic;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class TransferenciasResponse
    {
        public Summary summary { get; set; }
        public List<Transfer> transfers { get; set; }
        public _Links _links { get; set; }
    }
}
