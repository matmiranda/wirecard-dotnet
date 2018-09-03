using MoipCSharp.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MoipCSharp
{
    public static class SaldoMoip
    {
        public static async Task<SaldosResponse> ConsultarSaldos(HttpClient httpClient)
        {
            HttpResponseMessage response = await httpClient.GetAsync("v2/balances");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<SaldosResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
    }
}
