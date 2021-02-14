using System;
using System.Text;
using Wirecard.Controllers;
using System.Text.RegularExpressions;

namespace Wirecard
{
    public partial class WirecardClient
    {
        public readonly Http_Client _httpClient;

        /// <summary>
        /// Tipo de negócio: MARKETPLACE
        /// </summary>
        /// <param name="environments">Escolha um "meio ambiente" você quer executar suas ações</param>
        /// <param name="accesstoken">accesstoken</param>
        public WirecardClient(Environments environments, string accesstoken)
        {
            var regex = new Regex(@"^[a-zA-Z0-9]{32}_v2$");
            var match = regex.Match(accesstoken);
            if (!match.Success)
                throw new ArgumentException("accesstoken invalid");

            _httpClient = new Http_Client(environments, accesstoken, "MARKETPLACE");
        }
        /// <summary>
        /// Tipo de negócio: E-COMMERCE
        /// </summary>
        /// <param name="environments">Escolha um "meio ambiente" você quer executar suas ações</param>
        /// <param name="token">token</param>
        /// <param name="key">chave</param>
        public WirecardClient(Environments environments, string token, string key)
        {
            var TextByte = Encoding.UTF8.GetBytes($"{token}:{key}");
            var base64 = Convert.ToBase64String(TextByte);
            var regex = new Regex(@"^[a-zA-Z0-9]{98}==$");
            var match = regex.Match(base64);
            if (token.Length != 32 || key.Length != 40)
            {
                throw new ArgumentException("(token or key) invalid");
            }
            if (!match.Success)
            {
                throw new ArgumentException("base64 invalid");
            }

            _httpClient = new Http_Client(environments, base64, "E-COMMERCE");
        }
        /// <summary> Cliente </summary>
        public CustomersController Customer => new CustomersController(_httpClient);
        /// <summary> Conciliação </summary>
        public ConciliationsController Conciliation => new ConciliationsController(_httpClient);
        /// <summary> Conta Clássica </summary>
        public ClassicAccountsController ClassicAccount => new ClassicAccountsController(_httpClient);
        /// <summary> Conta Transparente </summary>
        public TransparentAccountsController TransparentAccount => new TransparentAccountsController(_httpClient);
        /// <summary> Conta Bancária </summary>
        public BankAccountsController BankAccount => new BankAccountsController(_httpClient);
        /// <summary> Lançamento </summary>
        public LaunchesController Launch => new LaunchesController(_httpClient);
        /// <summary> Extrato </summary>
        public ExtractsController Extract => new ExtractsController(_httpClient);
        /// <summary> Multi-Pagamento </summary>
        public MultiPaymentsController MultiPayment => new MultiPaymentsController(_httpClient);
        /// <summary> Multi-Pedido </summary>
        public MultiOrdersController MultiOrder => new MultiOrdersController(_httpClient);
        /// <summary> Notificação </summary>
        public NotificationsController Notification => new NotificationsController(_httpClient);
        /// <summary> Pagamento </summary>
        public PaymentsController Payment => new PaymentsController(_httpClient);
        /// <summary> Pedido </summary>
        public OrdersController Order => new OrdersController(_httpClient);
        /// <summary> Reembolso </summary>
        public RefundsController Refund => new RefundsController(_httpClient);
        /// <summary> Saldos </summary>
        public BalancesController Balance => new BalancesController(_httpClient);
        /// <summary> Transferência </summary>
        public TransfersController Transfer => new TransfersController(_httpClient);
        /// <summary> Assinatura </summary>
        public SignaturesController Signature => new SignaturesController(_httpClient);
        /// <summary>Obtem o tipo de negócio: Valores possíveis: E-COMMERCE, MARKETPLACE </summary>
        public string _BusinessType => _httpClient.BusinessType;
    }
}