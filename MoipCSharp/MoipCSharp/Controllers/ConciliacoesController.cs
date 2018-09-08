using Newtonsoft.Json;
using System.Net.Http;
using MoipCSharp.Models;
using MoipCSharp.Exception;
using System.Threading.Tasks;

namespace MoipCSharp.Controllers
{
    public partial class ConciliacoesController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static ConciliacoesController instance = null;
        internal static ConciliacoesController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ConciliacoesController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        public async Task<ArquivoVendasResponse> ObterArquivoVendas(string date)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/reconciliations/sales/{date}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<ArquivoVendasResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> ObterArquivoFinanceiro(string eventsCreatedAt)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/reconciliations/financials?eventsCreatedAt={eventsCreatedAt}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return await response.Content.ReadAsStringAsync();
        }
    }
}
