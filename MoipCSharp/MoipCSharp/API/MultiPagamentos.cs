using MoipCSharp.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MoipCSharp
{
    public static class MultiPagamentos
    {
        public static async Task<CriarMultiPagamentoResponse> CriarMultiPagamento(HttpClient httpClient, CriarMultiPagamentoRequest body, string multiorder_id)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync($"v2/multiorders/{multiorder_id}/multipayments", stringContent);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<CriarMultiPagamentoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<ConsultarMultiPagamentoResponse> ConsultarMultiPagamento(HttpClient httpClient, string multiorder_id)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"v2/multipayments/{multiorder_id}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<ConsultarMultiPagamentoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<CapturarMultiPagamentoPreAutorizadoResponse> CapturarMultiPagamentoPreAutorizado(HttpClient httpClient, string multipayment_id)
        {
            HttpResponseMessage response = await httpClient.PostAsync($"v2/multipayments/{multipayment_id}/capture", null);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<CapturarMultiPagamentoPreAutorizadoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<CancelarMultiPagamentoPreAutorizadoResponse> CancelarMultiPagamentoPreAutorizado(HttpClient httpClient, string multipayment_id)
        {
            HttpResponseMessage response = await httpClient.PostAsync($"v2/multipayments/{multipayment_id}/void", null);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<CancelarMultiPagamentoPreAutorizadoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<LiberarCustodiaResponse> LiberarCustodia(HttpClient httpClient, string escrow_id)
        {
            HttpResponseMessage response = await httpClient.PostAsync($"v2/escrows/{escrow_id}/release", null);
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
    }
}
