using MoipCSharp.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MoipCSharp
{
    public static class Lancamento
    {
        public static async Task<ConsultarLancamentoResponse> ConsultarLancamentoAsync(string entry_id)
        {
            HttpClient httpClient = Configuration.HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync($"v2/entries/{entry_id}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Configuration.DeserializeObject(await response.Content.ReadAsStringAsync());
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<ConsultarLancamentoResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<ListarTodosLancamentosResponse> ListarTodosLancamentosAsync()
        {
            HttpClient httpClient = Configuration.HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("v2/entries");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Configuration.DeserializeObject(await response.Content.ReadAsStringAsync());
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<ListarTodosLancamentosResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
    }
}
