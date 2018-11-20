using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using WirecardCSharp.Models;
using System.Threading.Tasks;
using WirecardCSharp.Exception;

namespace WirecardCSharp.Controllers
{
    //Multi Pedidos - Multi Orders
    public partial class MultiOrdersController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static MultiOrdersController instance = null;
        internal static MultiOrdersController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new MultiOrdersController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        /// <summary>
        /// Criar Multipedido - Create Multi Order
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<MultiOrderResponse> Create(MultiOrderRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PostAsync("v2/multiorders", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<MultiOrderResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Consultar Multi pedido - Consult Multi order
        /// </summary>
        /// <param name="multiorder_id">Id identificador do multipagamento. Exemplo: MOR-9241K3EFW5DV</param>
        /// <returns></returns>
        public async Task<MultiOrderResponse> Consult(string multiorder_id)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/multiorders/{multiorder_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<MultiOrderResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}