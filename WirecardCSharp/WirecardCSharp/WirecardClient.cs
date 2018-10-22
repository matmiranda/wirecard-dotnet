using WirecardCSharp.Controllers;

namespace WirecardCSharp
{
    public partial class WirecardClient
    {
        public WirecardClient(Environments environments, string accesstoken)
        {
            _HttpClient.uri = environments == Environments.SANDBOX ? BaseAddress.SANDBOX : BaseAddress.PRODUCTION;
            _HttpClient.accesstoken = accesstoken;
        }
        /// <summary> Cliente </summary>
        public CustomersController Customer => CustomersController.Instance;
        /// <summary> Conciliação </summary>
        public ConciliationsController Conciliation => ConciliationsController.Instance;
        /// <summary> Conta Clássica </summary>
        public ClassicAccountsController ClassicAccount => ClassicAccountsController.Instance;
        /// <summary> Conta Transparente </summary>
        public TransparentAccountsController TransparentAccount => TransparentAccountsController.Instance;
        /// <summary> Conta Bancária </summary>
        public BankAccountsController BankAccount => BankAccountsController.Instance;
        /// <summary> Lançamento </summary>
        public LaunchesController Launch => LaunchesController.Instance;
        /// <summary> Multi-Pagamento </summary>
        public MultiPaymentsController MultiPayment => MultiPaymentsController.Instance;
        /// <summary> Multi-Pedido </summary>
        public MultiOrdersController MultiOrder => MultiOrdersController.Instance;
        /// <summary> Notificação </summary>
        public NotificationsController Notification => NotificationsController.Instance;
        /// <summary> Pagamento </summary>
        public PaymentsController Payment => PaymentsController.Instance;
        /// <summary> Pedido </summary>
        public OrdersController Order => OrdersController.Instance;
        /// <summary> Reembolso </summary>
        public RefundsController Refund => RefundsController.Instance;
        /// <summary> Saldos </summary>
        public BalancesController Balance => BalancesController.Instance;
        /// <summary> Transferência </summary>
        public TransfersController Transfer => TransfersController.Instance;
    }
}