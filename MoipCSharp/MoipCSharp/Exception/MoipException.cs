using Newtonsoft.Json;
using System.Collections.Generic;
#pragma warning disable IDE1006

namespace MoipCSharp.Exception
{
    public class MoipException : System.Exception
    {
        //trocar APIException por MoipError
        public class MoipError
        {
            public string error { get; set; }
            public string message { get; set; }
            public List<Errors> errors { get; set; }
        }

        public class Errors
        {
            public string code { get; set; }
            public string path { get; set; }
            public string description { get; set; }
        }
        public MoipError moipError { get; set; }
        public string contentFromMoip { get; set; }
        public int statusCode { get; set; }

        public MoipException(MoipError moipError_, string message, string contentFromMoip, int statusCode) : base(message)
        {
            HelpLink = "https://dev.moip.com.br/v2.0/reference#erros-2";
            this.contentFromMoip = contentFromMoip;
            this.statusCode = statusCode;
            moipError = moipError_;
        }

        internal static MoipError DeserializeObject(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<MoipError>(json);
            }
            catch
            {
                return new MoipError();
            }
        }
    }
}
