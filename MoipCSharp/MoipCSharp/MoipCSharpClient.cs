using MoipCSharp.Controllers;

namespace MoipCSharp
{    
    public partial class MoipCSharpClient
    {        
        public MoipCSharpClient(Environments environments, string accesstoken)
        {
            _HttpClient.uri = environments == Environments.SANDBOX ? BaseAddress.SANDBOX: BaseAddress.PRODUCTION;
            _HttpClient.accesstoken = accesstoken;
        }
        public ClientesController Cliente => ClientesController.Instance;
        public ConciliacoesController Conciliacao => ConciliacoesController.Instance;
        public ContasClassicasController ContaClassica => ContasClassicasController.Instance;
        public ContasTransparentesController ContaTransparente => ContasTransparentesController.Instance;
        public ContasBancariasController ContaBancaria => ContasBancariasController.Instance;
        public LancamentosController Lancamento => LancamentosController.Instance;
        public MultiPagamentosController MultiPagamento => MultiPagamentosController.Instance;
        public MultiPedidosController MultiPedido => MultiPedidosController.Instance;
        public NotificacoesController Notificacao => NotificacoesController.Instance;
        public PagamentosController Pagamento => PagamentosController.Instance;
        public PedidosController Pedido => PedidosController.Instance;
        public ReembolsosController Reembolso => ReembolsosController.Instance;
        public SaldosController Saldo => SaldosController.Instance;
        public TransferenciasController Transferencia => TransferenciasController.Instance;
    }
}
