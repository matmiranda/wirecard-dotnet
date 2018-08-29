using MoipCSharp.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MoipCSharp.Controllers
{
    public static class ContaClassica
    {
        public static async Task<HttpStatusCode> VerificarSeUsuarioJaPossuiContaMoipAsync(string email)
        {
            HttpClient httpClient = Configuration.HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync($"v2/accounts/exists?email={email}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            return response.StatusCode;
        }
        public static async Task<CriarContaMoipClassicaResponse> CriarContaMoipClassicaAsync(CriarContaMoipClassicaRequest body)
        {
            HttpClient httpClient = Configuration.HttpClient();            
            HttpResponseMessage response = await httpClient.PostAsync("v2/accounts", null);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<CriarContaMoipClassicaResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        public static async Task<ConsultarContaMoipResponse> ConsultarContaMoipAsync(string account_id)
        {
            HttpClient httpClient = Configuration.HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync($"v2/accounts/{account_id}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<ConsultarContaMoipResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
        //public static async Task<string> SolicitarPermissoesDeAcessoUsuarioAsync(string account_id)
        //{
        //    HttpClient httpClient = Configuration.HttpClient();
        //    HttpResponseMessage response = await httpClient.GetAsync($"oauth/authorize");
        //    if (response.StatusCode != HttpStatusCode.OK)
        //    {
        //        throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
        //    }
        //    try
        //    {
        //        return await response.Content.ReadAsStringAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Error message: " + ex.Message);
        //    }
        //}
        //public static async Task<GerarAccessTokenResponse> GerarAccessTokenAsync()
        //{
        //    HttpClient httpClient = Configuration.HttpClient();
        //    httpClient.BaseAddress = new Uri("https://connect-sandbox.moip.com.br/");
        //    HttpResponseMessage response = await httpClient.PostAsync("oauth/token", null);
        //    if (response.StatusCode != HttpStatusCode.OK)
        //    {
        //        throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
        //    }
        //    try
        //    {
        //        return JsonConvert.DeserializeObject<GerarAccessTokenResponse>(await response.Content.ReadAsStringAsync());
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Error message: " + ex.Message);
        //    }
        //}
        //public static async Task<AtualizarAccessTokenResponse> AtualizarAccessTokenAsync()
        //{
        //    HttpClient httpClient = Configuration.HttpClient();
        //    httpClient.BaseAddress = new Uri("https://connect-sandbox.moip.com.br/");
        //    HttpResponseMessage response = await httpClient.PostAsync("oauth/token", null);
        //    if (response.StatusCode != HttpStatusCode.OK)
        //    {
        //        throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
        //    }
        //    try
        //    {
        //        return JsonConvert.DeserializeObject<AtualizarAccessTokenResponse>(await response.Content.ReadAsStringAsync());
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Error message: " + ex.Message);
        //    }
        //}
        public static async Task<ObterChavePublicaContaMoipResponse> ObterChavePublicaContaMoipAsync()
        {
            HttpClient httpClient = Configuration.HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("v2/keys");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ArgumentException($"Error code: {(int)response.StatusCode} - {response.StatusCode}");
            }
            try
            {
                return JsonConvert.DeserializeObject<ObterChavePublicaContaMoipResponse>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error message: " + ex.Message);
            }
        }
    }
}
