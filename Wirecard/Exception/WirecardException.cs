using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wirecard.Exception
{
    public class WirecardException : System.Exception
    {
        public class WirecardError
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
        public WirecardError wirecardError { get; set; }
        public string contentFromWirecard { get; set; }
        public int statusCode { get; set; }

        public WirecardException(WirecardError wirecardError_, string message, string contentFromWirecard, int statusCode) : base(message)
        {
            HelpLink = "https://dev.wirecard.com.br/v2.0/reference#erros-2";
            this.contentFromWirecard = contentFromWirecard;
            this.statusCode = statusCode;
            wirecardError = wirecardError_;
        }

        internal static WirecardError DeserializeObject(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<WirecardError>(json);
            }
            catch
            {
                return new WirecardError();
            }
        }
    }
}