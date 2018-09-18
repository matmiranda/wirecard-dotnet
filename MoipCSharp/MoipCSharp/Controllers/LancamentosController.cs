using Newtonsoft.Json;
using System.Net.Http;
using MoipCSharp.Models;
using MoipCSharp.Exception;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MoipCSharp.Controllers
{
    public partial class LancamentosController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static LancamentosController instance = null;
        internal static LancamentosController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new LancamentosController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        public async Task<LancamentoResponse> Consultar(string entry_id)
        {
            HttpResponseMessage response = await ClientInstance.GetAsync($"v2/entries/{entry_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<LancamentoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<LancamentosResponse>> Listar()
        {
            HttpResponseMessage response = await ClientInstance.GetAsync("v2/entries");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<List<LancamentosResponse>>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
