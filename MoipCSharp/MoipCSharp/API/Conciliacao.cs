using MoipCSharp.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MoipCSharp
{
    public static class Conciliacao
    {
        public static async Task<ArquivoVendasResponse> ObterArquivoVendas(HttpClient httpClient, string date)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"v2/reconciliations/sales/{date}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<ArquivoVendasResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<string> ObterArquivoFinanceiro(HttpClient httpClient, string eventsCreatedAt)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"v2/reconciliations/financials?eventsCreatedAt={eventsCreatedAt}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            return await response.Content.ReadAsStringAsync();
        }
    }
}
