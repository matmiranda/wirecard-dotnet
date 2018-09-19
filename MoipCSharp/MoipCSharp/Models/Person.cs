#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class Person
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public string birthDate { get; set; }
        public Taxdocument taxDocument { get; set; }
        public Identitydocument identityDocument { get; set; }
        public Phone phone { get; set; }
        public Address address { get; set; }
        public Parentsname parentsName { get; set; }
    }
}
