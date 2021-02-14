using Newtonsoft.Json;
using System.Net.Http;
using Wirecard.Models;
using System.Threading.Tasks;
using Wirecard.Exception;
using System.Collections.Generic;

namespace Wirecard.Controllers
{
    //Lançamentos - Launches
    public partial class LaunchesController
    {
        private readonly Http_Client Http_Client;
        public LaunchesController(Http_Client _httpClient)
        {
            Http_Client = _httpClient;
        }
        /// <summary>
        /// Cosultar lançamento - Consult launch
        /// </summary>
        /// <param name="entry_id">Id do lançamento (Exemplo: ENT-BH4NJAVN65FB)</param>
        /// <returns></returns>
        public async Task<LaunchResponse> Consult(string entry_id)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"v2/entries/{entry_id}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        /// <summary>
        /// Listar lançamento - launch list
        /// </summary>
        /// <returns></returns>
        public async Task<List<LaunchesResponse>> List()
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync("v2/entries");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
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
        /// <summary>
        /// Listar lançamento com filtro - List launch with filter
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public async Task<List<LaunchesResponse>> ListFilter(string filter)
        {
            HttpResponseMessage response = await Http_Client.HttpClient.GetAsync($"v2/entries?{filter}");
            if (!response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                WirecardException.WirecardError wirecardException = WirecardException.DeserializeObject(content);
                throw new WirecardException(wirecardException, "HTTP Response Not Success", content, (int)response.StatusCode);
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