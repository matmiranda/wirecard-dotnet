<p align="center">
  <a href="https://dev.wirecard.com.br/v2.0/">
    <img src="https://res.cloudinary.com/https-github-com-matmiranda-moipcsharp/image/upload/v1540216474/Wirecard%20png.png" alt="Wirecard logo" width=200>
  </a>
  <p align="center">
    O jeito mais simples e rápido de integrar o Wirecard a sua aplicação .NET e feito com base nas APIs REST do Wirecard.
    <br>
    <a href="https://dev.wirecard.com.br/v2.0/docs">Documentação</a>
    .
    <a href="https://dev.wirecard.com.br/v2.0/reference">Referência API</a>
    ·
    <a href="https://slackin-cqtchmfquq.now.sh/">Comunidade Slack</a>
  </p>
</p>

## Índice
- [Implementações .NET com suporte](#implementações-net-com-suporte)
- [Aviso Importante](#aviso-importante)
- [Instalação](#instalação)
- [Autenticando e configurando o ambiente (E-Commerce)](#autenticando-e-configurando-o-ambiente-e-commerce)
- [Autenticando e configurando o ambiente (Marketplace)](#autenticando-e-configurando-o-ambiente-marketplace)
- [Assíncrona x Síncrona](#assíncrona-x-síncrona)
- [Conta Clássica](#conta-clássica)
- [Conta Transparente](#conta-transparente)
- [Clientes](#clientes)
- [Pedidos](#pedidos)
- [Pagamentos](#pagamentos)
- [Multipedidos](#multipedidos)
- [Multipagamentos](#multipagamentos)
- [Notificações](#notificações)
- [Contas Bancárias](#contas-bancárias)
- [Saldo Wirecard](#saldo-wirecard)
- [Lançamentos](#lançamentos)
- [Transferências](#transferências)
- [Reembolsos](#reembolsos)
- [Conciliação](#conciliação)
- [Tabela - Filtros de busca](#tabela---filtros-de-busca)
- [Exceção](#exceção)
- [Licença](#licença)

## Implementações .NET com suporte
Essa biblioteca foi feito em .NET Standard 2.0 e tem suporte das seguintes implementações do .NET:

* .NET Core 2.0 ou posterior
* .NET Framework 4.6.1 ou posterior
* Mono 5.4 ou posterior
* Xamarin.iOS 10.14 ou posterior
* Xamarin.Mac 3.8 ou posterior
* Xamarin.Android 8.0 ou posterior
* Plataforma Universal do Windows 10.0.16299 ou posterior

Para mais informações: [.NET Standard](https://docs.microsoft.com/pt-br/dotnet/standard/whats-new/whats-new-in-dotnet-standard?tabs=csharp).

## Aviso Importante
Pensando em melhorar ainda mais a sua segurança e para atender a padrões internacionais do nosso selo PCI Compliance, o Wirecard desativará protocolos de segurança TLS (Transport Layer Security) inferiores a 1.2 à partir do dia 30/06/2018. Verifique se o seu projeto já possui TLS na versão 1.2, caso não, você receberá uma exceção:

```diff
- InnerException = {"A solicitação foi anulada: Não foi possível criar um canal seguro para SSL/TLS."}
```
Para isso, adicione o seguinte código no seu projeto:

```C#
System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
```
Para mais informações : [TLS1.2](https://dev.wirecard.com.br/page/atualiza%C3%A7%C3%A3o-do-protocolo-de-seguran%C3%A7a-tls-12).

## Instalação
Execute o comando para instalar via [NuGet](https://www.nuget.org/packages/WirecardCSharp/):

```xml
PM> Install-Package WirecardCSharp
```

Obs: Trocamos a biblioteca [MoipCSharp](https://www.nuget.org/packages/MoipCSharp/) por [WirecardCSharp](https://www.nuget.org/packages/WirecardCSharp/).

## Autenticando e configurando o ambiente (E-Commerce)
Escolha o "ambiente" você quer executar suas ações e informe seu (token, chave):

```C#
using WirecardCSharp;
using WirecardCSharp.Models;

private const string token = "xxxxxxxxxxxxxxxxxxx";
private const string key = "xxxxxxxxxxxxxxxxxxxxxxxxxx";
private WirecardClient WirecardClient = new WirecardClient(Environments.SANDBOX, token, key);
```
Para obter um token e a chave, primeiro faça o login [aqui](https://connect-sandbox.wirecard.com.br/login).

Você pode acessá-las em **Minha conta** > **Configurações** > **Chaves de Acesso**.

## Autenticando e configurando o ambiente (Marketplace)
Escolha o "ambiente" você quer executar suas ações e informe seu accesstoken: 
```C#
using WirecardCSharp;
using WirecardCSharp.Models;

private const string accessToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx_v2";
private WirecardClient WirecardClient = new WirecardClient(Environments.SANDBOX, accessToken);
```

Para obter o accesstoken, você precisa criar um [App](https://dev.wirecard.com.br/reference#1-criar-um-app).

## Assíncrona x Síncrona
Todos os métodos são **assíncronos**, caso você queira executar de forma **síncrona**, veja o exemplo:

```C#
var result = Task.Run(() => WirecardClient.Customer.List()).Result;
```

## Conta Clássica
#### Verificar se usuário já possui Conta Wirecard (email)
![#f03c15](https://placehold.it/15/f03c15/000000?text=+) Essa função funciona somente na conta clássica.
```C#
var result = await WirecardClient.ClassicAccount.AccountExist("meu_email@email.com");
if (result == HttpStatusCode.OK)
{
    // já existe
    //HttpStatusCode.OK == 200 (já existe)
    //HttpStatusCode.BadRequest == 400 (CPF inválido)
    //HttpStatusCode.NotFound == 404 (Para CPF válido, mas não possui Conta Wirecard)
}
```

#### Verificar se usuário já possui Conta Wirecard (documento)
![#f03c15](https://placehold.it/15/f03c15/000000?text=+) Essa função funciona somente na conta clássica.
```C#
var result = await WirecardClient.ClassicAccount.AccountExist("123.456.789-01");
if (result == HttpStatusCode.OK)
{
    // já existe
    //HttpStatusCode.OK == 200 (já existe)
    //HttpStatusCode.BadRequest == 400 (CPF inválido)
    //HttpStatusCode.NotFound == 404 (Para CPF válido, mas não possui Conta Wirecard)
}
```

#### Criar Conta Wirecard Clássica
```C#
var body = new ClassicAccountRequest
{
    //informe os campos aqui
};
var result = await WirecardClient.ClassicAccount.Create(body);
```

#### Consultar Conta Wirecard
```C#
var result = await WirecardClient.ClassicAccount.Consult("MPA-XXXXXXXXXXXX");
```

#### Solicitar Permissões de Acesso ao Usuário
```C#
var result = await WirecardClient.ClassicAccount.RequestUserAccessPermissions(/*informe o valor de cada parâmetro*/);
```

#### Gerar Access Token
```C#
var result = await WirecardClient.ClassicAccount.GenerateAccessToken(/*informe o valor de cada parâmetro*/);
```

#### Atualizar accessToken
```C#
var result = await WirecardClient.ClassicAccount.UpdateAccessToken(/*informe o valor de cada parâmetro*/);
```

#### Obter chave pública de uma Conta Wirecard
```C#
var result = await WirecardClient.ClassicAccount.GetPublickey();
```

## Conta Transparente
#### Criar Conta Wirecard Transparente
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
var result = await WirecardClient.TransparentAccount.Create(body);
```

## Clientes
#### Criar Cliente
```C#
var body = new CustomerRequest
{
    //informe os campos aqui
};
var result = await WirecardClient.Customer.Create(body);
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
var result = await WirecardClient.Customer.AddCreditCard(body, "CUS-XXXXXXXXXXXX");
```

#### Deletar Cartão de Crédito
```C#
var result = await WirecardClient.Customer.DeleteCreditCard("CRC-XXXXXXXXXXXX");
```

#### Consultar Cliente
```C#
var result = await WirecardClient.Customer.Consult("CUS-XXXXXXXXXXXX");
```

#### Listar Todos os Clientes
```C#
var result = await WirecardClient.Customer.List();
```

## Pedidos
#### Criar Pedido
```C#
var body = new OrderRequest
{
    //informe os campos aqui
};
var result = await WirecardClient.Order.Create(body);
```

#### Consultar Pedido
```C#
var result = await WirecardClient.Order.Consult("ORD-XXXXXXXXXXXX");
```

#### Listar Todos os Pedidos - Sem Filtros
```C#
var result = await WirecardClient.Order.List();
```

#### Listar Todos os Pedidos - Com Filtros
```C#
string filtros = "q=josesilva&filters=status::in(PAID,WAITING)|paymentMethod::in(CREDIT_CARD,BOLETO)|value::bt(5000,10000)&limit=3&offset=0";
var result = await WirecardClient.Order.ListFilter(filtros);
```
 Veja a tabela filtros de busca [aqui](#tabela---filtros-de-busca).
 
 ## Pagamentos
 #### Criar Pagamento
 ```C#
var body = new PaymentRequest
{
    //informe os campos aqui
};            
var result = await WirecardClient.Payment.Create(body, "ORD-XXXXXXXXXXXX");
```

#### Liberação de Custódia
```C#
var result = await WirecardClient.Payment.ReleaseCustody("ECW-XXXXXXXXXXXX");
```

#### Capturar Pagamento Pré-autorizado
```C#
var result = await WirecardClient.Payment.CaptureAuthorized("PAY-XXXXXXXXXXXX");
```

#### Cancelar Pagamento Pré-autorizado
```C#
var result = await WirecardClient.Payment.CancelAuthorized("PAY-XXXXXXXXXXXX");
```

#### Consultar Pagamento
```C#
var result = await WirecardClient.Payment.Consult("PAY-XXXXXXXXXXXX");
```

#### Simular Pagamentos (sandbox)
```C#
var result = await WirecardClient.Payment.Simulate("PAY-XXXXXXXXXXXX", 26500);
```

## Multipedidos
#### Criar Multipedido
```C#
var body = new MultiOrderRequest
{
    //informe os campos aqui
};            
var result = await WirecardClient.MultiOrder.Create(body);
```

#### Consultar Multipedido
```C#
var result = await WirecardClient.MultiOrder.Consult("MOR-XXXXXXXXXXXX");
```

## Multipagamentos
#### Criar Multipagamento
```C#
var body = new MultiPaymentRequest
{
    //informe os campos aqui
};            
var result = await WirecardClient.MultiPayment.Create(body, "MOR-XXXXXXXXXXXX");
```
#### Consultar Multipagamento
```C#
var result = await WirecardClient.MultiPayment.Consult("MPY-XXXXXXXXXXXX");
```
#### Capturar Multipagamento Pré-autorizado
```C#
var result = await WirecardClient.MultiPayment.CaptureAuthorized("MPY-XXXXXXXXXXXX");
```
#### Cancelar Multipagamento Pré-autorizado
```C#
var result = await WirecardClient.MultiPayment.CancelAuthorized("MPY-XXXXXXXXXXXX");
```
#### Liberação de Custódia
```C#
var result = await WirecardClient.MultiPayment.ReleaseCustody("ECW-XXXXXXXXXXXX");
```

## Notificações
#### Criar Preferência de Notificação para Conta Wirecard
```C#
var body = new NotificationRequest
{
    //informe os campos aqui
};            
var result = await WirecardClient.Notification.CreatAccountWirecard(body);
```

#### Criar Preferência de Notificação para App
```C#
var body = new NotificationRequest
{
    //informe os campos aqui
};            
var result = await WirecardClient.Notification.CreateApp(body, "APP-XXXXXXXXXXXX");
```

#### Consultar Preferência de Notificação
```C#
var result = await WirecardClient.Notification.Consult("NPR-XXXXXXXXXXXX");
```

#### Listar Todas as Preferências de Notificação
```C#
var result = await WirecardClient.Notification.List();
```

#### Remover Preferência de Notificação
```C#
var result = await WirecardClient.Notification.Remove("NPR-XXXXXXXXXXXX");
```

#### Consultar Webhook Enviado
```C#
var result = await WirecardClient.Notification.ConsultWebhook("PAY-XXXXXXXXXXXX"); 
```

#### Listar Todos os Webhooks Enviados
```C#
var result = await WirecardClient.Notification.ListWebhooks();
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
        fullname = "Demo Wirecard"
    }
};
string accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"; // accesstoken do recebedor
var result = await WirecardClient.BankAccount.Create(body, accesstoken, "MPA-XXXXXXXXXXXX");
```

#### Consultar Conta Bancária
```C#
string accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"; // accesstoken do recebedor
var result = await WirecardClient.BankAccount.Consult(accesstoken, "BKA-XXXXXXXXXXXX");
```

#### Listar Todas Contas Bancárias
```C#
string accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"; // accesstoken do recebedor
var result = await WirecardClient.BankAccount.List(accesstoken, "MPA-XXXXXXXXXXXX");
```

#### Deletar Conta Bancária
```C#
string accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"; // accesstoken do recebedor
var result = await WirecardClient.BankAccount.Delete(accesstoken, "BKA-XXXXXXXXXXXX");
```

#### Atualizar Conta Bancária
```C#
var body = new BankAccountRequest
{
    //informe os campos aqui
};
string accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"; // accesstoken do recebedor
var result = await WirecardClient.BankAccount.Update(body, accesstoken, "BKA-XXXXXXXXXXXX");
```

## Saldo Wirecard
#### Consultar Saldos
```C#
var result = await WirecardClient.Balance.Consult();
```

## Lançamentos
#### Consultar Lançamento
```C#
var result = await WirecardClient.Launch.Consult("ENT-XXXXXXXXXXXX");
```

#### Listar Todos Lançamentos
```C#
var result = await WirecardClient.Launch.List();
```

#### Listar Todos Lançamentos com Filtro
```C#
string filtros = "filters=status::in(SETTLED)";
var result = await WirecardClient.Launch.ListFilter(filtros);
```

## Transferências
#### Criar Transferência
```C#
var body = new TransferRequest
{
    //informe os campos aqui
};
string accessToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx_v2";
var result = await WirecardClient.Transfer.Create(body, accessToken);
```

#### Reverter Transferência
```C#
string accessToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx_v2";
var result = await WirecardClient.Transfer.Revert("TRA-XXXXXXXXXXXX", accessToken);
```

#### Consultar Transferência
```C#
string accessToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx_v2";
var result = await WirecardClient.Transfer.Consult("TRA-XXXXXXXXXXXX", accessToken);
```

#### Listar Todas Transferências
```C#
var result = await WirecardClient.Transfer.List();
```

#### Listar Todas Transferências com filtros
```C#
string filtros = "filters=transferInstrument.method::in(MOIP_ACCOUNT)&limit=3&offset=0";
var result = await WirecardClient.Transfer.List();
```

## Reembolsos
#### Reembolsar Pagamento
```C#
var body = new RefundRequest
{
    //informe os campos aqui
};            
var result = await WirecardClient.Refund.RefundPayment(body, "PAY-XXXXXXXXXXXX");
```

#### Reembolsar Pedido via Cartão de Crédito
```C#
var body = new RefundRequest
{
    //informe os campos aqui
};            
var result = await WirecardClient.Refund.RefundRequestCreditCard(body, "ORD-XXXXXXXXXXXX");
```

#### Consultar Reembolso
```C#
var result = await WirecardClient.Refund.Consult("REF-XXXXXXXXXXXX");
```

#### Listar Reembolsos do Pagamento
```C#
var result = await WirecardClient.Refund.ListPayments("PAY-XXXXXXXXXXXX");
```

#### Listar Reembolsos do Pedido
```C#
var result = await WirecardClient.Refund.ListOrders("ORD-XXXXXXXXXXXX");
```

## Conciliação
#### Obter Arquivo de Vendas
```C#
var result = await WirecardClient.Conciliation.GetSalesFile("20180829"); // Data no formato YYYYMMDD
```

#### Obter Arquivo Financeiro
```C#
var result = await WirecardClient.Conciliation.GetFinancialFile("2018-08-29"); // Data no formato YYYY-MM-DD
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
using WirecardCSharp.Exception;

try
{
    var result = await WirecardClient.Cliente.CriarCliente(new CriarClienteRequest());
}
catch (WirecardException ex)
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
| message  | Mensagem do retorno Wirecard  | string |



## Licença

[The MIT License](https://github.com/matmiranda/WirecardCSharp/blob/master/LICENSE)

Tem dúvidas? Fale com a gente no [Slack](https://slackin-cqtchmfquq.now.sh/)!
Algum problema ? Abre issues!
