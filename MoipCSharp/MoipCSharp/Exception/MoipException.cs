using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
#pragma warning disable IDE1006

namespace MoipCSharp.Exception
{
    public class MoipException : System.Exception
    {
        public class APIException
        {
            public string message { get; set; }
            public List<Errors> errors { get; set; }
        }

        public class Errors
        {
            public string code { get; set; }
            public string path { get; set; }
            public string description { get; set; }
        }

        public List<Errors> errors { get; set; }
        public string contentFromMoip { get; set; }
        public int statusCode { get; set; }
        public int errorCode { get; set; }

        public MoipException(APIException moipException, string message, string contentFromMoip, int statusCode) : base(message)
        {
            HelpLink = "https://dev.moip.com.br/v2.0/reference#erros-2";
            this.contentFromMoip = contentFromMoip;
            this.statusCode = statusCode;
            errors = moipException.errors;
        }

        internal static APIException DeserializeObject(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<APIException>(json);
            }
            catch
            {
                return new APIException();
            }
        }
    }
}
