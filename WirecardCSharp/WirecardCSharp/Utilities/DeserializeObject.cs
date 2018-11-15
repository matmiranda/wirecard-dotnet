using Newtonsoft.Json;
using WirecardCSharp.Models;

namespace WirecardCSharp.Utilities
{
    internal class DeserializeObject
    {
        //convert json to object
        internal static ReturnWebHook WebHook(string json)
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