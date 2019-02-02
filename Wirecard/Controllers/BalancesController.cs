using Newtonsoft.Json;
using System.Net.Http;
using Wirecard.Models;
using Wirecard.Exception;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Wirecard.Controllers
{
    //Saldos - Balances
    public partial class BalancesController
    {
        /// <summary>
        /// Consultar Saldos - Consult Balances
        /// </summary>
        /// <returns></returns>
        public async Task<List<BalanceResponse>> Consult()
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync("v2/balances");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<List<BalanceResponse>>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
