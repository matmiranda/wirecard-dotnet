using System.Net.Http;

namespace MoipCSharp.Controllers
{
    public partial class BaseController
    {
        private static HttpClient httpClient = null;
        private static object syncObject = new object();
        public static HttpClient ClientInstance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == httpClient)
                    {
                        httpClient = _HttpClient.Client();
                    }
                    return httpClient;
                }
            }
            set
            {
                lock (syncObject)
                {
                    if (value is HttpClient)
                    {
                        httpClient = value;
                    }
                }
            }
        }
    }
}
