using Newtonsoft.Json;
using System.Net.Http;
using MoipCSharp.Models;
using MoipCSharp.Exception;
using System.Threading.Tasks;
using System.Text;
using System.Net;
using System;

namespace MoipCSharp.Controllers
{
    //Pagamentos - Payments
    public partial class PaymentsController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static PaymentsController instance = null;
        internal static PaymentsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new PaymentsController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        //Criar Pagamento - Create Payment
        public async Task<PaymentResponse> Create(PaymentRequest body, string order_id)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PostAsync($"v2/orders/{order_id}/payments", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        //Liberação de Custódia - Release of Custody
        public async Task<PaymentResponse> ReleaseCustody(string escrow_id)
        {
            HttpResponseMessage response = await ClientInstance.PostAsync($"escrows/{escrow_id}/release", null);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        //Capturar Pagamento Pré-autorizado - Capture Pre-authorized Payment
        public async Task<PaymentResponse> CaptureAuthorized(string payment_id)
        {
            HttpResponseMessage response = await ClientInstance.PostAsync($"v2/payments/{payment_id}/capture", null);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        //Cancelar Pagamento Pré-autorizado - Cancelar Pagamento Pré-autorizado
        public async Task<PaymentResponse> CancelAuthorized(string payment_id)
        {
            HttpResponseMessage response = await ClientInstance.PostAsync($"v2/payments/{payment_id}/void", null);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        //Consultar Pagamento - Consult Payment
        public async Task<PaymentResponse> Consult(string payment_id)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/payments/{payment_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        //Simular pagamentos - Simulate Payments
        public async Task<HttpStatusCode> Simulate(string payment_id, int valor)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"simulador/authorize?payment_id={payment_id}&amount={valor}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return response.StatusCode;
        }
    }
}
