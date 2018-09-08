using Newtonsoft.Json;
using System.Net.Http;
using MoipCSharp.Models;
using MoipCSharp.Exception;
using System.Threading.Tasks;
using System.Text;
using System.Net;

namespace MoipCSharp.Controllers
{
    public partial class NotificacoesController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static NotificacoesController instance = null;
        internal static NotificacoesController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new NotificacoesController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        public async Task<PreferenciaNotificacaoContaMoipResponse> CriarPreferenciaNotificacaoContaMoip(CriarPreferenciaNotificacaoContaMoipRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PostAsync("v2/preferences/notifications", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PreferenciaNotificacaoContaMoipResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public async Task<PreferenciaNotificacaoAppResponse> CriarPreferenciaNotificacaoApp(CriarPreferenciaNotificacaoAppRequest body, string app_id)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PostAsync($"v2/preferences/{app_id}/notifications", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PreferenciaNotificacaoAppResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public async Task<PreferenciaNotificacaoResponse> ConsultarPreferenciaNotificacao(string notification_id)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/preferences/notifications/{notification_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PreferenciaNotificacaoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public async Task<PreferenciasNotificacaoResponse> ListarTodasPreferenciasNotificacao()
        {
            HttpResponseMessage response = await ClientInstance.GetAsync("v2/preferences/notifications");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PreferenciasNotificacaoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public async Task<HttpStatusCode> RemoverPreferenciaNotificacao(string notification_id)
        {
            HttpResponseMessage response = await ClientInstance.DeleteAsync($"v2/preferences/notifications/{notification_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return response.StatusCode;
        }
        public async Task<WebhookEnviadoResponse> ConsultarWebhookEnviado(string payment_id)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/webhooks?resourceId={payment_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<WebhookEnviadoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public async Task<WebhooksEnviadosResponse> ListarTodosWebhooksEnviados()
        {
            HttpResponseMessage response = await ClientInstance.GetAsync("v2/webhooks");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<WebhooksEnviadosResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
