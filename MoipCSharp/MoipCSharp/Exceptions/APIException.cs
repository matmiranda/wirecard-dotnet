#pragma warning disable IDE1006

namespace MoipCSharp.Exceptions
{
    public class APIException
    {
        public Error[] errors { get; set; }
    }

    public class Error
    {
        public string code { get; set; }
        public string path { get; set; }
        public string description { get; set; }
        public string message { get; set; }
    }

}
