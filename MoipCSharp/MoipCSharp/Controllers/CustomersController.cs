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

        //Criar cliente - Create Client
        public async Task<CustomerResponse> Create(CustomerRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PostAsync($"v2/customers", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        //Adicionar cartão de crédito - Add Credit Card
        public async Task<CustomerResponse> AddCreditCard(CustomerRequest body, string customer_id)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PostAsync($"v2/customers/{customer_id}/fundinginstruments", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        //Deletar cartão de crédito - Delete Credit Card
        public async Task<HttpStatusCode> DeleteCreditCard(string creditcard_id)
        {
            HttpResponseMessage response = await ClientInstance.DeleteAsync($"v2/fundinginstruments/{creditcard_id}");
            return response.StatusCode;
        }
        //Consultar cliente - Consult Customer
        public async Task<CustomerResponse> Consult(string customer_id)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/customers/{customer_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        //Listar Todos os Clientes - List All Customers
        public async Task<List<CustomerResponse>> List()
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/customers/");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<List<CustomerResponse>>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
