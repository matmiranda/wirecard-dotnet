using Newtonsoft.Json;
using System;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class ListarTodasContasBancariasResponse
    {
        public string id { get; set; }
        public string agencyNumber { get; set; }
        public string accountNumber { get; set; }
        public Holder holder { get; set; }
        public string status { get; set; }
        public DateTime createdAt { get; set; }
        public string accountCheckNumber { get; set; }
        public _Links _links { get; set; }
        public string bankName { get; set; }
        public string type { get; set; }
        public string agencyCheckNumber { get; set; }
        public string bankNumber { get; set; }
    }
}
