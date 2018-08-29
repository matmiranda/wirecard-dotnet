using MoipCSharp.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MoipCSharp.Controllers
{
    public static class Reembolsos
    {
        public static async Task<ReembolsarPagamentoResponse> ReembolsarPagamentoAsync(ReembolsarPagamentoRequest body, string payment_id)
        {
            HttpClient httpClient = Configuration.HttpClient();
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync($"v2/payments/{payment_id}/refunds", stringContent);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<ReembolsarPagamentoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<ReembolsarPedidoViaCartaoDeCreditoResponse> ReembolsarPedidoViaCartaoDeCreditoAsync(ReembolsarPedidoViaCartaoDeCreditoRequest body, string order_id)
        {
            HttpClient httpClient = Configuration.HttpClient();
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync($"v2/orders/{order_id}/refunds", stringContent);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<ReembolsarPedidoViaCartaoDeCreditoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<ConsultarReembolsoResponse> ConsultarReembolsoAsync(string refund_id)
        {
            HttpClient httpClient = Configuration.HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync($"v2/refunds/{refund_id}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<ConsultarReembolsoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<ListarReembolsosDoPagamentoResponse> ListarReembolsosDoPagamentoAsync(string payment_id)
        {
            HttpClient httpClient = Configuration.HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync($"v2/payments/{payment_id}/refunds");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<ListarReembolsosDoPagamentoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<ListarReembolsosDoPedidoResponse> ListarReembolsosDoPedidoAsync(string orders_id)
        {
            HttpClient httpClient = Configuration.HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync($"v2/orders/{orders_id}/refunds");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<ListarReembolsosDoPedidoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
    }
}
