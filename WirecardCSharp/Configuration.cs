using System;
using System.Net.Http;

namespace WirecardCSharp
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
        internal static string accesstoken = string.Empty; //marketplace
        internal static string base64 = string.Empty; //e-commerce
        internal static string uri = string.Empty;
        internal static string BusinessType = null;
        internal static HttpClient Client()
        {
            if (httpClient == null)
            {
                try
                {
                    httpClient = new HttpClient();
                    httpClient.DefaultRequestHeaders.Clear();
                    httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
                    httpClient.DefaultRequestHeaders.Add("User-Agent", $"WirecardCSharp{GetVersion()}");
                    if (accesstoken != string.Empty && base64 == string.Empty)
                    {
                        httpClient.BaseAddress = new Uri(uri);
                        httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {accesstoken}");
                    }
                    else
                    {
                        httpClient.BaseAddress = new Uri(uri);
                        httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {base64}");
                    }
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
            return httpClient;
        }

        internal static string GetVersion()
        {
            //for .NET Standard 2.0
            //return FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;

            //for .NET Standard 1.2 - write the version number manually.
            return "2.0.5";
        }
    }
}