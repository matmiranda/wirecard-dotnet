#pragma warning disable IDE1006

namespace MoipCSharp.Models
{
    public class SaldosResponse
    {
        public Unavailable[] unavailable { get; set; }
        public Future[] future { get; set; }
        public Current[] current { get; set; }
    }
}
