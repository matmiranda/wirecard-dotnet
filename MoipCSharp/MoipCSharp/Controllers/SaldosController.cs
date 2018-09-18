using Newtonsoft.Json;
using System.Net.Http;
using MoipCSharp.Models;
using MoipCSharp.Exception;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MoipCSharp.Controllers
{
    public partial class SaldosController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static SaldosController instance = null;
        internal static SaldosController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new SaldosController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        public async Task<List<SaldoResponse>> Consultar()
        {
            HttpResponseMessage response = await ClientInstance.GetAsync("v2/balances");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<List<SaldoResponse>>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
