using MoipCSharp.Exception;
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
                string content = await response.Content.ReadAsStringAsync();
                MoipException.APIException moipException = MoipException.DeserializeObject(content);
                throw new MoipException(moipException, "Error Code != 200", content, response.StatusCode, (int)response.StatusCode);
            }
            try
            {
                return JsonConvert.DeserializeObject<SaldosResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
    }
}
