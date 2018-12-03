using System;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using WirecardCSharp.Models;
using System.Threading.Tasks;
using WirecardCSharp.Exception;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WirecardCSharp.Controllers
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

        /// <summary>
        /// Criar Preferência de Notificação para Conta Wirecard - Create Notification Preference for Wirecard Account
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<NotificationResponse> CreatAccountWirecard(NotificationRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PostAsync("v2/preferences/notifications", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        /// <summary>
        /// Criar Preferência de Notificação para App - Create Notification Preference for App
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<NotificationResponse> CreateApp(NotificationRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PostAsync("v2/preferences/notifications", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        /// <summary>
        /// Criar Preferência de Notificação para App - Create Notification Preference for App
        /// </summary>
        /// <param name="body"></param>
        /// <param name="app_id">Código identificador do App. Exemplo: APP-3984HG73HE92</param>
        /// <returns></returns>
        public async Task<NotificationResponse> CreateApp(NotificationRequest body, string app_id)
        {
            Regex regex = new Regex(@"^APP-[a-zA-Z0-9]{12}$");
            Match match = regex.Match(app_id);
            if (!match.Success)
            {
                throw new ArgumentException("app_id invalid");
            }
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PostAsync($"v2/preferences/{app_id}/notifications", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        /// <summary>
        /// Consult Notification Preference - Consultar Preferência de Notificação
        /// </summary>
        /// <param name="notification_id">Código do identificador da preferência (NPR-DV61EEGGUFCQ)</param>
        /// <returns></returns>
        public async Task<NotificationResponse> Consult(string notification_id)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/preferences/notifications/{notification_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        /// <summary>
        /// Listar Todas as Preferências de Notificação - List All Notification Preferences
        /// </summary>
        /// <returns></returns>
        public async Task<List<NotificationResponse>> List()
        {
            HttpResponseMessage response = await ClientInstance.GetAsync("v2/preferences/notifications");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        /// <summary>
        /// Remover Preferência de Notificação - Remove Notification Preference
        /// </summary>
        /// <param name="notification_id">Código identificador da preferência (NPR-98G940NT23JO)</param>
        /// <returns></returns>
        public async Task<HttpStatusCode> Remove(string notification_id)
        {
            HttpResponseMessage response = await ClientInstance.DeleteAsync($"v2/preferences/notifications/{notification_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return response.StatusCode;
        }
        /// <summary>
        /// Consultar Webhook Enviado - Consult Webhook Submitted
        /// </summary>
        /// <param name="payment_id">Identificador do pagamento</param>
        /// <returns></returns>
        public async Task<WebhooksResponse> ConsultWebhook(string payment_id)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/webhooks?resourceId={payment_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<WebhooksResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Listar Todos os Webhooks Enviados - List All Sent Webhooks
        /// </summary>
        /// <returns></returns>
        public async Task<WebhooksResponse> ListWebhooks()
        {
            HttpResponseMessage response = await ClientInstance.GetAsync("v2/webhooks");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<WebhooksResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
