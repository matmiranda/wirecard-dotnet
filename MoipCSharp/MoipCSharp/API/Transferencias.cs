using MoipCSharp.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MoipCSharp
{
    public static class Transferencias
    {
        public static async Task<CriarTransferenciaResponse> CriarTransferenciaAsync(CriarTransferenciaRequest body)
        {
            HttpClient httpClient = Configuration.HttpClient();
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync("v2/transfers", stringContent);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Configuration.DeserializeObject(await response.Content.ReadAsStringAsync());
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<CriarTransferenciaResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<ReverterTransferenciaResponse> ReverterTransferenciaAsync(string transfer_id)
        {
            HttpClient httpClient = Configuration.HttpClient();
            HttpResponseMessage response = await httpClient.PostAsync($"v2/transfers/{transfer_id}/reverse", null);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Configuration.DeserializeObject(await response.Content.ReadAsStringAsync());
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<ReverterTransferenciaResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<ConsultarTransferenciaResponse> ConsultarTransferenciaAsync(string transfer_id)
        {
            HttpClient httpClient = Configuration.HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync($"v2/transfers/{transfer_id}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Configuration.DeserializeObject(await response.Content.ReadAsStringAsync());
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<ConsultarTransferenciaResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<ListarTodasTransferenciasResponse> ListarTodasTransferenciasAsync()
        {
            HttpClient httpClient = Configuration.HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync($"v2/orders");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Configuration.DeserializeObject(await response.Content.ReadAsStringAsync());
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<ListarTodasTransferenciasResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
    }
}
