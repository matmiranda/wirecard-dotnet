using MoipCSharp.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MoipCSharp
{
    public static class Clientes
    {
        public static async Task<ClienteResponse> CriarClienteAsync(ClienteRequest body)
        {
            HttpClient httpClient = Configuration.HttpClient();
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync($"v2/customers", stringContent);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Configuration.DeserializeObject(await response.Content.ReadAsStringAsync());
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<ClienteResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<CartaoDeCreditoResponse> AdicionarCartaoDeCreditoAsync(CartaoDeCreditoRequest body, string customer_id)
        {
            HttpClient httpClient = Configuration.HttpClient();
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync($"v2/customers/{customer_id}/fundinginstruments", stringContent);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Configuration.DeserializeObject(await response.Content.ReadAsStringAsync());
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<CartaoDeCreditoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<AtualizarClienteResponse> AtualizarClienteAsync(AtualizarClienteRequest body)
        {
            HttpClient httpClient = Configuration.HttpClient();
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync($"v2/orders/", stringContent);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Configuration.DeserializeObject(await response.Content.ReadAsStringAsync());
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<AtualizarClienteResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<HttpStatusCode> DeletarCartaoDeCreditoAsync(string creditcard_id)
        {
            HttpClient httpClient = Configuration.HttpClient();
            HttpResponseMessage response = await httpClient.DeleteAsync($"v2/fundinginstruments/{creditcard_id}");
            return response.StatusCode;
        }
        public static async Task<ClienteResponse> ConsultarClienteAsync(string customer_id)
        {
            HttpClient httpClient = Configuration.HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync($"v2/customers/{customer_id}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Configuration.DeserializeObject(await response.Content.ReadAsStringAsync());
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<ClienteResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<ListarTodosOsClientesResponse> ListarTodosOsClientes()
        {
            HttpClient httpClient = Configuration.HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync($"v2/customers/");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Configuration.DeserializeObject(await response.Content.ReadAsStringAsync());
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<ListarTodosOsClientesResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
    }
}
