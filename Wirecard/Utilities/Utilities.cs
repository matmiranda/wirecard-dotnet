using System;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Wirecard.Models;
using Wirecard.Exception;

namespace Wirecard
{
    public static class Utilities
    {
        /// <summary> Converte json para objeto - deserialize to a object </summary>
        /// <param name="json">Retorno json</param>
        /// <returns></returns>
        public static ReturnWebHook DeserializeWebHook(string json)
        {
            try
            {
                JsonSerializerSettings setting = new JsonSerializerSettings
                {
                    MetadataPropertyHandling = MetadataPropertyHandling.Ignore
                };
                return JsonConvert.DeserializeObject<ReturnWebHook>(json, setting);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Obter os erros como texto - Get errors as text
        /// </summary>
        /// <param name="we">WirecardException</param>
        /// <returns></returns>
        public static string GetExceptionText(this WirecardException we)
        {
            var sb = new StringBuilder();

            if (we != null)
            {
                if (we.wirecardError == null || !we.wirecardError.errors.Any())
                    return sb.ToString();

                foreach (var error in we.wirecardError.errors)
                    sb.AppendLine($"{error.description} ({error.code})");
            }
            return sb.ToString();
        }
        /// <summary>
        /// Solicita Permissões de Acesso ao Usuário - Request User Access Permissions
        /// </summary>
        /// <param name="response_type">Define o tipo de resposta a ser obtido. Valores possíveis: code</param>
        /// <param name="client_id">Identificador único do aplicativo que será realizada a solicitação. Exemplo: APP-DVLJHW59IKOS</param>
        /// <param name="redirect_uri">URI de redirecionamento do cliente. ATENÇÂO: deve ser a mesma url cadastrada ao criar o app.</param>
        /// <param name="scope">Permissões que deseja. Valores possíveis: RECEIVE_FUNDS, REFUND, MANAGE_ACCOUNT_INFO, RETRIEVE_FINANCIAL_INFO, TRANSFER_FUNDS, DEFINE_PREFERENCES</param>
        /// <returns></returns>
        public static string RequestUserAccessPermissions(string response_type, string client_id, string redirect_uri, string scope)
        {
            try
            {
                string _params = $"oauth/authorize?response_type={response_type}&client_id={client_id}&redirect_uri={redirect_uri}&scope={scope}";
                return new Uri(new Uri("https://connect-sandbox.moip.com.br/"), _params).AbsoluteUri;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        internal static void Rename(this JToken token, string newName)
        {
            if (token == null) throw new ArgumentNullException("token", "Cannot rename a null token");

            JProperty property;

            if (token.Type == JTokenType.Property)
            {
                if (token.Parent == null) throw new InvalidOperationException("Cannot rename a property with no parent");

                property = (JProperty)token;
            }
            else
            {
                if (token.Parent == null || token.Parent.Type != JTokenType.Property) throw new InvalidOperationException("This token's parent is not a JProperty; cannot rename");

                property = (JProperty)token.Parent;
            }

            var newProperty = new JProperty(newName, property.Value);
            property.Replace(newProperty);
        }
    }
}