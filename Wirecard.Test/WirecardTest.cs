using NUnit.Framework;
using System.Threading.Tasks;

namespace Wirecard.Test
{
    class WirecardTest
    {
        [Test]
        public void TesteComAccessTokenDiferente()
        {
            var instancia1 = new WirecardClient(Environments.SANDBOX, "123");
            var instancia2 = new WirecardClient(Environments.SANDBOX, "456");

            var result1 = instancia1.ClassicAccount.GetPublickey().Result.keys.BasicAuth.Token;
            var result2 = instancia2.ClassicAccount.GetPublickey().Result.keys.BasicAuth.Token;
        }
    }
}
