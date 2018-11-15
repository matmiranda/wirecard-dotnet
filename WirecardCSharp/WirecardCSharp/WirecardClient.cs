using System;
using System.Text;
using WirecardCSharp.Controllers;
using System.Text.RegularExpressions;

namespace WirecardCSharp
{
    public partial class WirecardClient
    {
        /// <summary>
        /// Tipo de negócio: MARKETPLACE
        /// </summary>
        /// <param name="environments">Escolha um "meio ambiente" você quer executar suas ações</param>
        /// <param name="accesstoken">accesstoken</param>
        public WirecardClient(Environments environments, string accesstoken)
        {
            if (!string.IsNullOrEmpty(_HttpClient.BusinessType))
            {
                if (_HttpClient.BusinessType != "MARKETPLACE")
                {
                    string newLine = Environment.NewLine;
                    throw new ArgumentException("Business type already defined: E-COMMERCE.");
                }
            }
            Regex regex = new Regex(@"^[a-zA-Z0-9]{32}_v2$");
            Match match = regex.Match(accesstoken);
            if (!match.Success)
            {
                throw new ArgumentException("accesstoken invalid");
            }            
            _HttpClient.uri = environments == Environments.SANDBOX ? BaseAddress.SANDBOX : BaseAddress.PRODUCTION;
            _HttpClient.accesstoken = accesstoken;
            _HttpClient.BusinessType = "MARKETPLACE";
        }

        /// <summary>
        /// Tipo de negócio: E-COMMERCE
        /// </summary>
        /// <param name="environments">Escolha um "meio ambiente" você quer executar suas ações</param>
        /// <param name="token">token</param>
        /// <param name="key">chave</param>
        public WirecardClient(Environments environments, string token, string key)
        {
            if (!string.IsNullOrEmpty(_HttpClient.BusinessType))
            {
                if (_HttpClient.BusinessType != "E-COMMERCE")
                {
                    string newLine = Environment.NewLine;
                    throw new ArgumentException("Business type already defined: MARKETPLACE.");
                }
            }
            byte[] TextByte = Encoding.UTF8.GetBytes($"{token}:{key}");
            string base64 = Convert.ToBase64String(TextByte);
            Regex regex = new Regex(@"^[a-zA-Z0-9]{98}==$");
            Match match = regex.Match(base64);
            if (token.Length != 32 || key.Length != 40)
            {
                throw new ArgumentException("(token or key) invalid");
            }
            if (!match.Success)
            {
                throw new ArgumentException("base64 invalid");
            }
            _HttpClient.uri = environments == Environments.SANDBOX ? BaseAddress.SANDBOX : BaseAddress.PRODUCTION;
            _HttpClient.base64 = base64;
            _HttpClient.BusinessType = "E-COMMERCE";
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
        /// <summary>Obtem o tipo de negócio: Valores possíveis: E-COMMERCE, MARKETPLACE </summary>
        public string _BusinessType => _HttpClient.BusinessType;
    }
}
