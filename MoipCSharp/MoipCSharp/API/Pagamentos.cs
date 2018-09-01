using MoipCSharp.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MoipCSharp
{
    public static class Pagamentos
    {
        public static async Task<CriarPedidoResponse> CriarPagamento(HttpClient httpClient, CriarPagamentoRequest body, string order_id)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync($"v2/orders/{order_id}/payments", stringContent);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<CriarPedidoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<LiberarCustodiaResponse> LiberarCustodia(HttpClient httpClient, string escrow_id)
        {          
            HttpResponseMessage response = await httpClient.PostAsync($"escrows/{escrow_id}/release", null);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<LiberarCustodiaResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<CapturarPagamentoPreAutorizadoResponse> CapturarPagamentoPreAutorizado(HttpClient httpClient, string payment_id)
        {           
            HttpResponseMessage response = await httpClient.PostAsync($"v2/payments/{payment_id}/capture", null);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<CapturarPagamentoPreAutorizadoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<CancelarPagamentoPreAutorizadoResponse> CancelarPagamentoPreAutorizado(HttpClient httpClient, string payment_id)
        {
            HttpResponseMessage response = await httpClient.PostAsync($"v2/payments/{payment_id}/void", null);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<CancelarPagamentoPreAutorizadoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<ConsultarPagamentoResponse> ConsultarPagamento(HttpClient httpClient, string payment_id)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"v2/payments/{payment_id}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<ConsultarPagamentoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<HttpStatusCode> SimularPagamentos(HttpClient httpClient, string payment_id, int valor)
        {
            httpClient.BaseAddress = new Uri("https://sandbox.moip.com.br/");
            HttpResponseMessage response = await httpClient.GetAsync($"simulador/authorize?payment_id={payment_id}&amount={valor}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            return response.StatusCode;
        }
    }
}
