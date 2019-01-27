using System;
using System.Net.Http;

namespace Wirecard
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
        internal static HttpClient httpClient_Connect = null; // para base https://connect-sandbox.moip.com.br
        internal static string accesstoken = string.Empty; //marketplace
        internal static string base64 = string.Empty; //e-commerce
        internal static string BusinessType = null;
        internal static Environments SelectedEnvironment;
        internal static HttpClient Client()
        {
            if (httpClient == null)
            {
                try
                {
                    httpClient = new HttpClient();
                    httpClient.DefaultRequestHeaders.Clear();
                    httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
                    httpClient.DefaultRequestHeaders.Add("User-Agent", $"Wirecard{GetVersion()}");
                    if (accesstoken != string.Empty && base64 == string.Empty)
                    {
                        string uri = SelectedEnvironment == 
                            Environments.SANDBOX ? BaseAddress.SANDBOX : BaseAddress.PRODUCTION;
                        httpClient.BaseAddress = new Uri(uri);
                        httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {accesstoken}");
                    }
                    else
                    {
                        string uri = SelectedEnvironment ==
                            Environments.SANDBOX ? BaseAddress.SANDBOX : BaseAddress.PRODUCTION;
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
        internal static HttpClient Client_Connect()
        {
            if (httpClient_Connect == null)
            {
                try
                {
                    httpClient_Connect = new HttpClient();
                    httpClient_Connect.DefaultRequestHeaders.Clear();
                    httpClient_Connect.DefaultRequestHeaders.Add("Accept", "application/json");
                    httpClient_Connect.DefaultRequestHeaders.Add("User-Agent", $"Wirecard{GetVersion()}");
                    if (SelectedEnvironment == Environments.SANDBOX)
                    {
                        httpClient_Connect.BaseAddress = new Uri("https://connect-sandbox.moip.com.br/");
                    }
                    else
                    {
                        httpClient_Connect.BaseAddress = new Uri("https://connect.moip.com.br/");
                    }
                    httpClient_Connect.DefaultRequestHeaders.Add("Authorization", $"Bearer {accesstoken}");
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
            return httpClient_Connect;
        }

        internal static string GetVersion()
        {
            //for .NET Standard 2.0
            //return FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;

            //for .NET Standard 1.2 - write the version number manually.
            return "3.0.6";
        }
    }
}
