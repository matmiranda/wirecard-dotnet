using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using Wirecard.Models;
using System.Threading.Tasks;
using Wirecard.Exception;

namespace Wirecard.Controllers
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

        /// <summary>
        ///  Cria uma conta transparente - Create a transparent account
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<TransparentAccountResponse> Create(TransparentAccountRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await ClientInstance.PostAsync("v2/accounts", stringContent);
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
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