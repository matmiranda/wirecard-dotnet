using NUnit.Framework;
using System.Collections.Generic;
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
        public async Task TesteCriarPedido()
        {
            var body = new OrderRequest
            {
                OwnId = "id_pedido",
                Amount = new Amount
                {
                    Currency = "BRL",
                    Subtotals = new Subtotals
                    {
                        Shipping = 1000
                    }
                },
                Items = new List<Item>
                {
                    new Item
                    {
                        Product = "Descrição do pedido",
                        Category = "VIDEO_GAME_SOFTWARE",
                        Quantity = 1,
                        Detail = "Mais info...",
                        Price = 22000
                    }
                },
                Customer = new Customer
                {
                    Id = "CUS-36RKG1BL8ISM"
                },
                Receivers = new List<Receiver>
                {
                    new Receiver
                    {
                        Type = "SECONDARY",
                        FeePayor = false,
                        MoipAccount = new Moipaccount
                        {
                            Id = "MPA-E3C8493A06AE"
                        },
                        Amount = new Amount
                        {
                            Fixed = 5000,
                            Percentual = 10.3f
                        }
                    }
                }
            };
            try
            {
                var result = await WC.Order.Create(body);
            }
            catch (System.Exception ex)
            {

                throw;
            }

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
            var pagamento = await WC.Payment.Consult("PAY-MSQUROQ5UID7");
            Assert.IsTrue(pagamento.StatementDescriptor == "MyStore");
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
        [Test]
        public async Task TesteCriarPagamentoBoleto()
        {
            var body = new PaymentRequest
            {
                //informe os campos aqui
                StatementDescriptor = "Minha Loja",
                FundingInstrument = new Fundinginstrument
                {
                    Method = "BOLETO",
                    Boleto = new Boleto
                    {
                        ExpirationDate = "2020-09-20", //yyyy-MM-dd
                        InstructionLines = new Instructionlines
                        {
                            First = "Atenção",
                            Second = "fique atento à data de vencimento do boleto.",
                            Third = "Pague em qualquer casa lotérica."
                        }
                    }
                }
            };
            var boleto = await WC.Payment.Create(body, "ORD-RESZNAA6SPBC");
            //Assert.IsTrue();
        }
        [Test]
        public async Task TesteListarTodasAssinaturas()
        {
            if (WC._BusinessType == "E-COMMERCE")
            {
                var result = await WC.Signature.ListAllSubscriptions();
                //Assert.IsTrue(result.Count > 0);
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
        public async Task TesteCriarPlano()
        {
            var body = new PlanRequest
            {
                Code = "plan103",
                Name = "Plano Especial",
                Description = "Descrição do Plano Especial",
                Amount = 990,
                Setup_Fee = 500,
                Max_Qty = 1,
                Interval = new Interval
                {
                    Length = 1,
                    Unit = "MONTH"
                },
                Billing_Cycles = 12,
                Trial = new Trial
                {
                    Days = 30,
                    Enabled = true,
                    Hold_Setup_Fee = true
                }
            };
            var result = await WC.Signature.CreatePlan(body);
        }
        [Test]
        public async Task TesteListarPlanos()
        {
            var result = await WC.Signature.ListPlans();
            Assert.IsTrue(result.Plans.Count > 0);
        }
        [Test]
        public async Task TesteConsultarPlano()
        {
            var result = await WC.Signature.ConsultPlan("plan103");
            Assert.Pass();
        }
        [Test]
        public async Task TesteListarAssinantes()
        {
            var result = await WC.Signature.ListSubscribers();
            Assert.IsTrue(result.Customers.Count > 0);
        }
    }
}
