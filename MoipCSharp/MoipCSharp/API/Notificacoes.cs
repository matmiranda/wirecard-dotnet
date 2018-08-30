using MoipCSharp.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MoipCSharp
{
    public static class Notificacoes
    {
        public static async Task<CriarPreferenciaDeNotificacaoParaContaMoipResponse> CriarPreferenciaDeNotificacaoParaContaMoipAsync(CriarPreferenciaDeNotificacaoParaContaMoipRequest body)
        {
            HttpClient httpClient = Configuration.HttpClient();
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync("v2/preferences/notifications", stringContent);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Configuration.DeserializeObject(await response.Content.ReadAsStringAsync());
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<CriarPreferenciaDeNotificacaoParaContaMoipResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<CriarPreferenciaDeNotificacaoParaAppResponse> CriarPreferenciaDeNotificacaoParaAppAsync(CriarPreferenciaDeNotificacaoParaAppRequest body, string app_id)
        {
            HttpClient httpClient = Configuration.HttpClient();
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync($"v2/preferences/{app_id}/notifications", stringContent);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Configuration.DeserializeObject(await response.Content.ReadAsStringAsync());
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<CriarPreferenciaDeNotificacaoParaAppResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<ConsultarPreferenciaDeNotificacaoResponse> ConsultarPreferenciaDeNotificacaoAsync(string notification_id)
        {
            HttpClient httpClient = Configuration.HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync($"v2/preferences/notifications/{notification_id}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Configuration.DeserializeObject(await response.Content.ReadAsStringAsync());
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<ConsultarPreferenciaDeNotificacaoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<ListarTodasAsPreferenciasDeNotificacaoResponse> ListarTodasAsPreferenciasDeNotificacaoAsync()
        {
            HttpClient httpClient = Configuration.HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("v2/preferences/notifications");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Configuration.DeserializeObject(await response.Content.ReadAsStringAsync());
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<ListarTodasAsPreferenciasDeNotificacaoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<HttpStatusCode> RemoverPreferenciaDeNotificacaoAsync(string notification_id)
        {
            HttpClient httpClient = Configuration.HttpClient();
            HttpResponseMessage response = await httpClient.DeleteAsync($"v2/preferences/notifications/{notification_id}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Configuration.DeserializeObject(await response.Content.ReadAsStringAsync());
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            return response.StatusCode;
        }
        public static async Task<ConsultarWebhookEnviadoResponse> ConsultarWebhookEnviadoAsync(string payment_id)
        {
            HttpClient httpClient = Configuration.HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync($"v2/webhooks?resourceId={payment_id}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Configuration.DeserializeObject(await response.Content.ReadAsStringAsync());
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<ConsultarWebhookEnviadoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<ListarTodosOsWebhooksEnviadosResponse> ListarTodosOsWebhooksEnviadosAsync()
        {
            HttpClient httpClient = Configuration.HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("v2/webhooks");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Configuration.DeserializeObject(await response.Content.ReadAsStringAsync());
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<ListarTodosOsWebhooksEnviadosResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
    }
}
