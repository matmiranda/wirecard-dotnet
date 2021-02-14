using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using Wirecard.Models;
using Wirecard.Exception;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Wirecard.Controllers
{
    //Assinatura - Signature
    public partial class SignaturesController
    {
        private readonly Http_Client Http_Client;
        public SignaturesController(Http_Client _httpClient)
        {
            Http_Client = _httpClient;
        }
        /// <summary>
        /// Criar plano - Create plan
        /// </summary>
        /// <returns></returns>
        public async Task<PlanResponse> CreatePlan(PlanRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync($"assinaturas/v1/plans", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PlanResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Listar Planos - List Plans
        /// </summary>
        /// <returns></returns>
        public async Task<PlansResponse> ListPlans()
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync("assinaturas/v1/plans");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PlansResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Consultar Plano - Consult Plan
        /// </summary>
        /// <param name="code"> Código do plano </param>
        /// <returns></returns>
        public async Task<PlanResponse> ConsultPlan(string code)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"assinaturas/v1/plans/{code}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PlanResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Ativar Plano - Enable Plan
        /// </summary>
        /// <param name="code"> Código do plano </param>
        /// <returns></returns>
        public async Task<HttpStatusCode> EnablePlan(string code)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(null), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PutAsync($"assinaturas/v1/plans/{code}/activate", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return response.StatusCode;
        }
        /// <summary>
        /// Desativar Plano - Disable Plan
        /// </summary>
        /// <param name="code"> Código do plano </param>
        /// <returns></returns>
        public async Task<HttpStatusCode> DisablePlan(string code)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(null), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PutAsync($"assinaturas/v1/plans/{code}/inactivate", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return response.StatusCode;
        }
        /// <summary>
        /// Alterar Plano - Change Plan
        /// </summary>
        /// <param name="body"></param>
        /// <param name="code"> Código do plano </param>
        /// <returns></returns>
        public async Task<HttpStatusCode> ChangePlan(PlanRequest body, string code)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PutAsync($"assinaturas/v1/plans/{code}", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return response.StatusCode;
        }

        /// <summary>
        /// Criar Assinante - Create Subscriber
        /// </summary>
        /// <param name="body"></param>
        /// <param name="new_vault">Se new_vault=true, o envio do node credit_card é obrigatório. Utilize isso para criar um assinante com dados de cartão e gerar um cofre para guardar os dados de pagamento com segurança no Moip.</param>
        /// <returns></returns>
        public async Task<SubscriberResponse> CreateSubscriber(SubscriberRequest body, bool new_vault)
        {
            string json;
            try
            {
                json = JsonConvert.SerializeObject(body);
                JObject jObject = JObject.Parse(json);
                jObject["address"]["streetNumber"].Rename("number");
                jObject["address"]["zipCode"].Rename("zipcode");
                json = jObject.ToString();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }            
            StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync($"assinaturas/v1/customers?new_vault={new_vault}", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<SubscriberResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Listar Assinantes - List Subscribers
        /// </summary>
        /// <returns></returns>
        public async Task<SubscribersResponse> ListSubscribers()
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync("assinaturas/v1/customers");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<SubscribersResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Consultar Assinante - Consult Subscriber
        /// </summary>
        /// <param name="code"> Código do Assinante </param>
        /// <returns></returns>
        public async Task<SubscriberResponse> ConsultSubscriber(string code)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"assinaturas/v1/customers/{code}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                string json = await response.Content.ReadAsStringAsync();
                JObject jObject = JObject.Parse(json);
                jObject["address"]["number"].Rename("streetNumber");
                jObject["address"]["zipcode"].Rename("ZipCode");
                json = jObject.ToString();
                return JsonConvert.DeserializeObject<SubscriberResponse>(json);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Alterar Assinante - Change Subscriber
        /// </summary>
        /// <param name="body"></param>
        /// <param name="code"> Código do Assinante </param>
        /// <returns></returns>
        public async Task<HttpStatusCode> ChangeSubscriber(SubscriberRequest body, string code)
        {
            string json;
            try
            {
                json = JsonConvert.SerializeObject(body);
                JObject jObject = JObject.Parse(json);
                jObject["address"]["streetNumber"].Rename("number");
                jObject["address"]["zipCode"].Rename("zipcode");
                json = jObject.ToString();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PutAsync($"assinaturas/v1/customers/{code}", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return response.StatusCode;
        }
        /// <summary>
        /// Atualizar Cartão do Assinante - Update Subscriber Card
        /// </summary>
        /// <param name="body"></param>
        /// <param name="code"> Código do Assinante </param>
        /// <returns></returns>
        public async Task<SubscriberResponse> UpdateSubscriberCard(SubscriberRequest body, string code)
        {
            string json;
            try
            {
                json = JsonConvert.SerializeObject(body);
                JObject jObject = JObject.Parse(json);
                json = jObject["billing_info"].ToString();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PutAsync($"assinaturas/v1/customers/{code}/billing_infos", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<SubscriberResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Criar Assinaturas - Create Subscriptions
        /// </summary>
        /// <param name="body"></param>
        /// <param name="true_or_false">Caso queira adicionar um novo assinante à Assinatura, entre com valor true.</param>
        /// <returns></returns>
        public async Task<SubscriptionResponse> CreateSubscriptions(SubscriptionRequest body, bool true_or_false)
        {
            string json;
            try
            {
                json = JsonConvert.SerializeObject(body);
                JObject jObject = JObject.Parse(json);
                if (jObject["customer"]["address"] != null)
                {
                    if (jObject["customer"]["address"]["streetNumber"] != null)
                    {
                        jObject["customer"]["address"]["streetNumber"].Rename("number");
                    }
                    if (jObject["customer"]["address"]["zipCode"] != null)
                    {
                        jObject["customer"]["address"]["zipCode"].Rename("zipcode");
                    }
                }
                json = jObject.ToString();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync($"assinaturas/v1/subscriptions?new_customer={true_or_false}", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<SubscriptionResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Listar Todas Assinaturas - List All Subscriptions
        /// </summary>
        /// <returns></returns>
        public async Task<SubscriptionsResponse> ListAllSubscriptions()
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync("assinaturas/v1/subscriptions");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<SubscriptionsResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Consultar Assinatura - Consult Subscription
        /// </summary>
        /// <param name="code">Código da Assinatura</param>
        /// <returns></returns>
        public async Task<SubscriptionResponse> ConsultSubscription(string code)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"assinaturas/v1/subscriptions/{code}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<SubscriptionResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Consultar Assinatura com Filtro - Consult Subscription with Filter
        /// </summary>
        /// <param name="filter">Filtros de busca, mais informações <see href="link de filtros">aqui</see></param>
        /// <returns></returns>
        public async Task<SubscriptionsResponse> ConsultSubscriptionFilter(string filter)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"assinaturas/v1/subscriptions?{filter}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<SubscriptionsResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Suspender Assinatura - Suspend Subscription
        /// </summary>
        /// <param name="code">Código da Assinatura</param>
        /// <returns></returns>
        public async Task<HttpStatusCode> SuspendSubscription(string code)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(null), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PutAsync($"assinaturas/v1/subscriptions/{code}/suspend", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return response.StatusCode;
        }
        /// <summary>
        /// Reativar Assinatura - Reactivate Signature
        /// </summary>
        /// <param name="code">Código da Assinatura</param>
        /// <returns></returns>
        public async Task<HttpStatusCode> ReactivateSignature(string code)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(null), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PutAsync($"assinaturas/v1/subscriptions/{code}/activate", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return response.StatusCode;
        }
        /// <summary>
        /// Cancelar Assinatura - Cancel Signature
        /// </summary>
        /// <param name="code">Código da Assinatura</param>
        /// <returns></returns>
        public async Task<HttpStatusCode> CancelSignature(string code)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(null), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PutAsync($"assinaturas/v1/subscriptions/{code}/cancel", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return response.StatusCode;
        }
        /// <summary>
        /// Alterar Assinatura - Change Subscription
        /// </summary>
        /// <param name="body"></param>
        /// <param name="code"> Código do Assinante </param>
        /// <returns></returns>
        public async Task<SubscriptionResponse> ChangeSubscription(SubscriptionRequest body, string code)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PutAsync($"assinaturas/v1/subscriptions/{code}", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<SubscriptionResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Alterar método de pagamento - Change Payment Method
        /// </summary>
        /// <param name="body"></param>
        /// <param name="code"> Código do Assinante </param>
        /// <returns></returns>
        public async Task<HttpStatusCode> ChangePaymentMethod(SubscriptionRequest body, string code)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PutAsync($"assinaturas/v1/subscriptions/{code}/change_payment_method", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return response.StatusCode;
        }
        /// <summary>
        /// Listar Faturas de Assinatura - List Signature Invoices
        /// </summary>
        /// <param name="code"> Código do Assinante </param>
        /// <returns></returns>
        public async Task<InvoicesResponse> ListSignatureInvoices(string code)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"assinaturas/v1/subscriptions/{code}/invoices");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<InvoicesResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Consultar Fatura - Consult Invoice
        /// </summary>
        /// <param name="id"> Id da Cobrança </param>
        /// <returns></returns>
        public async Task<InvoiceResponse> ConsultInvoice(string id)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"assinaturas/v1/invoices/{id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<InvoiceResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Listar todos os pagamentos de fatura - List all invoice payments
        /// </summary>
        /// <param name="id"> Id da Cobrança </param>
        /// <returns></returns>
        public async Task<PaymentsSignatureResponse> ListAllInvoicePayments(string id)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"assinaturas/v1/invoices/{id}/payments");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PaymentsSignatureResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Consultar pagamento de assinatura - Consult subscription payment
        /// </summary>
        /// <param name="id"> Id do pagamento </param>
        /// <returns></returns>
        public async Task<PaymentsResponse> ConsultSubscriptionPayment(string id)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"assinaturas/v1/payments/{id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<PaymentsResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Criar cupom - Create Coupon
        /// </summary>
        /// <returns></returns>
        public async Task<CouponResponse> CreateCoupon(CouponRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync("assinaturas/v1/coupons", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<CouponResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Associar Cupom para Assinatura Existente - Associate Coupon For Existing Signature
        /// </summary>
        /// <returns></returns>
        public async Task<CouponResponse> AssociateCouponForExistingSignature(CouponRequest body, string code)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PutAsync($"assinaturas/v1/subscriptions/{code}", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<CouponResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Associar Cupom para Nova Assinatura - Associate Coupon For New Signature
        /// </summary>
        /// <param name="body"></param>
        /// <param name="true_or_false">Caso queira criar um novo Assinante o valor desse ser "true", caso contrário "false".</param>
        /// <returns></returns>
        public async Task<CouponResponse> AssociateCouponForNewSignature(CouponRequest body, string true_or_false)
        {
            string json;
            try
            {
                json = JsonConvert.SerializeObject(body);
                JObject jObject = JObject.Parse(json);
                if (jObject["customer"]["address"] != null)
                {
                    if (jObject["customer"]["address"]["streetNumber"] != null)
                    {
                        jObject["customer"]["address"]["streetNumber"].Rename("number");
                    }
                    if (jObject["customer"]["address"]["zipCode"] != null)
                    {
                        jObject["customer"]["address"]["zipCode"].Rename("zipcode");
                    }
                }
                json = jObject.ToString();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync($"assinaturas/v1/subscriptions?new_customer={true_or_false}", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<CouponResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Consultar Cupom - Consult Coupon
        /// </summary>
        /// <param name="code"> Código do Cupom. </param>
        /// <returns></returns>
        public async Task<CouponResponse> ConsultCoupon(string code)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"assinaturas/v1/coupons/{code}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<CouponResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Listar Todos os Cupons - List All Coupons
        /// </summary>
        /// <returns></returns>
        public async Task<CouponsResponse> ListAllCoupons()
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync("assinaturas/v1/coupons");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<CouponsResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Ativar ou Inativar Cupon - Enable or Disable Coupon
        /// </summary>
        /// <param name="code">Código do Cupom</param>
        /// <param name="active_or_inactive">Escolha active para Ativar um Cupom e inactive para desativar</param>
        /// <returns></returns>
        public async Task<CouponResponse> EnableOrDisableCoupon(string code, string active_or_inactive)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(null), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PutAsync($"assinaturas/v1/coupons/{code}/{active_or_inactive}", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<CouponResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Excluir Cupom de Assinatura - Delete Signature Coupon
        /// </summary>
        /// <param name="code">Código da Assinatura</param>
        /// <returns></returns>
        public async Task<CouponResponse> DeleteSignatureCoupon(string code)
        {
            HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Delete, Http_Client.HttpClient.BaseAddress + $"assinaturas/v1/subscriptions/{code}/coupon")
            {
                Content = new StringContent(string.Empty, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage response = await Http_Client.HttpClient.SendAsync(httpRequest);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<CouponResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Retentativa pagamento de fatura - Retentive invoice payment
        /// </summary>
        /// <param name="id">ID da fatura</param>
        /// <returns></returns>
        public async Task<HttpStatusCode> RetentiveInvoicePayment(string id)
        {
            StringContent stringContent = new StringContent(null, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync($"assinaturas/v1/invoices/{id}/retry", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return response.StatusCode;
        }
        /// <summary>
        /// Criar novo boleto de fatura - Create New Invoice Boleto
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id">ID da fatura</param>
        /// <returns></returns>
        public async Task<RetentativeResponse> CreateNewInvoiceBoleto(RetentativeRequest body, string id)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync($"assinaturas/v1/invoices/{id}/boletos", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<RetentativeResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Criar Regras de Retentativas Automáticas - Create Automatic Retention Rules
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> CreateAutomaticRetentionRules(RetentativeRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync($"assinaturas/v1/users/preferences/retry", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return response.StatusCode;
        }
        /// <summary>
        /// Criar Preferência de Notificação - Create Notification Preference
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<HttpStatusCode> CreateNotificationPreference(NotificationRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync("assinaturas/v1/users/preferences", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return response.StatusCode;
        }
    }
}