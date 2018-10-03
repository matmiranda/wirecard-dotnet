using Newtonsoft.Json;
using System.Net.Http;
using MoipCSharp.Models;
using MoipCSharp.Exception;
using System.Threading.Tasks;
using System.Text;

namespace MoipCSharp.Controllers
{
    //Pedidos - Orders
    public partial class OrdersController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static OrdersController instance = null;
        internal static OrdersController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new OrdersController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        /// <summary>
        /// Criar Pedido - Create Order
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<OrderResponse> Create(OrderRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PostAsync($"v2/orders", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.MoipError moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<OrderResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Consultar Pedido - Consult Order
        /// </summary>
        /// <param name="order_id">Código identificador do pedido. Exemplo: ORD-9BAYAVM87YHE</param>
        /// <returns></returns>
        public async Task<OrderResponse> Consult(string order_id)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/orders/{order_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.MoipError moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<OrderResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Listar Todos os Pedidos - List All Orders
        /// </summary>
        /// <returns></returns>
        public async Task<OrdersResponse> List()
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/orders");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.MoipError moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<OrdersResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Listar Todos os Pedidos com filtro -  List All Filter Orders
        /// </summary>
        /// <param name="filter">Filtros de busca, mais informações <see href="https://github.com/matmiranda/MoipCSharp#listar-todos-os-pedidos---com-filtros">aqui</see></param>
        /// <returns></returns>
        public async Task<OrdersResponse> ListFilter(string filter)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/orders?{filter}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.MoipError moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<OrdersResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
