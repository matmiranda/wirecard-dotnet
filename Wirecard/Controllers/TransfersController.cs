using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using Wirecard.Models;
using Wirecard.Exception;
using System.Threading.Tasks;

namespace Wirecard.Controllers
{
    //Transferências - Transfers
    public partial class TransfersController
    {
        private readonly Http_Client Http_Client;
        public TransfersController(Http_Client _httpClient)
        {
            Http_Client = _httpClient;
        }
        /// <summary>
        /// Criar Transferência - Create Transfer
        /// </summary>
        /// <param name="body"></param>
        /// <param name="accesstoken">accesstoken da conta Wirecard</param>
        /// <returns></returns>
        public async Task<TransferResponse> Create(TransferRequest body, string accesstoken)
        {
            HttpClient httpClient = Http_Client.HttpClient;
            httpClient.DefaultRequestHeaders.Remove("Authorization");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accesstoken);
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync("v2/transfers", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        /// <param name="accesstoken">accesstoken da conta Wirecard a qual foi destinatária da transferência</param>
        /// <returns></returns>
        public async Task<TransferResponse> Revert(string transfer_id, string accesstoken)
        {
            HttpClient httpClient = Http_Client.HttpClient;
            httpClient.DefaultRequestHeaders.Remove("Authorization");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accesstoken);
            StringContent stringContent = new StringContent(string.Empty, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync($"v2/transfers/{transfer_id}/reverse", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        /// <param name="accesstoken">accesstoken da conta Wirecard</param>
        /// <returns></returns>
        public async Task<TransferResponse> Consult(string transfer_id, string accesstoken)
        {
            HttpClient httpClient = Http_Client.HttpClient;
            httpClient.DefaultRequestHeaders.Remove("Authorization");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accesstoken);
            HttpResponseMessage response = await httpClient.GetAsync($"v2/transfers/{transfer_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"v2/transfers");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"v2/transfers?{filter}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
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