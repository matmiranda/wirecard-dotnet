using NUnit.Framework;
using System.Threading.Tasks;

namespace Wirecard.Test
{
    class WirecardTest
    {
        private const string accessToken = "00000000000000000000000000000000_v2";
        private readonly WirecardClient WC = new WirecardClient(Environments.SANDBOX, accessToken);

        [Test]
        public void TesteComAccessTokenDiferente()
        {
            var result1 = WC.ClassicAccount.GetPublickey().Result.keys.BasicAuth.Token;

            WC.ChangeAccessToken("11111111111111111111111111111111_v2");

            var result2 = WC.ClassicAccount.GetPublickey().Result.keys.BasicAuth.Token;
        }
    }
}
