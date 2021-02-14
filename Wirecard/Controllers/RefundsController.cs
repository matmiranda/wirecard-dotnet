using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using Wirecard.Models;
using Wirecard.Exception;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Wirecard.Controllers
{
    //Reembolsos - Refunds
    public partial class RefundsController
    {
        private readonly Http_Client Http_Client;
        public RefundsController(Http_Client _httpClient)
        {
            Http_Client = _httpClient;
        }
        /// <summary>
        /// Reembolsar Pagamento - Refund Payment
        /// </summary>
        /// <param name="body"></param>
        /// <param name="payment_id">Código identificador do pagamento a ser reembolsado. Exemplo: PAY-HL7QRKFEQNHV</param>
        /// <returns></returns>
        public async Task<RefundResponse> RefundPayment(RefundRequest body, string payment_id)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync($"v2/payments/{payment_id}/refunds", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<RefundResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Reembolsar Pedido via Cartão de Crédito - Refund Request by Credit Card
        /// </summary>
        /// <param name="body"></param>
        /// <param name="order_id">Código identificador do pedido a ser reembolsado. Exemplo: ORD-O5DLMAJZPTHV</param>
        /// <returns></returns>
        public async Task<RefundResponse> RefundRequestCreditCard(RefundRequest body, string order_id)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync($"v2/orders/{order_id}/refunds", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<RefundResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Consultar Reembolso - Consult Refund
        /// </summary>
        /// <param name="refund_id">Id do reembolso em formato de hash string(16).</param>
        /// <returns></returns>
        public async Task<RefundResponse> Consult(string refund_id)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"v2/refunds/{refund_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<RefundResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Listar Reembolsos do Pagamento - List Payment Refunds
        /// </summary>
        /// <param name="payment_id">Id do pagamento em formato de hash string(16).</param>
        /// <returns></returns>
        public async Task<List<RefundResponse>> ListPayments(string payment_id)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"v2/payments/{payment_id}/refunds");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<List<RefundResponse>>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Listar Reembolsos do Pedido - List Order Reimbursements
        /// </summary>
        /// <param name="orders_id">Id do pedido em formato de hash. string(16).</param>
        /// <returns></returns>
        public async Task<List<RefundResponse>> ListOrders(string orders_id)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"v2/orders/{orders_id}/refunds");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<List<RefundResponse>>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}