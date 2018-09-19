#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class Company
    {
        public string name { get; set; }
        public string businessName { get; set; }
        public string openingDate { get; set; }
        public Taxdocument taxDocument { get; set; }
        public Mainactivity mainActivity { get; set; }
        public Phone phone { get; set; }
        public Address address { get; set; }
        public string monthlyRevenue { get; set; }
        public string constitutionType { get; set; }
    }
}
