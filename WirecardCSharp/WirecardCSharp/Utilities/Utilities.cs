using Newtonsoft.Json;
using WirecardCSharp.Models;

namespace WirecardCSharp
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
                return JsonConvert.DeserializeObject<ReturnWebHook>(json);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
