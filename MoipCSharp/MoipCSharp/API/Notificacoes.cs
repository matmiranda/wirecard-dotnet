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
        public static async Task<CriarPreferenciaNotificacaoContaMoipResponse> CriarPreferenciaNotificacaoContaMoip(HttpClient httpClient, CriarPreferenciaNotificacaoContaMoipRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync("v2/preferences/notifications", stringContent);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<CriarPreferenciaNotificacaoContaMoipResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<CriarPreferenciaNotificacaoAppResponse> CriarPreferenciaNotificacaoApp(HttpClient httpClient, CriarPreferenciaNotificacaoAppRequest body, string app_id)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync($"v2/preferences/{app_id}/notifications", stringContent);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<CriarPreferenciaNotificacaoAppResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<ConsultarPreferenciaDeNotificacaoResponse> ConsultarPreferenciaNotificacao(HttpClient httpClient, string notification_id)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"v2/preferences/notifications/{notification_id}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
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
        public static async Task<ListarTodasPreferenciasNotificacaoResponse> ListarTodasPreferenciasNotificacao(HttpClient httpClient)
        {
            HttpResponseMessage response = await httpClient.GetAsync("v2/preferences/notifications");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<ListarTodasPreferenciasNotificacaoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<HttpStatusCode> RemoverPreferenciaNotificacao(HttpClient httpClient, string notification_id)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync($"v2/preferences/notifications/{notification_id}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            return response.StatusCode;
        }
        public static async Task<ConsultarWebhookEnviadoResponse> ConsultarWebhookEnviado(HttpClient httpClient, string payment_id)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"v2/webhooks?resourceId={payment_id}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
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
        public static async Task<ListarTodosOsWebhooksEnviadosResponse> ListarTodosWebhooksEnviados(HttpClient httpClient)
        {
            HttpResponseMessage response = await httpClient.GetAsync("v2/webhooks");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
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
