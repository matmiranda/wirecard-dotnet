using MoipCSharp.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MoipCSharp
{
    public static class MultiPedidos
    {
        public static async Task<MultiPedidoResponse> CriarMultiPedido(HttpClient httpClient, CriarMultiPedidoRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync("v2/multiorders", stringContent);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<MultiPedidoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<MultiPedidoResponse> ConsultarMultiPedido(HttpClient httpClient, string multiorder_id)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"v2/multiorders/{multiorder_id}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<MultiPedidoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
    }
}
