using MoipCSharp.Exception;
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
        public static async Task<TransferenciaResponse> CriarTransferencia(HttpClient httpClient, CriarTransferenciaRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync("v2/transfers", stringContent);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "Error Code != 200", content, response.StatusCode, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<TransferenciaResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<ReverterTransferenciaResponse> ReverterTransferencia(HttpClient httpClient, string transfer_id)
        {
            HttpResponseMessage response = await httpClient.PostAsync($"v2/transfers/{transfer_id}/reverse", null);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "Error Code != 200", content, response.StatusCode, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<ReverterTransferenciaResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<TransferenciaResponse> ConsultarTransferencia(HttpClient httpClient, string transfer_id)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"v2/transfers/{transfer_id}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "Error Code != 200", content, response.StatusCode, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<TransferenciaResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<TransferenciasResponse> ListarTodasTransferencias(HttpClient httpClient)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"v2/orders");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "Error Code != 200", content, response.StatusCode, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<TransferenciasResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
    }
}
