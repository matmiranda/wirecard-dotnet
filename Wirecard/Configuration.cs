using System;
using System.Net.Http;
using System.Text;
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
    public class Http_Client
    {
        public readonly string Accesstoken;
        public readonly string BusinessType;
        public readonly Environments SelectedEnvironment;
        public Http_Client(Environments selectedEnvironment, string accesstoken, string businessType)
        {
            Accesstoken = accesstoken;
            SelectedEnvironment = selectedEnvironment;
            BusinessType = businessType;
        }

        // HttpClient para base https://sandbox.moip.com.br/ ou https://api.moip.com.br/
        // HttpClient_Connect para base https://connect-sandbox.moip.com.br ou https://connect.moip.com.br/
        // accesstoken para MarketPlace
        // base64 para E-Commerce
        // BusinessType: tipo de negócio escolhido (MARKETPLACE ou E-COMMERCE)
        // SelectedEnvironment: Ambiente Selecionado (SANDBOX ou PRODUCTION)
        // Client() == HttpClient
        // Client_Connect == HttpClient_Connect
        // GetVersion(): para obter a versão do pacote Wirecard, definir a versão manualmente 

        public HttpClient HttpClient
        {
            get
            {
                try
                {
                    HttpClient HttpClient = new HttpClient();
                    HttpClient.DefaultRequestHeaders.Clear();
                    HttpClient.DefaultRequestHeaders.Add("Accept", "application/json");
                    HttpClient.DefaultRequestHeaders.Add("User-Agent", $"Wirecard{GetVersion()}");
                    string uri = SelectedEnvironment == Environments.SANDBOX ? BaseAddress.SANDBOX : BaseAddress.PRODUCTION;
                    if (BusinessType == "MARKETPLACE")
                    {
                        HttpClient.BaseAddress = new Uri(uri);
                        HttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {Accesstoken}");
                    }
                    else
                    {
                        HttpClient.BaseAddress = new Uri(uri);
                        HttpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {Accesstoken}");
                    }
                    return HttpClient;
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
        }
        public HttpClient HttpClient_Connect
        {
            get
            {
                try
                {
                    HttpClient HttpClient_Connect = new HttpClient();
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
                    return HttpClient_Connect;
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
        }
        public string GetVersion()
        {
            //for .NET Standard 2.0
            //return FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;

            //for .NET Standard 1.2 - write the version number manually.
            return "3.1.9";
        }
    }
}