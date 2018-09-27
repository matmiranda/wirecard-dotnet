using Newtonsoft.Json;
using System.Net.Http;
using MoipCSharp.Models;
using MoipCSharp.Exception;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MoipCSharp.Controllers
{
    //Lançamentos - Launches
    public partial class LaunchesController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static LaunchesController instance = null;
        internal static LaunchesController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new LaunchesController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        //Cosultar lançamento - Consult launch
        public async Task<LaunchResponse> Consult(string entry_id)
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
                return JsonConvert.DeserializeObject<LaunchResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        //Listar lançamento - launch list
        public async Task<List<LaunchesResponse>> List()
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
                return JsonConvert.DeserializeObject<List<LaunchesResponse>>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
