using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using Wirecard.Models;
using System.Threading.Tasks;
using Wirecard.Exception;

namespace Wirecard.Controllers
{
    //Contas Transparentes - Transparent Accounts
    public partial class TransparentAccountsController
    {
        private readonly Http_Client Http_Client;
        public TransparentAccountsController(Http_Client _httpClient)
        {
            Http_Client = _httpClient;
        }
        /// <summary>
        ///  Cria uma conta transparente - Create a transparent account
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task<TransparentAccountResponse> Create(TransparentAccountRequest body)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await Http_Client.HttpClient.PostAsync("v2/accounts", stringContent);
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