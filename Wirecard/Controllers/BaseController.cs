using System.Net.Http;

namespace Wirecard.Controllers
{
    public partial class BaseController
    {
        private static HttpClient httpClient = null;
        private static HttpClient httpClientConnect = null;
        private static object syncObject = new object();
        private static object syncObjectConnect = new object();
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
        public static HttpClient ConnectClientInstance
        {
            get
            {
                lock (syncObjectConnect)
                {
                    if (null == httpClientConnect)
                    {
                        httpClientConnect = _HttpClient.Client_Connect();
                    }
                    return httpClientConnect;
                }
            }
            set
            {
                lock (syncObjectConnect)
                {
                    if (value is HttpClient)
                    {
                        httpClientConnect = value;
                    }
                }
            }
        }
    }
}