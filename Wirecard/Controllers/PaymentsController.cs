using System;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using Wirecard.Models;
using System.Threading.Tasks;
using Wirecard.Exception;

namespace Wirecard.Controllers
{
    //Pagamentos - Payments
    public partial class PaymentsController
    {
        private readonly Http_Client Http_Client;
        public PaymentsController(Http_Client _httpClient)
        {
            Http_Client = _httpClient;
        }
        /// <summary>
        /// Criar Pagamento - Create Payment
        /// </summary>
        /// <param name="body"></param>
        /// <param name="order_id">Código identificador do pedido. Exemplo: ORD-9BAYAVM87YHE</param>
        /// <returns></returns>
        public async Task<PaymentResponse> Create(PaymentRequest body, string order_id)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync($"v2/orders/{order_id}/payments", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PaymentResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Consultar Pagamento - Consult Payment
        /// </summary>
        /// <param name="payment_id">Código identificador do pagamento que deseja consultar. Exemplo: PAY-HL7QRKFEQNHV</param>
        /// <returns></returns>
        public async Task<PaymentResponse> Consult(string payment_id)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"v2/payments/{payment_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PaymentResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        /// <summary>
        /// Liberação de Custódia - Release of Custody
        /// </summary>
        /// <param name="escrow_id">Código identificador da custódia. Exemplo ECW-9OS6FAPR3FD5</param>
        /// <returns></returns>
        public async Task<PaymentResponse> ReleaseCustody(string escrow_id)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync($"escrows/{escrow_id}/release", null);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PaymentResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        /// <summary>
        ///  Capturar Pagamento Pré-autorizado - Capture Pre-authorized Payment
        /// </summary>
        /// <param name="payment_id">Código identificador do pagamento a ser pré-capturado. Exemplo: PAY-U1G2WVBEP19V</param>
        /// <returns></returns>
        public async Task<PaymentResponse> CaptureAuthorized(string payment_id)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync($"v2/payments/{payment_id}/capture", null);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PaymentResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        /// <summary>
        /// Cancelar Pagamento Pré-autorizado - Cancelar Pagamento Pré-autorizado
        /// </summary>
        /// <param name="payment_id">Código identificador do pagamento pré-autorizado a ser cancelado. Exemplo: Exemplo: PAY-U1G2WVBEP19V</param>
        /// <returns></returns>
        public async Task<PaymentResponse> CancelAuthorized(string payment_id)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync($"v2/payments/{payment_id}/void", null);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PaymentResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        /// <summary>
        /// Simular pagamentos - Simulate Payments
        /// </summary>
        /// <param name="payment_id">Código identificador do pagamento que deseja autorizar. Exemplo: PAY-0UBH5IAJ8KHX</param>
        /// <param name="valor">Valor a ser autorizado no pagamento. O formato deve incluir centavos e não deve incluir vírgula. Exemplo: Para autorizar pagamento no valor de R$265 você deve setar o valor 26500</param>
        /// <returns></returns>
        public async Task<HttpStatusCode> Simulate(string payment_id, int valor)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"simulador/authorize?payment_id={payment_id}&amount={valor}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return response.StatusCode;
        }
    }
}