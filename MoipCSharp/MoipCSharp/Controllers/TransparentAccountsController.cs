using Newtonsoft.Json;
using System.Net.Http;
using MoipCSharp.Models;
using MoipCSharp.Exception;
using System.Threading.Tasks;
using System.Text;

namespace MoipCSharp.Controllers
{
    //Contas Transparentes - Transparent Accounts
    public partial class TransparentAccountsController : BaseController
    {
        #region Singleton Pattern
        private static readonly object syncObject = new object();
        private static TransparentAccountsController instance = null;
        internal static TransparentAccountsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new TransparentAccountsController();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        //Cria a conta transparente - Create transparent account
        public async Task<TransparentAccountResponse> Create(TransparentAccountRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PostAsync("v2/accounts", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<TransparentAccountResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
