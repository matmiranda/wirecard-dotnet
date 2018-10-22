<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://res.cloudinary.com/https-github-com-matmiranda-moipcsharp/image/upload/v1540216474/Wirecard%20png.png" alt="Moip logo" width=200>
  </a>
  <p align="center">
    O jeito mais simples e rápido de integrar o Wirecard a sua aplicação .NET
    <br>
    <a href="https://dev.moip.com.br/v2.0/docs">Documentação</a>
    .
    <a href="https://dev.moip.com.br/v2.0/reference">Referência API</a>
    ·
    <a href="https://slackin-cqtchmfquq.now.sh/">Slack</a>
  </p>
</p>

## Índice
- [Instalação](#instalação)
- [Autenticando e configurando o ambiente](#autenticando-e-configurando-o-ambiente)
- [Conta Clássica](#conta-clássica)
- [Conta Transparente](#conta-transparente)
- [Clientes](#clientes)
- [Pedidos](#pedidos)
- [Pagamentos](#pagamentos)
- [Multipedidos](#multipedidos)
- [Multipagamentos](#multipagamentos)
- [Notificações](#notificações)
- [Contas Bancárias](#contas-bancárias)
- [Saldo Moip](#saldo-moip)
- [Lançamentos](#lançamentos)
- [Transferências](#transferências)
- [Reembolsos](#reembolsos)
- [Conciliação](#conciliação)
- [Tabela - Filtros de busca](#tabela---filtros-de-busca)
- [Exceção](#exceção)
- [Licença](#licença)

## Instalação
Execute o comando para instalar via [NuGet](https://www.nuget.org/packages/MoipCSharp/):

```xml
PM> Install-Package MoipCSharp -Version 4.0.9
```

## Autenticando e configurando o ambiente
Informe seu token e em qual "meio ambiente" você quer executar suas ações:

```C#
using MoipCSharp;
using MoipCSharp.Models;

private const string accessToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx_v2";
private MoipCSharpClient MoipCSharpClient = new MoipCSharpClient(Environments.SANDBOX, accessToken);
```

## Conta Clássica
#### Verificar se usuário já possui Conta Moip (email)
```C#
var result = await MoipCSharpClient.ClassicAccount.AccountExist("meu_email@email.com");
```

#### Verificar se usuário já possui Conta Moip (documento)
```C#
var result = await MoipCSharpClient.ClassicAccount.AccountExist("123.456.789-01");
```

#### Criar Conta Moip Clássica
```C#
var body = new ClassicAccountRequest
{
    //informe os campos aqui
};
var result = await MoipCSharpClient.ClassicAccount.Create(body);
```

#### Consultar Conta Moip
```C#
var result = await MoipCSharpClient.ClassicAccount.Consult("MPA-XXXXXXXXXXXX");
```

#### Solicitar Permissões de Acesso ao Usuário
```C#
var result = await MoipCSharpClient.ClassicAccount.RequestUserAccessPermissions(/*informe o valor de cada parâmetro*/);
```

#### Gerar Access Token
```C#
var result = await MoipCSharpClient.ClassicAccount.GenerateAccessToken(/*informe o valor de cada parâmetro*/);
```

#### Atualizar accessToken
```C#
var result = await MoipCSharpClient.ClassicAccount.UpdateAccessToken(/*informe o valor de cada parâmetro*/);
```

#### Obter chave pública de uma Conta Moip
```C#
var result = await MoipCSharpClient.ClassicAccount.GetPublickey();
```

## Conta Transparente
#### Criar Conta Moip Transparente
```C#
var body = new TransparentAccountRequest
{
    transparentAccount = true,
    type = "MERCHANT",
    email = new Email
    {
        address = "teste@hotmail.com"
    },
    person = new Person
    {
        name = "PrimeiroNome",
        lastName = "SegundoNome",
        taxDocument = new Taxdocument
        {
            type = "CPF",
            number = "123.456.798-91"
        },
        birthDate = "2011-01-01",
        phone = new Phone
        {
            countryCode = "55",
            areaCode = "11",
            number = "965213244"
        },
        address = new Address
        {
            street = "Av. Brigadeiro Faria Lima",
            streetNumber = "2927",
            district = "Itaim",
            zipCode = "01234000",
            city = "Osasco",
            state = "SP",
            country = "BRA"
        }                    
    }
};
var result = await MoipCSharpClient.TransparentAccount.Create(body);
```

## Clientes
#### Criar Cliente
```C#
var body = new CustomerRequest
{
    //informe os campos aqui
};
var result = await MoipCSharpClient.Customer.Create(body);
```

#### Adicionar Cartão de Crédito
```C#
var body = new CustomerRequest
{
    method = "CREDIT_CARD",
    creditCard = new Creditcard
    {
        expirationMonth = "06",
        expirationYear = "2022",
        number = "4012001037141112",
        cvc = "123",
        holder = new Holder
        {
            fullname = "João da Silva",
            birthdate = "1961-03-01",
            taxDocument = new Taxdocument
            {
                type = "CPF",
                number = "11111111111"
            },
            phone = new Phone
            {
                countryCode = "55",
                areaCode = "11",
                number = "111111111"
            }
        }
    }
};
var result = await MoipCSharpClient.Customer.AddCreditCard(body, "CUS-XXXXXXXXXXXX");
```

#### Deletar Cartão de Crédito
```C#
var result = await MoipCSharpClient.Customer.DeleteCreditCard("CRC-XXXXXXXXXXXX");
```

#### Consultar Cliente
```C#
var result = await MoipCSharpClient.Customer.Consult("CUS-XXXXXXXXXXXX");
```

#### Listar Todos os Clientes
```C#
var result = await MoipCSharpClient.Customer.List();
```

## Pedidos
#### Criar Pedido
```C#
var body = new OrderRequest
{
    //informe os campos aqui
};
var result = await MoipCSharpClient.Order.Create(body);
```

#### Consultar Pedido
```C#
var result = await MoipCSharpClient.Order.Consult("ORD-XXXXXXXXXXXX");
```

#### Listar Todos os Pedidos - Sem Filtros
```C#
var result = await MoipCSharpClient.Order.List();
```

#### Listar Todos os Pedidos - Com Filtros
```C#
string filtros = "q=josesilva&filters=status::in(PAID,WAITING)|paymentMethod::in(CREDIT_CARD,BOLETO)|value::bt(5000,10000)&limit=3&offset=0";
var result = await MoipCSharpClient.Order.ListFilter(filtros);
```
 Veja a tabela filtros de busca [aqui](#tabela---filtros-de-busca).
 
 ## Pagamentos
 #### Criar Pagamento
 ```C#
var body = new PaymentRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.Payment.Create(body, "ORD-XXXXXXXXXXXX");
```

#### Liberação de Custódia
```C#
var result = await MoipCSharpClient.Payment.ReleaseCustody("ECW-XXXXXXXXXXXX");
```

#### Capturar Pagamento Pré-autorizado
```C#
var result = await MoipCSharpClient.Payment.CaptureAuthorized("PAY-XXXXXXXXXXXX");
```

#### Cancelar Pagamento Pré-autorizado
```C#
var result = await MoipCSharpClient.Payment.CancelAuthorized("PAY-XXXXXXXXXXXX");
```

#### Consultar Pagamento
```C#
var result = await MoipCSharpClient.Payment.Consult("PAY-XXXXXXXXXXXX");
```

#### Simular Pagamentos (sandbox)
```C#
var result = await MoipCSharpClient.Payment.Simulate("PAY-XXXXXXXXXXXX", 26500);
```

## Multipedidos
#### Criar Multipedido
```C#
var body = new MultiOrderRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.MultiOrder.Create(body);
```

#### Consultar Multipedido
```C#
var result = await MoipCSharpClient.MultiOrder.Consult("MOR-XXXXXXXXXXXX");
```

## Multipagamentos
#### Criar Multipagamento
```C#
var body = new MultiPaymentRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.MultiPayment.Create(body, "MOR-XXXXXXXXXXXX");
```
#### Consultar Multipagamento
```C#
var result = await MoipCSharpClient.MultiPayment.Consult("MPY-XXXXXXXXXXXX");
```
#### Capturar Multipagamento Pré-autorizado
```C#
var result = await MoipCSharpClient.MultiPayment.CaptureAuthorized("MPY-XXXXXXXXXXXX");
```
#### Cancelar Multipagamento Pré-autorizado
```C#
var result = await MoipCSharpClient.MultiPayment.CancelAuthorized("MPY-XXXXXXXXXXXX");
```
#### Liberação de Custódia
```C#
var result = await MoipCSharpClient.MultiPayment.ReleaseCustody("ECW-XXXXXXXXXXXX");
```

## Notificações
#### Criar Preferência de Notificação para Conta Moip
```C#
var body = new NotificationRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.Notification.CreatAccountMoip(body);
```

#### Criar Preferência de Notificação para App
```C#
var body = new NotificationRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.Notification.CreateApp(body, "APP-XXXXXXXXXXXX");
```

#### Consultar Preferência de Notificação
```C#
var result = await MoipCSharpClient.Notification.Consult("NPR-XXXXXXXXXXXX");
```

#### Listar Todas as Preferências de Notificação
```C#
var result = await MoipCSharpClient.Notification.List();
```

#### Remover Preferência de Notificação
```C#
var result = await MoipCSharpClient.Notification.Remove("NPR-XXXXXXXXXXXX");
```

#### Consultar Webhook Enviado
```C#
var result = await MoipCSharpClient.Notification.ConsultWebhook("PAY-XXXXXXXXXXXX"); 
```

#### Listar Todos os Webhooks Enviados
```C#
var result = await MoipCSharpClient.Notification.ListWebhooks();
```

## Contas Bancárias
#### Criar Conta Bancária
```C#
var body = new BankAccountRequest
{
    bankNumber = "237",
    agencyNumber = "12345",
    agencyCheckNumber = "0",
    accountNumber = "12345678",
    accountCheckNumber = "7",
    type = "CHECKING",
    holder = new Holder
    {
        taxDocument = new Taxdocument
        {
            type = "CPF",
            number = "622.134.533-22"
        },
        fullname = "Demo Moip"
    }
};
string accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"; // accesstoken do recebedor
var result = await MoipCSharpClient.BankAccount.Create(body, accesstoken, "MPA-XXXXXXXXXXXX");
```

#### Consultar Conta Bancária
```C#
string accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"; // accesstoken do recebedor
var result = await MoipCSharpClient.BankAccount.Consult(accesstoken, "BKA-XXXXXXXXXXXX");
```

#### Listar Todas Contas Bancárias
```C#
string accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"; // accesstoken do recebedor
var result = await MoipCSharpClient.BankAccount.List(accesstoken, "MPA-XXXXXXXXXXXX");
```

#### Deletar Conta Bancária
```C#
string accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"; // accesstoken do recebedor
var result = await MoipCSharpClient.BankAccount.Delete(accesstoken, "BKA-XXXXXXXXXXXX");
```

#### Atualizar Conta Bancária
```C#
var body = new BankAccountRequest
{
    //informe os campos aqui
};
string accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"; // accesstoken do recebedor
var result = await MoipCSharpClient.BankAccount.Update(body, accesstoken, "BKA-XXXXXXXXXXXX");
```

## Saldo Moip
#### Consultar Saldos
```C#
var result = await MoipCSharpClient.Balance.Consult();
```

## Lançamentos
#### Consultar Lançamento
```C#
var result = await MoipCSharpClient.Launch.Consult("ENT-XXXXXXXXXXXX");
```

#### Listar Todos Lançamentos
```C#
var result = await MoipCSharpClient.Launch.List();
```

#### Listar Todos Lançamentos com Filtro
```C#
string filtros = "filters=status::in(SETTLED)";
var result = await MoipCSharpClient.Launch.ListFilter(filtros);
```

## Transferências
#### Criar Transferência
```C#
var body = new TransferRequest
{
    //informe os campos aqui
};
string accessToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx_v2";
var result = await MoipCSharpClient.Transfer.Create(body, accessToken);
```

#### Reverter Transferência
```C#
string accessToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx_v2";
var result = await MoipCSharpClient.Transfer.Revert("TRA-XXXXXXXXXXXX", accessToken);
```

#### Consultar Transferência
```C#
string accessToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx_v2";
var result = await MoipCSharpClient.Transfer.Consult("TRA-XXXXXXXXXXXX", accessToken);
```

#### Listar Todas Transferências
```C#
var result = await MoipCSharpClient.Transfer.List();
```

#### Listar Todas Transferências com filtros
```C#
string filtros = "filters=transferInstrument.method::in(MOIP_ACCOUNT)&limit=3&offset=0";
var result = await MoipCSharpClient.Transfer.List();
```

## Reembolsos
#### Reembolsar Pagamento
```C#
var body = new RefundRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.Refund.RefundPayment(body, "PAY-XXXXXXXXXXXX");
```

#### Reembolsar Pedido via Cartão de Crédito
```C#
var body = new RefundRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.Refund.RefundRequestCreditCard(body, "ORD-XXXXXXXXXXXX");
```

#### Consultar Reembolso
```C#
var result = await MoipCSharpClient.Refund.Consult("REF-XXXXXXXXXXXX");
```

#### Listar Reembolsos do Pagamento
```C#
var result = await MoipCSharpClient.Refund.ListPayments("PAY-XXXXXXXXXXXX");
```

#### Listar Reembolsos do Pedido
```C#
var result = await MoipCSharpClient.Refund.ListOrders("ORD-XXXXXXXXXXXX");
```

## Conciliação
#### Obter Arquivo de Vendas
```C#
var result = await MoipCSharpClient.Conciliation.GetSalesFile("20180829"); // Data no formato YYYYMMDD
```

#### Obter Arquivo Financeiro
```C#
var result = await MoipCSharpClient.Conciliation.GetFinancialFile("2018-08-29"); // Data no formato YYYY-MM-DD
```

## Tabela - Filtros de busca

| Nome  | Tipo | Descrição |
| ------------- | ------------- | ------------- |
| limit  | int  | Quantidade de registros por busca (página). O valor default é 20 |
| offset  | int | Registro a partir do qual a busca vai retornar. O valor default é 0 |
| gt(x)  | number or date | Maior que - “Greater Than” |
| ge(x)  | number or date | Maior ou igual - “Greater than or Equal” |
| lt(x)  | number or date | Menor que - “Less Than” |
| le(x)  | number or date | Menor ou igual - “Less than or Equal” |
| bt(x,y)  | string | Entre - “Between” |
| in(x,y…z)  | string | Em - “IN” |
| q  |  | Consulta um valor em específico |

✅ Fazendo uma busca com os seguintes requisitos:

```diff
+ Transações de valores entre 5000 e 10000 (em centavos);
+ Formas de pagamento: Cartão de Crédito e Boleto;
+ Cliente com o nome jose silva;
+ Retornando 3 resultados.
```

> GET https: //sandbox.moip.com.br/v2/orders?q=jose silva
&filters=status::in(PAID,WAITING)|paymentMethod::in(CREDIT_CARD,BOLETO)
|value::bt(5000,10000)&limit=3&offset=0

Você pode também fazer uma busca por pedidos dentro de um intervalo de tempo:

> GET https: //sandbox.moip.com.br/v2/orders?filters=createdAt::bt(2017-10-10T13:07:00Z,2017-10-25T13:08:00Z)

## Exceção
#### Obter erros
Você pode recuperar os atributos `code`, `path`, `description`, `message` e `error`, veja no exemplo abaixo:
```C#
using MoipCSharp.Exception;

try
{
    var result = await MoipCSharpClient.Cliente.CriarCliente(new CriarClienteRequest());
}
catch (MoipException ex)
{
    var t = ex.errors;
}
```

#### Tabela de erros

| Nome  | Descrição | Detalhe |
| ------------- | ------------- | ------------- |
| code  | Código identificador do erro  | string |
| path  | Parâmetro relacionado ao erro | string |
| description  | Descrição do erro | string |
| message  | Mensagem do retorno Moip  | string |



## Licença

[The MIT License](https://github.com/matmiranda/MoipCSharp/blob/master/LICENSE)

Tem dúvidas? Fale com a gente no [Slack](https://slackin-cqtchmfquq.now.sh/)!
Algum problema ? Abre issues!
