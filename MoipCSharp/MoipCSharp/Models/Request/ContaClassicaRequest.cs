#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class ContaClassicaRequest
    {
        public Email email { get; set; }
        public Person person { get; set; }
        public Company company { get; set; }
        public Businesssegment businessSegment { get; set; }
        public string type { get; set; }
    }
}
