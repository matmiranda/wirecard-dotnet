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
    public partial class PagamentosController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static PagamentosController instance = null;
        internal static PagamentosController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new PagamentosController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        public async Task<PagamentoResponse> CriarPagamento(CriarPagamentoRequest body, string order_id)
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
                return JsonConvert.DeserializeObject<PagamentoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public async Task<CustodiaResponse> LiberarCustodia(string escrow_id)
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
                return JsonConvert.DeserializeObject<CustodiaResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public async Task<PagamentoPreAutorizadoResponse> CapturarPagamentoPreAutorizado(string payment_id)
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
                return JsonConvert.DeserializeObject<PagamentoPreAutorizadoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public async Task<PagamentoPreAutorizadoResponse> CancelarPagamentoPreAutorizado(string payment_id)
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
                return JsonConvert.DeserializeObject<PagamentoPreAutorizadoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public async Task<PagamentoResponse> ConsultarPagamento(string payment_id)
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
                return JsonConvert.DeserializeObject<PagamentoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public async Task<HttpStatusCode> SimularPagamentos(string payment_id, int valor)
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
