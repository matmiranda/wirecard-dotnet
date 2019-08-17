using System;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace Wirecard
{
    internal class BaseAddress
    {
        internal const string SANDBOX = "https://sandbox.moip.com.br/";
        internal const string PRODUCTION = "https://api.moip.com.br/";
    }
    public enum Environments
    {
        SANDBOX,
        PRODUCTION,
    }
    internal class Http_Client
    {
        // HttpClient para base https://sandbox.moip.com.br/ ou https://api.moip.com.br/
        // HttpClient_Connect para base https://connect-sandbox.moip.com.br ou https://connect.moip.com.br/
        // accesstoken para MarketPlace
        // base64 para E-Commerce
        // BusinessType: tipo de negócio escolhido (MARKETPLACE ou E-COMMERCE)
        // SelectedEnvironment: Ambiente Selecionado (SANDBOX ou PRODUCTION)
        // Client() == HttpClient
        // Client_Connect == HttpClient_Connect
        // GetVersion(): para obter a versão do pacote Wirecard, definir a versão manualmente 

        internal static HttpClient HttpClient = null;
        internal static HttpClient HttpClient_Connect = null;
        internal static string Accesstoken = string.Empty;
        internal static string Base64 = string.Empty;
        internal static string BusinessType = null;
        internal static Environments SelectedEnvironment;
        internal static HttpClient Client()
        {
            if (HttpClient == null)
            {
                try
                {
                    HttpClient = new HttpClient();
                    HttpClient.DefaultRequestHeaders.Clear();
                    HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
                    HttpClient.DefaultRequestHeaders.Add("User-Agent", $"Wirecard{GetVersion()}");
                    string uri = SelectedEnvironment ==
                        Environments.SANDBOX ? BaseAddress.SANDBOX : BaseAddress.PRODUCTION;
                    if (BusinessType == "MARKETPLACE")
                    {
                        HttpClient.BaseAddress = new Uri(uri);
                        HttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {Accesstoken}");
                    }
                    else
                    {
                        HttpClient.BaseAddress = new Uri(uri);
                        HttpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {Base64}");
                    }
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
            return HttpClient;
        }
        internal static HttpClient Client_Connect()
        {
            if (HttpClient_Connect == null)
            {
                try
                {
                    HttpClient_Connect = new HttpClient();
                    HttpClient_Connect.DefaultRequestHeaders.Clear();
                    HttpClient_Connect.DefaultRequestHeaders.Add("Accept", "application/json");
                    HttpClient_Connect.DefaultRequestHeaders.Add("User-Agent", $"Wirecard{GetVersion()}");
                    if (SelectedEnvironment == Environments.SANDBOX)
                    {
                        HttpClient_Connect.BaseAddress = new Uri("https://connect-sandbox.moip.com.br/");
                    }
                    else
                    {
                        HttpClient_Connect.BaseAddress = new Uri("https://connect.moip.com.br/");
                    }
                    HttpClient_Connect.DefaultRequestHeaders.Add("Authorization", $"Bearer {Accesstoken}");
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
            return HttpClient_Connect;
        }

        internal static string GetVersion()
        {
            //for .NET Standard 2.0
            //return FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;

            //for .NET Standard 1.2 - write the version number manually.
            return "3.1.5";
        }

        internal static void ChangeAccessToken(string accesstoken)
        {
            if (string.IsNullOrEmpty(accesstoken))
                throw new ArgumentException("Token cannot be null");
            var regex = new Regex(@"^[a-zA-Z0-9]{32}_v2$");
            var match = regex.Match(accesstoken);
            if (!match.Success)
                throw new ArgumentException("accesstoken invalid");
            if (HttpClient != null)
            {
                try
                {
                    HttpClient.DefaultRequestHeaders.Remove("Authorization");
                    HttpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accesstoken);
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
