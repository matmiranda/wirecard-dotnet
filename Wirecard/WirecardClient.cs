using System;
using System.Text;
using Wirecard.Controllers;
using System.Text.RegularExpressions;

namespace Wirecard
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
            if (!string.IsNullOrEmpty(Http_Client.BusinessType))
                if (Http_Client.BusinessType != "MARKETPLACE")
                    throw new ArgumentException("Business type already defined: E-COMMERCE.");
            var regex = new Regex(@"^[a-zA-Z0-9]{32}_v2$");
            var match = regex.Match(accesstoken);
            if (!match.Success)
                throw new ArgumentException("accesstoken invalid");        
            Http_Client.SelectedEnvironment = environments;
            Http_Client.Accesstoken = accesstoken;
            Http_Client.BusinessType = "MARKETPLACE";
            if (Http_Client.HttpClient == null)
            {
                Http_Client.Client();
            }
            if (Http_Client.HttpClient_Connect == null)
            {
                Http_Client.Client_Connect();
            }
        }
        /// <summary>
        /// Tipo de negócio: E-COMMERCE
        /// </summary>
        /// <param name="environments">Escolha um "meio ambiente" você quer executar suas ações</param>
        /// <param name="token">token</param>
        /// <param name="key">chave</param>
        public WirecardClient(Environments environments, string token, string key)
        {
            if (!string.IsNullOrEmpty(Http_Client.BusinessType))
                if (Http_Client.BusinessType != "E-COMMERCE")
                    throw new ArgumentException("Business type already defined: MARKETPLACE.");
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
            Http_Client.SelectedEnvironment = environments;
            Http_Client.Base64 = base64;
            Http_Client.BusinessType = "E-COMMERCE";
            if (Http_Client.HttpClient == null)
            {
                Http_Client.Client();
            }
        }
        /// <summary> Cliente </summary>
        public CustomersController Customer => new CustomersController();
        /// <summary> Conciliação </summary>
        public ConciliationsController Conciliation => new ConciliationsController();
        /// <summary> Conta Clássica </summary>
        public ClassicAccountsController ClassicAccount => new ClassicAccountsController();
        /// <summary> Conta Transparente </summary>
        public TransparentAccountsController TransparentAccount => new TransparentAccountsController();
        /// <summary> Conta Bancária </summary>
        public BankAccountsController BankAccount => new BankAccountsController();
        /// <summary> Lançamento </summary>
        public LaunchesController Launch => new LaunchesController();
        /// <summary> Extrato </summary>
        public ExtractsController Extract => new ExtractsController();
        /// <summary> Multi-Pagamento </summary>
        public MultiPaymentsController MultiPayment => new MultiPaymentsController();
        /// <summary> Multi-Pedido </summary>
        public MultiOrdersController MultiOrder => new MultiOrdersController();
        /// <summary> Notificação </summary>
        public NotificationsController Notification => new NotificationsController();
        /// <summary> Pagamento </summary>
        public PaymentsController Payment => new PaymentsController();
        /// <summary> Pedido </summary>
        public OrdersController Order => new OrdersController();
        /// <summary> Reembolso </summary>
        public RefundsController Refund => new RefundsController();
        /// <summary> Saldos </summary>
        public BalancesController Balance => new BalancesController();
        /// <summary> Transferência </summary>
        public TransfersController Transfer => new TransfersController();
        /// <summary> Assinatura </summary>
        public SignaturesController Signature => new SignaturesController();
        /// <summary>Obtem o tipo de negócio: Valores possíveis: E-COMMERCE, MARKETPLACE </summary>
        public string _BusinessType => Http_Client.BusinessType;
        /// <summary>Altera AccessToken - MarketPlace</summary>
        public void ChangeAccessToken(string accesstoken) => Http_Client.ChangeAccessToken(accesstoken);
        /// <summary>Altera Token - E-Commerce</summary>
        public void ChangeToken(string token, string key) => Http_Client.ChangeToken(token, key);
    }
}