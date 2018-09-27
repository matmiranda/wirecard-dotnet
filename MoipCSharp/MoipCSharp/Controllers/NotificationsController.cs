using Newtonsoft.Json;
using System.Net.Http;
using MoipCSharp.Models;
using MoipCSharp.Exception;
using System.Threading.Tasks;
using System.Text;
using System.Net;
using System.Collections.Generic;

namespace MoipCSharp.Controllers
{
    //Notificações - Notifications
    public partial class NotificationsController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static NotificationsController instance = null;
        internal static NotificationsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new NotificationsController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        //Criar Preferência de Notificação para Conta Moip - Create Notification Preference for Moip Account
        public async Task<NotificationResponse> CreatAccountMoip(NotificationRequest body)
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
                return JsonConvert.DeserializeObject<NotificationResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        //Criar Preferência de Notificação para App - Create Notification Preference for App
        public async Task<NotificationResponse> CreateApp(NotificationRequest body, string app_id)
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
                return JsonConvert.DeserializeObject<NotificationResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        //Consult Notification Preference - Consultar Preferência de Notificação
        public async Task<NotificationResponse> Consult(string notification_id)
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
                return JsonConvert.DeserializeObject<NotificationResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        //Listar Todas as Preferências de Notificação - List All Notification Preferences
        public async Task<List<NotificationResponse>> List()
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
                return JsonConvert.DeserializeObject<List<NotificationResponse>>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        //Remover Preferência de Notificação - Remove Notification Preference
        public async Task<HttpStatusCode> Remove(string notification_id)
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
        //Consultar Webhook Enviado - Consult Webhook Submitted
        public async Task<WebhookResponse> ConsultWebhook(string payment_id)
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
                return JsonConvert.DeserializeObject<WebhookResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        //Listar Todos os Webhooks Enviados - List All Sent Webhooks
        public async Task<List<WebhookResponse>> ListWebhooks()
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
                return JsonConvert.DeserializeObject<List<WebhookResponse>>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
