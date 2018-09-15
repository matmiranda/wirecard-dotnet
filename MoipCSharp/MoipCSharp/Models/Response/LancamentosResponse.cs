using System;
using System.Collections.Generic;
#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class LancamentosResponse
    {
        public string external_id { get; set; }
        public object[] reschedule { get; set; }
        public DateTime scheduledFor { get; set; }
        public string status { get; set; }
        public Moipaccount moipAccount { get; set; }
        public List<Fee> fees { get; set; }
        public string type { get; set; }
        public int grossAmount { get; set; }
        public int moipAccountId { get; set; }
        public DateTime updatedAt { get; set; }
        public int id { get; set; }
        public Installment installment { get; set; }
        public List<Reference> references { get; set; }
        public string eventId { get; set; }
        public DateTime createdAt { get; set; }
        public string description { get; set; }
        public bool blocked { get; set; }
        public DateTime settledAt { get; set; }
        public int liquidAmount { get; set; }
    }
}
