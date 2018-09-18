using Newtonsoft.Json;
using System.Net.Http;
using MoipCSharp.Models;
using MoipCSharp.Exception;
using System.Threading.Tasks;
using System.Text;

namespace MoipCSharp.Controllers
{
    public partial class MultiPagamentosController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static MultiPagamentosController instance = null;
        internal static MultiPagamentosController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new MultiPagamentosController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        public async Task<MultiPagamentoResponse> Criar(MultiPagamentoRequest body, string multiorder_id)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PostAsync($"v2/multiorders/{multiorder_id}/multipayments", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<MultiPagamentoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public async Task<MultiPagamentoResponse> Consultar(string multiorder_id)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/multipayments/{multiorder_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<MultiPagamentoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public async Task<MultiPagamentoResponse> CapturarPreAutorizado(string multipayment_id)
        {
            HttpResponseMessage response = await ClientInstance.PostAsync($"v2/multipayments/{multipayment_id}/capture", null);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<MultiPagamentoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public async Task<MultiPagamentoResponse> CancelarPreAutorizado(string multipayment_id)
        {
            HttpResponseMessage response = await ClientInstance.PostAsync($"v2/multipayments/{multipayment_id}/void", null);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<MultiPagamentoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public async Task<MultiPagamentoResponse> LiberarCustodia(string escrow_id)
        {
            HttpResponseMessage response = await ClientInstance.PostAsync($"v2/escrows/{escrow_id}/release", null);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<MultiPagamentoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
