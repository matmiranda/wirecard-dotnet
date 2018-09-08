using System;
using System.Net.Http;

namespace MoipCSharp
{
    internal class BaseAddress
    {
        internal const string SANDBOX = "https://sandbox.moip.com.br/"; //teste
        internal const string PRODUCTION = "https://api.moip.com.br/";  //produção
    }
    public enum Environments
    {
        SANDBOX,
        PRODUCTION,
    }

    internal class _HttpClient
    {
        internal static HttpClient httpClient = null;
        internal static string accesstoken = string.Empty;
        internal static string uri = string.Empty;

        internal static HttpClient Client()
        {
            if (httpClient == null)
            {
                try
                {
                    httpClient = new HttpClient();
                    httpClient.DefaultRequestHeaders.Clear();
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accesstoken);
                    httpClient.BaseAddress = new Uri(uri);
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
            return httpClient;
        }
    }
}