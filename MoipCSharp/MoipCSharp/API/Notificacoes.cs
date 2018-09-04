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
    public static class Notificacoes
    {
        public static async Task<PreferenciaNotificacaoContaMoipResponse> CriarPreferenciaNotificacaoContaMoip(HttpClient httpClient, CriarPreferenciaNotificacaoContaMoipRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync("v2/preferences/notifications", stringContent);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "Error Code != 200", content, response.StatusCode, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PreferenciaNotificacaoContaMoipResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<PreferenciaNotificacaoAppResponse> CriarPreferenciaNotificacaoApp(HttpClient httpClient, CriarPreferenciaNotificacaoAppRequest body, string app_id)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync($"v2/preferences/{app_id}/notifications", stringContent);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "Error Code != 200", content, response.StatusCode, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PreferenciaNotificacaoAppResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<PreferenciaNotificacaoResponse> ConsultarPreferenciaNotificacao(HttpClient httpClient, string notification_id)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"v2/preferences/notifications/{notification_id}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "Error Code != 200", content, response.StatusCode, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PreferenciaNotificacaoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<PreferenciasNotificacaoResponse> ListarTodasPreferenciasNotificacao(HttpClient httpClient)
        {
            HttpResponseMessage response = await httpClient.GetAsync("v2/preferences/notifications");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "Error Code != 200", content, response.StatusCode, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PreferenciasNotificacaoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<HttpStatusCode> RemoverPreferenciaNotificacao(HttpClient httpClient, string notification_id)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync($"v2/preferences/notifications/{notification_id}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "Error Code != 200", content, response.StatusCode, (int)response.StatusCode);
            }
            return response.StatusCode;
        }
        public static async Task<WebhookEnviadoResponse> ConsultarWebhookEnviado(HttpClient httpClient, string payment_id)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"v2/webhooks?resourceId={payment_id}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "Error Code != 200", content, response.StatusCode, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<WebhookEnviadoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<WebhooksEnviadosResponse> ListarTodosWebhooksEnviados(HttpClient httpClient)
        {
            HttpResponseMessage response = await httpClient.GetAsync("v2/webhooks");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "Error Code != 200", content, response.StatusCode, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<WebhooksEnviadosResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
    }
}
