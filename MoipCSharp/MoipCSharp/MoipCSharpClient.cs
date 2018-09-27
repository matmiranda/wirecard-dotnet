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
        public CustomersController Customer => CustomersController.Instance;
        public ConciliationsController Conciliation => ConciliationsController.Instance;
        public ClassicAccountsController ClassicAccount => ClassicAccountsController.Instance;
        public TransparentAccountsController TransparentAccount => TransparentAccountsController.Instance;
        public BankAccountsController BankAccount => BankAccountsController.Instance;
        public LaunchesController Launch => LaunchesController.Instance;
        public MultiPaymentsController MultiPayment => MultiPaymentsController.Instance;
        public MultiOrdersController MultiOrder => MultiOrdersController.Instance;
        public NotificationsController Notification => NotificationsController.Instance;
        public PaymentsController Payment => PaymentsController.Instance;
        public OrdersController Order => OrdersController.Instance;
        public RefundsController Refund => RefundsController.Instance;
        public BalancesController Balance => BalancesController.Instance;
        public TransfersController Transfer => TransfersController.Instance;
    }
}
