using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MoipCSharp
{
    public class Configuration
    {
        private static HttpClient httpClient = new HttpClient { BaseAddress = new Uri(BaseAddress.SANDBOX) };
        public static class BaseAddress
        {
            public const string SANDBOX = "https://sandbox.moip.com.br/"; //teste
            public const string PRODUCTION = "https://api.moip.com.br/";  //produção
        }

        public static HttpClient HttpClient()
        {
            if (string.IsNullOrEmpty(httpClient.BaseAddress.AbsoluteUri))
            {
                throw new ArgumentException($"Base address is empty.");
            }
            if (httpClient.DefaultRequestHeaders.Authorization == null)
            {
                throw new ArgumentException($"Authentication is empty.");
            }
            return httpClient;
        }
        public static HttpClient SetClient(string token, string baseAddress)
        {
            if (baseAddress != BaseAddress.SANDBOX && baseAddress != BaseAddress.PRODUCTION)
            {
                throw new ArgumentException($"Base address: {baseAddress} is invalid");
            }

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("OAuth", token);
            return httpClient;
        }
    }
}
