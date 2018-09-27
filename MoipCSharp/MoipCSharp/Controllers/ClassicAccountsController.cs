using Newtonsoft.Json;
using System.Net.Http;
using MoipCSharp.Models;
using MoipCSharp.Exception;
using System.Threading.Tasks;
using System.Net;
using System;

namespace MoipCSharp.Controllers
{
    //Contas Clássicas - Classic Accounts
    public partial class ClassicAccountsController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static ClassicAccountsController instance = null;
        internal static ClassicAccountsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ClassicAccountsController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        //Conta Existe - Account Exist
        public async Task<HttpStatusCode> AccountExist(string email_document)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/accounts/exists?{(email_document.Contains("@") ? "email" : "tax_document")}={email_document}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return response.StatusCode;
        }
        //Cria a conta clássica - Create the classic account
        public async Task<ClassAccountResponse> Create(ClassicAccountRequest body)
        {
            HttpResponseMessage response = await ClientInstance.PostAsync("v2/accounts", null);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<ClassAccountResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        //Consulta a conta clássica - Consult Classic Account
        public async Task<ClassAccountResponse> Consult(string account_id)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/accounts/{account_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<ClassAccountResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        //Solicita Permissões de Acesso ao Usuário - Request User Access Permissions
        public async Task<string> RequestUserAccessPermissions(string response_type, string client_id, string redirect_uri, string scope)
        {
            HttpClient httpClient = ClientInstance;
            httpClient.BaseAddress = new Uri("https://connect-sandbox.moip.com.br/");
            HttpResponseMessage response = await httpClient.GetAsync($"oauth/authorize?response_type={response_type}&client_id={client_id}&redirect_uri={redirect_uri}&scope={scope}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return await response.Content.ReadAsStringAsync();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        //Gera Access Token - Generate Access Token
        public async Task<AccessTokenResponse> GenerateAccessToken(string client_id, string client_secret, string redirect_uri, string grant_type, string code)
        {
            HttpClient httpClient = ClientInstance;
            httpClient.BaseAddress = new Uri("https://connect-sandbox.moip.com.br/");
            HttpResponseMessage response = await httpClient.PostAsync($"oauth/token?client_id={client_id}&client_secret={client_secret}&redirect_uri={redirect_uri}&grant_type{grant_type}&code={code}", null);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<AccessTokenResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        //Atualiza access token - Update accessToken
        public async Task<AccessTokenResponse> UpdateAccessToken(string grant_type, string refresh_token)
        {
            HttpClient httpClient = ClientInstance;
            httpClient.BaseAddress = new Uri("https://connect-sandbox.moip.com.br/");
            HttpResponseMessage response = await httpClient.PostAsync($"oauth/token?grant_type={grant_type}&refresh_token={refresh_token}", null);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<AccessTokenResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        //Obtem a chave pública - Get public key
        public async Task<PublicKeyAccountMoipResponse> GetPublickey()
        {
            HttpResponseMessage response = await ClientInstance.GetAsync("v2/keys");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PublicKeyAccountMoipResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
    }
}
