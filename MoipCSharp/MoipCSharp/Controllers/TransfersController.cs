using Newtonsoft.Json;
using System.Net.Http;
using MoipCSharp.Models;
using MoipCSharp.Exception;
using System.Threading.Tasks;
using System.Text;

namespace MoipCSharp.Controllers
{
    //Transferências - Transfers
    public partial class TransfersController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static TransfersController instance = null;
        internal static TransfersController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new TransfersController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        /// <summary>
        /// Criar Transferência - Create Transfer
        /// </summary>
        /// <param name="body"></param>
        /// <param name="accesstoken">accesstoken da conta que receberá a conta bancária</param>
        /// <returns></returns>
        public async Task<TransferResponse> Create(TransferRequest body, string accesstoken)
        {
            HttpClient httpClient = ClientInstance;
            httpClient.DefaultRequestHeaders.Remove("Authorization");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accesstoken);
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync("v2/transfers", stringContent);
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
                return JsonConvert.DeserializeObject<TransferResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Reverter Transferência - Revert Transfer
        /// </summary>
        /// <param name="transfer_id">Código identificador da transferência. Exemplo: TRA-28HRLYNLMUFH</param>
        /// <param name="accesstoken">accesstoken da conta que receberá a conta bancária</param>
        /// <returns></returns>
        public async Task<TransferResponse> Revert(string transfer_id, string accesstoken)
        {
            HttpClient httpClient = ClientInstance;
            httpClient.DefaultRequestHeaders.Remove("Authorization");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accesstoken);
            StringContent stringContent = new StringContent(string.Empty, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync($"v2/transfers/{transfer_id}/reverse", stringContent);
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
                return JsonConvert.DeserializeObject<TransferResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Consultar Transferência - Consult Transfer
        /// </summary>
        /// <param name="transfer_id">Código identificador da transferência. Exemplo: TRA-28HRLYNLMUFH</param>
        /// <param name="accesstoken">accesstoken da conta que receberá a conta bancária</param>
        /// <returns></returns>
        public async Task<TransferResponse> Consult(string transfer_id, string accesstoken)
        {
            HttpClient httpClient = ClientInstance;
            httpClient.DefaultRequestHeaders.Remove("Authorization");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accesstoken);
            HttpResponseMessage response = await httpClient.GetAsync($"v2/transfers/{transfer_id}");
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
                return JsonConvert.DeserializeObject<TransferResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Listar Todas Transferências - List All Transfers
        /// </summary>
        /// <returns></returns>
        public async Task<TransfersResponse> List()
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/orders");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.MoipError moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<TransfersResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Listar Todas Transferências com filtro - List All Transfers with filter
        /// </summary>
        /// <returns></returns>
        public async Task<TransfersResponse> ListFilter(string filter)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/orders?{filter}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.MoipError moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<TransfersResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
