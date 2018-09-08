using Newtonsoft.Json;
using System.Net.Http;
using MoipCSharp.Models;
using MoipCSharp.Exception;
using System.Threading.Tasks;
using System.Text;
using System.Net;

namespace MoipCSharp.Controllers
{
    public partial class ContasBancariasController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static ContasBancariasController instance = null;
        internal static ContasBancariasController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ContasBancariasController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        public async Task<ContaBancariaResponse> CriarContaBancaria(CriarContaBancariaRequest body, string account_id)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PostAsync($"v2/accounts/{account_id}/bankaccounts", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<ContaBancariaResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> CriarContaBancariaString(CriarContaBancariaRequest body, string account_id)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PostAsync($"v2/accounts/{account_id}/bankaccounts", stringContent);
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<ContaBancariaResponse> ConsultarContaBancaria(string bank_account_id)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/bankaccounts/{bank_account_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<ContaBancariaResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public async Task<ContasBancariasResponse[]> ListarTodasContasBancarias(string account_id)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/accounts/{account_id}/bankaccounts");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<ContasBancariasResponse[]>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public async Task<HttpStatusCode> DeletarContaBancaria(string account_id)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/accounts/{account_id}/bankaccounts");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return response.StatusCode;
        }
        public static async Task<ContaBancariaResponse> AtualizarContaBancaria(AtualizarContaBancariaRequest body, string bankaccount_id)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PutAsync($"v2/bankaccounts/{bankaccount_id}", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<ContaBancariaResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
