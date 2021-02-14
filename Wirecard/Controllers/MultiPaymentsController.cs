using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using Wirecard.Models;
using System.Threading.Tasks;
using Wirecard.Exception;

namespace Wirecard.Controllers
{
    //Multi Pagamentos - Multi Payments
    public partial class MultiPaymentsController
    {
        private readonly Http_Client Http_Client;
        public MultiPaymentsController(Http_Client _httpClient)
        {
            Http_Client = _httpClient;
        }
        /// <summary>
        /// Criar Multi Pagamento - Create multi payment
        /// </summary>
        /// <param name="body"></param>
        /// <param name="multiorder_id">Código identificador do multipedido. Exemplo: MOR-XXXXXXXX</param>
        /// <returns></returns>
        public async Task<MultiPaymentResponse> Create(MultiPaymentRequest body, string multiorder_id)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync($"v2/multiorders/{multiorder_id}/multipayments", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<MultiPaymentResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Consultar Multi Pagamento - Consult 
        /// </summary>
        /// <param name="multiorder_id">Id do multipagamento. string(16).</param>
        /// <returns></returns>
        public async Task<MultiPaymentResponse> Consult(string multiorder_id)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"v2/multipayments/{multiorder_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<MultiPaymentResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Capturar Multi Pagamento Pré-Autorizado - Capture Multi-Payment Pre-authorized
        /// </summary>
        /// <param name="multipayment_id">Id identificador do multipagamento.</param>
        /// <returns></returns>
        public async Task<MultiPaymentResponse> CaptureAuthorized(string multipayment_id)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync($"v2/multipayments/{multipayment_id}/capture", null);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<MultiPaymentResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Cancelar Multi Pagamento Pré-autorizado - Cancel Multi Payment Pre-authorized
        /// </summary>
        /// <param name="multipayment_id">Id identificador do multipagamento</param>
        /// <returns></returns>
        public async Task<MultiPaymentResponse> CancelAuthorized(string multipayment_id)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync($"v2/multipayments/{multipayment_id}/void", null);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<MultiPaymentResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Liberação de Custódia - Release of Custody
        /// </summary>
        /// <param name="escrow_id">Código identificador da custódia. Exemplo: ECW-87E7UUF9N2EK</param>
        /// <returns></returns>
        public async Task<MultiPaymentResponse> ReleaseCustody(string escrow_id)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync($"v2/escrows/{escrow_id}/release", null);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<MultiPaymentResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}