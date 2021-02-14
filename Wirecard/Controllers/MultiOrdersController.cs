using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using Wirecard.Models;
using System.Threading.Tasks;
using Wirecard.Exception;

namespace Wirecard.Controllers
{
    //Multi Pedidos - Multi Orders
    public partial class MultiOrdersController
    {
        private readonly Http_Client Http_Client;
        public MultiOrdersController(Http_Client _httpClient)
        {
            Http_Client = _httpClient;
        }
        /// <summary>
        /// Criar Multipedido - Create Multi Order
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<MultiOrderResponse> Create(MultiOrderRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync("v2/multiorders", stringContent);
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
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"v2/multiorders/{multiorder_id}");
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