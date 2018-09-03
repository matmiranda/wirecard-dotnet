using MoipCSharp.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MoipCSharp
{
    public static class ContasBancarias
    {
        public static async Task<ContaBancariaResponse> CriarContaBancaria(HttpClient httpClient, CriarContaBancariaRequest body, string account_id)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync($"v2/accounts/{account_id}/bankaccounts", stringContent);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<ContaBancariaResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<ContaBancariaResponse> ConsultarContaBancaria(HttpClient httpClient, string bank_account_id)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"v2/bankaccounts/{bank_account_id}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<ContaBancariaResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<ContasBancariasResponse[]> ListarTodasContasBancarias(HttpClient httpClient, string account_id)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"v2/accounts/{account_id}/bankaccounts");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<ContasBancariasResponse[]>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<HttpStatusCode> DeletarContaBancaria(HttpClient httpClient, string account_id)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"v2/accounts/{account_id}/bankaccounts");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            return response.StatusCode;
        }
        public static async Task<ContaBancariaResponse> AtualizarContaBancaria(HttpClient httpClient, AtualizarContaBancariaRequest body, string bankaccount_id)
        {
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PutAsync($"v2/bankaccounts/{bankaccount_id}", stringContent);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException(await response.Content.ReadAsStringAsync());
            }
            try
            {
                return JsonConvert.DeserializeObject<ContaBancariaResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
    }
}
