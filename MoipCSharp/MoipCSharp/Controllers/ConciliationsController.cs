using Newtonsoft.Json;
using System.Net.Http;
using MoipCSharp.Models;
using MoipCSharp.Exception;
using System.Threading.Tasks;

namespace MoipCSharp.Controllers
{
    //Conciliações - Conciliations
    public partial class ConciliationsController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static ConciliationsController instance = null;
        internal static ConciliationsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ConciliationsController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        //Obter Arquivo de Vendas - Get Sales File
        public async Task<SalesFileResponse> GetSalesFile(string date)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/reconciliations/sales/{date}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.MoipError moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<SalesFileResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        //Obter Arquivo Financeiro - Get Financial File
        public async Task<string> GetFinancialFile(string eventsCreatedAt)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/reconciliations/financials?eventsCreatedAt={eventsCreatedAt}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.MoipError moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            return await response.Content.ReadAsStringAsync();
        }
    }
}
