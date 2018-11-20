using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using WirecardCSharp.Models;
using System.Threading.Tasks;
using WirecardCSharp.Exception;

using System.Collections.Generic;

namespace WirecardCSharp.Controllers
{
    //Clientes - Customers
    public partial class CustomersController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static CustomersController instance = null;
        internal static CustomersController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new CustomersController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        /// <summary>
        /// Criar cliente - Create Client
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<CustomerResponse> Create(CustomerRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PostAsync($"v2/customers", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<CustomerResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Adicionar cartão de crédito - Add Credit Card
        /// </summary>
        /// <param name="body"></param>
        /// <param name="customer_id">Código identificador do cliente (exemplo: CUS-8563056295)</param>
        /// <returns></returns>
        public async Task<CustomerResponse> AddCreditCard(CustomerRequest body, string customer_id)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PostAsync($"v2/customers/{customer_id}/fundinginstruments", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<CustomerResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Deletar cartão de crédito - Delete Credit Card
        /// </summary>
        /// <param name="creditcard_id">Código identificador do cartão de crédito. Exemplo: CRC-8426482846</param>
        /// <returns></returns>
        public async Task<HttpStatusCode> DeleteCreditCard(string creditcard_id)
        {
            HttpResponseMessage response = await ClientInstance.DeleteAsync($"v2/fundinginstruments/{creditcard_id}");
            return response.StatusCode;
        }
        /// <summary>
        /// Consultar cliente - Consult Customer
        /// </summary>
        /// <param name="customer_id">Código identificador do cliente que deseja consultar. Exemplo: CUS-1357915397</param>
        /// <returns></returns>
        public async Task<CustomerResponse> Consult(string customer_id)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/customers/{customer_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<CustomerResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Listar Todos os Clientes - List All Customers
        /// </summary>
        /// <returns></returns>
        public async Task<List<CustomerResponse>> List()
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/customers/");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                string json = await response.Content.ReadAsStringAsync();
                //remove: {'customers':
                json = json.Remove(0, 13);
                //remove: }
                json = json.Remove(json.Length - 1);
                return JsonConvert.DeserializeObject<List<CustomerResponse>>(json);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}