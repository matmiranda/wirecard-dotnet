using System.Collections.Generic;

namespace WirecardCSharp.Models
{
    public class TransfersResponse
    {
        public Summary summary { get; set; }
        public List<Transfer> transfers { get; set; }
        public _Links _links { get; set; }
    }
}