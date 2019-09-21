using NUnit.Framework;
using System.Threading.Tasks;
using Wirecard.Exception;
using Wirecard.Models;

namespace Wirecard.Test
{
    class WirecardTest
    {
        private const string accessToken = "d6bc80acbce6409b8b4cad5ceee62bc0_v2";
        private const string token = "XVCPWOOO0BFVWGCNAHAREXOJRDUKMBQG";
        private const string key = "BQ3OHLHBLDALQATLAPHVM4F2FLSUTUTH4ZLEKBJH";
        //private readonly WirecardClient WC = new WirecardClient(Environments.SANDBOX, accessToken); // <---marketplace
        private readonly WirecardClient WC = new WirecardClient(Environments.SANDBOX, token, key); //<-- e-commerce

        [Test]
        public async Task Teste()
        {
            var body = new CouponRequest
            {
                Coupon = new Coupon
                {
                    Code = "coupon-0001"
                }
            };
            var resulta = await WC.Signature.ConsultCoupon("coupon-0001");
            var result = await WC.Signature.AssociateCouponForExistingSignature(body, "assinatura01");
        }

        [Test]
        public async Task TesteListarTodosClientes()
        {
            if (WC._BusinessType == "E-COMMERCE")
            {
                var clientes = await WC.Customer.List();
                Assert.IsTrue(clientes.Count > 0);
                return;
            }
            if (WC._BusinessType == "MARKETPLACE")
            {
                var clientes = await WC.Customer.List();
                Assert.IsTrue(clientes.Count > 0);
                return;
            }
            Assert.Fail();
        }
        [Test]
        public async Task TesteConsultarCliente()
        {
            if (WC._BusinessType == "E-COMMERCE")
            {
                var cliente = await WC.Customer.Consult("CUS-36RKG1BL8ISM");
                Assert.AreEqual(cliente.FullName, "Fulano de Tal");
                return;
            }
            if (WC._BusinessType == "MARKETPLACE")
            {
                var cliente = await WC.Customer.Consult("CUS-36RKG1BL8ISM");
                Assert.AreEqual(cliente.FullName, "Fulano de Tal");
                return;
            }
            Assert.Fail();
        }
        [Test]
        public async Task TesteConsultarClienteInexistente()
        {
            if (WC._BusinessType == "E-COMMERCE")
            {
                try
                {
                    var cliente = await WC.Customer.Consult("CUS-36RKG1BL8ISM1");
                }
                catch (WirecardException ex)
                {
                    Assert.AreEqual(ex.statusCode, 404);
                    return;
                }
            }
            if (WC._BusinessType == "MARKETPLACE")
            {
                try
                {
                    var cliente = await WC.Customer.Consult("CUS-36RKG1BL8ISM1");
                }
                catch (WirecardException ex)
                {
                    Assert.AreEqual(ex.statusCode, 404);
                    return;
                }
            }
            Assert.Fail();
        }
        [Test]
        public async Task TesteConsultarPedido()
        {
            if (WC._BusinessType == "E-COMMERCE")
            {
                var pedido = await WC.Order.Consult("ORD-RESZNAA6SPBC");
                Assert.IsTrue(pedido.Customer.FullName == "Fulano de Tal");
                return;
            }
            if (WC._BusinessType == "MARKETPLACE")
            {
                var pedido = await WC.Order.Consult("ORD-RESZNAA6SPBC");
                Assert.IsTrue(pedido.Customer.FullName == "Fulano de Tal");
                return;
            }
            Assert.Fail();
        }
        [Test]
        public async Task TesteConsultarPedidoInexistente()
        {
            if (WC._BusinessType == "E-COMMERCE")
            {
                try
                {
                    var pedido = await WC.Order.Consult("ORD-RESZNAA6SPBC1");
                }
                catch (WirecardException ex)
                {
                    Assert.AreEqual(ex.statusCode, 404);
                    return;
                }
            }
            if (WC._BusinessType == "MARKETPLACE")
            {
                try
                {
                    var pedido = await WC.Order.Consult("ORD-RESZNAA6SPBC1");
                }
                catch (WirecardException ex)
                {
                    Assert.AreEqual(ex.statusCode, 404);
                    return;
                }
            }
            Assert.Fail();
        }
        [Test]
        public async Task TesteListarTodosPedidos()
        {
            if (WC._BusinessType == "E-COMMERCE")
            {
                var pedidos = await WC.Order.List();
                Assert.IsTrue(pedidos.Orders.Count > 0);
                return;
            }
            if (WC._BusinessType == "MARKETPLACE")
            {
                var pedidos = await WC.Order.List();
                Assert.IsTrue(pedidos.Orders.Count > 0);
                return;
            }
            Assert.Fail();
        }
        [Test]
        public async Task TesteListarTodosPedidosComFiltros()
        {
            if (WC._BusinessType == "E-COMMERCE")
            {
                var filtros = "q=Fulano de tal&limit=3&offset=0";
                var pedidos = await WC.Order.ListFilter(filtros);
                Assert.IsTrue(pedidos.Orders.Count > 0);
                return;
            }
            if (WC._BusinessType == "MARKETPLACE")
            {
                var filtros = "q=Fulano de tal&limit=3&offset=0";
                var pedidos = await WC.Order.ListFilter(filtros);
                Assert.IsTrue(pedidos.Orders.Count > 0);
                return;
            }
            Assert.Fail();
        }        
        [Test]
        public async Task TesteConsultarPagamento()
        {
            if (WC._BusinessType == "E-COMMERCE")
            {
                var pagamento = await WC.Payment.Consult("PAY-MSQUROQ5UID7");
                Assert.IsTrue(pagamento.StatementDescriptor == "MyStore");
                return;
            }
            if (WC._BusinessType == "MARKETPLACE")
            {
                var pagamento = await WC.Payment.Consult("PAY-MSQUROQ5UID7");
                Assert.IsTrue(pagamento.StatementDescriptor == "MyStore");
                return;
            }
            Assert.Fail();
        }
        [Test]
        public async Task TesteConsultarSaldo()
        {
            if (WC._BusinessType == "E-COMMERCE")
            {
                var saldos = await WC.Balance.Consult();
                Assert.IsTrue(saldos.Count > 0);
                return;
            }
            if (WC._BusinessType == "MARKETPLACE")
            {
                var saldos = await WC.Balance.Consult();
                Assert.IsTrue(saldos.Count > 0);
                return;
            }
            Assert.Fail();
        }        
        [Test]
        public async Task TesteConsultarLancamento()
        {
            if (WC._BusinessType == "E-COMMERCE")
            {
                var lancamento = await WC.Launch.Consult("ENT-OTHGP4RC24L4");
                Assert.IsTrue(lancamento.EventId == "PAY-MSQUROQ5UID7");
                return;
            }
            if (WC._BusinessType == "MARKETPLACE")
            {
                var lancamento = await WC.Launch.Consult("ENT-OTHGP4RC24L4");
                Assert.IsTrue(lancamento.EventId == "PAY-MSQUROQ5UID7");
                return;
            }
            Assert.Fail();
        }
        [Test]
        public async Task TesteListarLancamentos()
        {
            if (WC._BusinessType == "E-COMMERCE")
            {
                var lancamentos = await WC.Launch.List();
                Assert.IsTrue(lancamentos.Count > 0);
                return;
            }
            if (WC._BusinessType == "MARKETPLACE")
            {
                var lancamentos = await WC.Launch.List();
                Assert.IsTrue(lancamentos.Count > 0);
                return;
            }
            Assert.Fail();
        }
        [Test]
        public void TesteWebHookReturn()
        {
            var json = "{  \r\n  \"date\":\"22/05/2018 16:05:09\",\r\n  \"env\":\"sandbox\",\r\n  \"event\":\"plan.inactivated\",\r\n  \"resource\":{  \r\n     \"code\":\"plan101\"\r\n  }\r\n}";
            var response = Utilities.DeserializeWebHook(json);
            Assert.AreEqual(response.Resource.Code, "plan101");
        }
    }
}
