using System;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using WirecardCSharp.Models;
using System.Threading.Tasks;
using WirecardCSharp.Exception;
using System.Collections.Generic;

namespace WirecardCSharp.Controllers
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

        /// <summary>
        /// Conta Existe - Account Exist
        /// </summary>
        /// <param name="email_document">email ou documento (cpf/cnpj)</param>
        /// <returns></returns>
        public async Task<HttpStatusCode> AccountExist(string email_document)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/accounts/exists?{(email_document.Contains("@") ? "email" : "tax_document")}={email_document}");
            return response.StatusCode;
        }
        /// <summary>
        /// Cria a conta clássica - Create the classic account
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<ClassAccountResponse> Create(ClassicAccountRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PostAsync("v2/accounts", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        /// <summary>
        /// Consulta a conta clássica - Consult Classic Account
        /// </summary>
        /// <param name="account_id">ID da Conta Wirecard. Exemplo: MPA-3C5358FF2296</param>
        /// <returns></returns>
        public async Task<ClassAccountResponse> Consult(string account_id)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/accounts/{account_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        /// <summary>
        /// Gera Access Token - Generate Access Token
        /// </summary>
        /// <param name="client_id">Código identificador do aplicativo que está realizando a solicitação. Exemplo: APP-M11STAPPOAU</param>
        /// <param name="client_secret">Chave privada do aplicativo. O atributo secret que foi enviado na criação do seu aplicativo</param>
        /// <param name="redirect_uri">URL de redirecionamento do cliente (deve ser a mesma utilizada na ação de solicitação de permissão).</param>
        /// <param name="grant_type">Tipo de solicitação desejada. Valores possíveis: authorization_code</param>
        /// <param name="code">Código de validação para recuperar o token de acesso. Esse é o code retornado para a URL cadastrada quando o usuário dá autorização de permissão.</param>
        /// <returns></returns>
        public async Task<AccessTokenResponse> GenerateAccessToken(string client_id, string client_secret, string redirect_uri, string grant_type, string code)
        {
            Dictionary<string, string> @params = new Dictionary<string, string>
            {
                { "client_id", client_id },
                { "client_secret", client_secret },
                { "redirect_uri", redirect_uri },
                { "grant_type", grant_type },
                { "code", code },
            };
            FormUrlEncodedContent encodedContent = new FormUrlEncodedContent(@params);
            HttpClient httpClient = ConnectClientInstance;
            HttpResponseMessage response = await httpClient.PostAsync($"oauth/token", encodedContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        /// <summary>
        /// Atualiza access token - Update accessToken
        /// </summary>
        /// <param name="grant_type">Tipo de solicitação desejada. Valores possíveis: refresh_token</param>
        /// <param name="refresh_token">Token para atualizar o token de autenticação</param>
        /// <returns></returns>
        public async Task<AccessTokenResponse> UpdateAccessToken(string grant_type, string refresh_token)
        {
            Dictionary<string, string> @params = new Dictionary<string, string>
            {
                { "grant_type", grant_type },
                { "refresh_token", refresh_token }
            };
            FormUrlEncodedContent encodedContent = new FormUrlEncodedContent(@params);
            HttpClient httpClient = ConnectClientInstance;
            HttpResponseMessage response = await httpClient.PostAsync($"oauth/token", encodedContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        /// <summary>
        /// Obtem a chave pública - Get public key
        /// </summary>
        /// <returns></returns>
        public async Task<PublicKeyAccountWirecardResponse> GetPublickey()
        {
            HttpResponseMessage response = await ClientInstance.GetAsync("v2/keys");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PublicKeyAccountWirecardResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
    }
}
