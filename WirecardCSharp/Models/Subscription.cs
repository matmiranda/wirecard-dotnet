using System;
using System.Collections.Generic;
using System.Text;

namespace WirecardCSharp.Models
{
    public class Subscription
    {
        public int amount { get; set; }
        public string code { get; set; }
        public Creation_Date creation_date { get; set; }
        public Expiration_Date expiration_date { get; set; }
        public Trial trial { get; set; }
        public string moip_account { get; set; }
        public string id { get; set; }
        public Invoice invoice { get; set; }
        public Plan plan { get; set; }
        public Next_Invoice_Date next_invoice_date { get; set; }
        public string payment_method { get; set; }
        public string status { get; set; }
        public Customer customer { get; set; }
    }
}