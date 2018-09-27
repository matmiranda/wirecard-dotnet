using Newtonsoft.Json;
using System.Net.Http;
using MoipCSharp.Models;
using MoipCSharp.Exception;
using System.Threading.Tasks;
using System.Text;

namespace MoipCSharp.Controllers
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

        //Criar Multipedido - Create Multi Order
        public async Task<MultiOrderResponse> Create(MultiOrderRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PostAsync("v2/multiorders", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        //Consultar Multi pedido - Consult Multi order
        public async Task<MultiOrderResponse> Consult(string multiorder_id)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/multiorders/{multiorder_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
