using Newtonsoft.Json;
using System.Net.Http;
using MoipCSharp.Models;
using MoipCSharp.Exception;
using System.Threading.Tasks;
using System.Text;
using System.Net;
using System.Collections.Generic;

namespace MoipCSharp.Controllers
{
    //Contas Bancárias  - Bank Accounts
    public partial class BankAccountsController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static BankAccountsController instance = null;
        internal static BankAccountsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new BankAccountsController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern
        /// <summary>
        /// Criar conta bancária - create bank account
        /// </summary>
        /// <param name="body"></param>
        /// <param name="accesstoken">accesstoken da conta que receberá a conta bancária</param>
        /// <param name="account_id">Código identificador da conta Moip. Exemplo: MPA-3C5358FF2296</param>
        /// <returns></returns>
        public async Task<BankAccountResponse> Create(BankAccountRequest body, string accesstoken, string account_id)
        {
            HttpClient httpClient = ClientInstance;
            httpClient.DefaultRequestHeaders.Remove("Authorization");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accesstoken);
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync($"v2/accounts/{account_id}/bankaccounts", stringContent);
            httpClient.DefaultRequestHeaders.Remove("Authorization");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + _HttpClient.accesstoken);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.MoipError moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<BankAccountResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Consultar conta bancária - consult bank account
        /// </summary>
        /// <param name="accesstoken">accesstoken da conta que receberá a conta bancária</param>
        /// <param name="bank_account_id">Identificador da conta bancária.</param>
        /// <returns></returns>
        public async Task<BankAccountResponse> Consult(string accesstoken, string bank_account_id)
        {
            HttpClient httpClient = ClientInstance;
            httpClient.DefaultRequestHeaders.Remove("Authorization");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accesstoken);
            HttpResponseMessage response = await httpClient.GetAsync($"v2/bankaccounts/{bank_account_id}");
            httpClient.DefaultRequestHeaders.Remove("Authorization");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + _HttpClient.accesstoken);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.MoipError moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<BankAccountResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Listar conta bancária - bank account list
        /// </summary>
        /// <param name="accesstoken">accesstoken da conta que receberá a conta bancária</param>
        /// <param name="account_id">Código identificador da Conta Moip. Exemplo: MPA-05E8C79EAAAA</param>
        /// <returns></returns>
        public async Task<List<BankAccountResponse>> List(string accesstoken, string account_id)
        {
            HttpClient httpClient = ClientInstance;
            httpClient.DefaultRequestHeaders.Remove("Authorization");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accesstoken);
            HttpResponseMessage response = await httpClient.GetAsync($"v2/accounts/{account_id}/bankaccounts");
            httpClient.DefaultRequestHeaders.Remove("Authorization");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + _HttpClient.accesstoken);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.MoipError moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<List<BankAccountResponse>>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Deletar conta bancária - delete bank account
        /// </summary>
        /// <param name="accesstoken">accesstoken da conta que receberá a conta bancária</param>
        /// <param name="account_id">Identificador da conta bancária (BKA-XXXXXXXXXX)</param>
        /// <returns></returns>
        public async Task<HttpStatusCode> Delete(string accesstoken, string account_id)
        {
            HttpClient httpClient = ClientInstance;
            httpClient.DefaultRequestHeaders.Remove("Authorization");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accesstoken);
            HttpResponseMessage response = await httpClient.GetAsync($"v2/accounts/{account_id}/bankaccounts");
            httpClient.DefaultRequestHeaders.Remove("Authorization");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + _HttpClient.accesstoken);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.MoipError moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return response.StatusCode;
        }
        /// <summary>
        /// Atualizar conta bancária - update bank account
        /// </summary>
        /// <param name="body"></param>
        /// <param name="accesstoken">accesstoken da conta que receberá a conta bancária</param>
        /// <param name="bankaccount_id">Identificador da conta bancária (BKA-XXXXXXXXX).</param>
        /// <returns></returns>
        public async Task<BankAccountResponse> Update(BankAccountRequest body, string accesstoken, string bankaccount_id)
        {
            HttpClient httpClient = ClientInstance;
            httpClient.DefaultRequestHeaders.Remove("Authorization");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accesstoken);
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PutAsync($"v2/bankaccounts/{bankaccount_id}", stringContent);
            httpClient.DefaultRequestHeaders.Remove("Authorization");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + _HttpClient.accesstoken);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.MoipError moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<BankAccountResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
