*Ler em outras linguagens de programação: [C#](README.md), [Visual Basic](README.VisualBasic.md).*

## Índice  
- [Implementações .NET com suporte](#implementações-net-com-suporte)
- [Aviso Importante](#aviso-importante)
- [Instalação](#instalação)
- [Autenticando e configurando o ambiente (E-Commerce)](#autenticando-e-configurando-o-ambiente-e-commerce)
- [Autenticando e configurando o ambiente (Marketplace)](#autenticando-e-configurando-o-ambiente-marketplace)
- [Assíncrona x Síncrona](#assíncrona-x-síncrona)
- [Conta Clássica](#conta-clássica)
  - [Verificar se usuário já possui Conta Wirecard (email)](#verificar-se-usuário-já-possui-conta-wirecard-email)
  - [Verificar se usuário já possui Conta Wirecard (documento)](#verificar-se-usuário-já-possui-conta-wirecard-documento)
  - [Criar Conta Wirecard Clássica (Conta PF)](#criar-conta-wirecard-clássica-conta-pf)
  - [Criar Conta Wirecard Clássica (Conta PJ)](#criar-conta-wirecard-clássica-conta-pj)
  - [Consultar Conta Wirecard](#consultar-conta-wirecard)
  - [Solicitar Permissões de Acesso ao Usuário](#solicitar-permissões-de-acesso-ao-usuário)
  - [Gerar Access Token](#gerar-access-token)
  - [Atualizar accessToken](#atualizar-accesstoken)
  - [Obter chave pública de uma Conta Wirecard](#obter-chave-pública-de-uma-conta-wirecard)
- [Conta Transparente](#conta-transparente)
  - [Criar Conta Wirecard Transparente](#criar-conta-wirecard-transparente)
- [Clientes](#clientes)
  - [Criar Cliente - (E-COMMERCE)](#criar-cliente---e-commerce)
  - [Criar Cliente - (MARKETPLACE / PLATAFORMA)](#criar-cliente---marketplace--plataforma)
  - [Adicionar Cartão de Crédito](#adicionar-cartão-de-crédito)
  - [Deletar Cartão de Crédito](#deletar-cartão-de-crédito)
  - [Consultar Cliente](#consultar-cliente)
  - [Listar Todos os Clientes](#listar-todos-os-clientes)
- [Pedidos](#pedidos)
  - [Criar Pedido](#criar-pedido)
  - [Consultar Pedido](#consultar-pedido)
  - [Listar Todos os Pedidos - Sem Filtros](#listar-todos-os-pedidos---sem-filtros)
  - [Listar Todos os Pedidos - Com Filtros](#listar-todos-os-pedidos---com-filtros)
- [Pagamentos](#pagamentos)
  - [Criar Pagamento - Cartão de Crédito](#criar-pagamento---cartão-de-crédito)
  - [Criar Pagamento - Boleto](#criar-pagamento---boleto)
  - [Criar Pagamento - Débito Online](#criar-pagamento---débito-online)
  - [Liberação de Custódia](#liberação-de-custódia)
  - [Capturar Pagamento Pré-autorizado](#capturar-pagamento-pré-autorizado)
  - [Cancelar Pagamento Pré-autorizado](#cancelar-pagamento-pré-autorizado)
  - [Consultar Pagamento](#consultar-pagamento)
  - [Simular Pagamentos (sandbox)](#simular-pagamentos-sandbox)
- [Multipedidos](#multipedidos)
  - [Criar Multipedido](#criar-multipedido)
  - [Consultar Multipedido](#consultar-multipedido)
- [Multipagamentos](#multipagamentos)
  - [Criar Multipagamento](#criar-multipagamento)
  - [Consultar Multipagamento](#consultar-multipagamento)
  - [Capturar Multipagamento Pré-autorizado](#capturar-multipagamento-pré-autorizado)
  - [Cancelar Multipagamento Pré-autorizado](#cancelar-multipagamento-pré-autorizado)
  - [Liberação de Custódia](#liberação-de-custódia-1)
- [Notificações](#notificações)
  - [Criar Preferência de Notificação para Conta Wirecard](#criar-preferência-de-notificação-para-conta-wirecard)
  - [Criar Preferência de Notificação para App](#criar-preferência-de-notificação-para-app)
  - [Criar Preferência de Notificação para App com código identificador](#criar-preferência-de-notificação-para-app-com-código-identificador)
  - [Consultar Preferência de Notificação](#consultar-preferência-de-notificação)
  - [Listar Todas as Preferências de Notificação](#listar-todas-as-preferências-de-notificação)
  - [Remover Preferência de Notificação](#remover-preferência-de-notificação)
  - [Consultar Webhook Enviado](#consultar-webhook-enviado)
  - [Listar Todos os Webhooks Enviados](#listar-todos-os-webhooks-enviados)
  - [Desserializar WebHook](#desserializar-webhook)
- [Contas Bancárias](#contas-bancárias)
  - [Criar Conta Bancária](#criar-conta-bancária)
  - [Consultar Conta Bancária](#consultar-conta-bancária)
  - [Listar Todas Contas Bancárias](#listar-todas-contas-bancárias)
  - [Deletar Conta Bancária](#deletar-conta-bancária)
  - [Atualizar Conta Bancária](#atualizar-conta-bancária)
- [Saldo Wirecard](#saldo-wirecard)
  - [Consultar Saldos](#consultar-saldos)
- [Lançamentos](#lançamentos)
  - [Consultar Lançamento](#consultar-lançamento)
  - [Listar Todos Lançamentos](#listar-todos-lançamentos)
  - [Listar Todos Lançamentos com Filtro](#listar-todos-lançamentos-com-filtro)
- [Transferências](#transferências)
  - [Criar Transferência](#criar-transferência)
  - [Reverter Transferência](#reverter-transferência)
  - [Consultar Transferência](#consultar-transferência)
  - [Listar Todas Transferências](#listar-todas-transferências)
  - [Listar Todas Transferências com filtros](#listar-todas-transferências-com-filtros)
- [Reembolsos](#reembolsos)
  - [Reembolsar Pagamento](#reembolsar-pagamento)
  - [Reembolsar Pedido via Cartão de Crédito](#reembolsar-pedido-via-cartão-de-crédito)
  - [Consultar Reembolso](#consultar-reembolso)
  - [Listar Reembolsos do Pagamento](#listar-reembolsos-do-pagamento)
  - [Listar Reembolsos do Pedido](#listar-reembolsos-do-pedido)
- [Conciliação](#conciliação)
  - [Obter Arquivo de Vendas](#obter-arquivo-de-vendas)
  - [Obter Arquivo Financeiro](#obter-arquivo-financeiro)
- [Assinatura](#assinatura)
  - [Criar Plano](#criar-plano)
  - [Listar Planos](#listar-planos)
  - [Consultar Plano](#consultar-plano)
  - [Ativar Plano](#ativar-plano)
  - [Desativar Plano](#desativar-plano)
  - [Alterar Plano](#alterar-plano)
  - [Criar Assinante](#criar-assinante)
  - [Listar Assinantes](#listar-assinantes)
  - [Consultar Assinante](#consultar-assinante)
  - [Alterar Assinante](#alterar-assinante)
  - [Atualizar Cartão do Assinante](#atualizar-cartão-do-assinante)
  - [Criar Assinaturas](#criar-assinaturas)
  - [Listar Todas Assinaturas](#listar-todas-assinaturas)
  - [Consultar Assinatura -Sem Filtro](#consultar-assinatura--sem-filtro)
  - [Consultar Assinatura - Com Filtro](#consultar-assinatura---com-filtro)
  - [Suspender Assinatura](#suspender-assinatura)
  - [Reativar Assinatura](#reativar-assinatura)
  - [Cancelar Assinatura](#cancelar-assinatura)
  - [Alterar Assinatura](#alterar-assinatura)
  - [Alterar método de pagamento](#alterar-método-de-pagamento)
  - [Listar Todas as Faturas de Uma Assinatura](#listar-todas-as-faturas-de-uma-assinatura)
  - [Consultar Fatura](#consultar-fatura)
  - [Listar todos os pagamentos de fatura](#listar-todos-os-pagamentos-de-fatura)
  - [Consultar pagamento de assinatura](#consultar-pagamento-de-assinatura)
  - [Criar Cupom](#criar-cupom)
  - [Associar Cupom para Assinatura](#associar-cupom-para-assinatura)
  - [Associar Cupom para Nova Assinatura](#associar-cupom-para-nova-assinatura)
  - [Consultar Cupom](#consultar-cupom)
  - [Listar Todos os Cupons](#listar-todos-os-cupons)
  - [Ativar e Inativar Cupons](#ativar-e-inativar-cupons)
  - [Excluir Cupom de uma Assinatura](#excluir-cupom-de-uma-assinatura)
  - [Retentativa de pagamento de uma fatura](#retentativa-de-pagamento-de-uma-fatura)
  - [Gerar um novo boleto para uma fatura](#gerar-um-novo-boleto-para-uma-fatura)
  - [Criar Regras de Retentativas Automáticas](#criar-regras-de-retentativas-automáticas)
  - [Criar Preferência de Notificação](#criar-preferência-de-notificação)
- [Convertendo objeto para json](#convertendo-objeto-para-json)
- [Tabela - Filtros de busca](#tabela---filtros-de-busca)
- [Exceção](#exceção)
  - [Obter erros](#obter-erros)
- [Licença](#licença)

## Implementações .NET com suporte
Essa biblioteca foi feito em (**.NET Standard 1.2 e VS2017**) e tem suporte das seguintes implementações do .NET:

* .NET Core 1.0 ou superior
* .NET Framework 4.5.1 ou superior
* Mono 4.6 ou superior
* Xamarin.iOS 10.0 ou superior
* Xamarin.Android 7.0 ou superior
* Universal Windows Platform 10 ou superior
* Windows 8.1 ou superior
* Windows Phone 8.1 ou superior

Para mais informações: [.NET Standard](https://docs.microsoft.com/pt-br/dotnet/standard/net-standard).

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
Execute o comando para instalar via [NuGet](https://www.nuget.org/packages/Wirecard/):


```xml
PM> Install-Package Wirecard
```

💥 **Obs**: Trocamos a biblioteca [MoipCSharp](https://www.nuget.org/packages/MoipCSharp/) por [Wirecard](https://www.nuget.org/packages/Wirecard/).

## Autenticando e configurando o ambiente (E-Commerce)
Escolha o "ambiente" você quer executar suas ações e informe seu (token, chave):

```F#
open Wirecard
open Wirecard.Models

let private token = "xxxxxxxxxxxxxxxxxxx"
let private key = "xxxxxxxxxxxxxxxxxxxxxxxxxx"
let private WC = new WirecardClient(Environments.SANDBOX, token, key)
```
Para obter um token e a chave, primeiro faça o login [aqui](https://connect-sandbox.wirecard.com.br/login).

Você pode acessá-las em **Minha conta** > **Configurações** > **Chaves de Acesso**.

## Autenticando e configurando o ambiente (Marketplace)
Escolha o "ambiente" você quer executar suas ações e informe seu accesstoken: 
```F#
open Wirecard
open Wirecard.Models

let private accessToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx_v2"
let private WC = new WirecardClient(Environments.SANDBOX, accessToken)
```

Para obter o accesstoken, você precisa criar um [App](https://dev.wirecard.com.br/reference#1-criar-um-app).

## Assíncrona x Síncrona
Todos os métodos são **assíncronos**, caso você queira executar de forma **síncrona**, veja o exemplo:

```VB.NET
Dim result As OrdersResponse = Task.Run(Function() WC.Order.List()).Result
```

## Conta Clássica
#### Verificar se usuário já possui Conta Wirecard (email)
🚩 Essa função funciona somente na conta clássica.
```F#
let result = 
    async { 
        return! WC.ClassicAccount.AccountExist("meu_email@email.com") |> Async.AwaitTask 
    } |> Async.RunSynchronously
if (result = HttpStatusCode.OK) then printfn "Conta existe !"
//HttpStatusCode.OK == 200 (já existe)
//HttpStatusCode.BadRequest == 400 (CPF inválido)
//HttpStatusCode.NotFound == 404 (Para CPF válido, mas não possui Conta Wirecard)
```

#### Verificar se usuário já possui Conta Wirecard (documento)
🚩 Essa função funciona somente na conta clássica.
```F#
let result = 
    async { 
        return! WC.ClassicAccount.AccountExist("123.456.789-01") |> Async.AwaitTask 
    } |> Async.RunSynchronously
if (result = HttpStatusCode.OK) then printfn "Conta existe !"
//HttpStatusCode.OK == 200 (já existe)
//HttpStatusCode.BadRequest == 400 (CPF inválido)
//HttpStatusCode.NotFound == 404 (Para CPF válido, mas não possui Conta Wirecard)
```

#### Criar Conta Wirecard Clássica (Conta PF)
```F#
let body =
    ClassicAccountRequest(
        Email = Email(
                Address = "fulano@hotmail.com"),
        Person = Person(
            Name = "Fulano", 
            LastName = "da Silva",
            TaxDocument = Taxdocument(
                Type = "CPF", 
                Number = "123.456.789-91"),
            IdentityDocument = Identitydocument(
                Type = "RG", 
                Number = "434322344", 
                Issuer = "SPP", 
                IssueDate = "2000-12-12"),
            BirthDate = "1990-01-01",
            Phone = Phone(
                CountryCode = "55", 
                AreaCode = "11", 
                Number = "965213244"),
            Address = Address(
                Street = "Av. Brigadeiro Faria Lima", 
                StreetNumber = "2927", 
                District = "Itaim", 
                ZipCode = "01234-000", 
                City = "São Paulo", 
                State = "SP", 
                Country = "BRA")),
        Type = "MERCHANT")
let result = 
    async { 
        return! WC.ClassicAccount.Create(body) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Criar Conta Wirecard Clássica (Conta PJ)
```F#
let body =
    ClassicAccountRequest(
        Email = Email(
                Address = "fulano@hotmail.com"),
        Person = Person(
            Name = "Fulano", 
            LastName = "da Silva",
            BirthDate = "1990-01-01",
            TaxDocument = Taxdocument(
                Type = "CPF", 
                Number = "123.456.789-91"),
            IdentityDocument = Identitydocument(
                Type = "RG", 
                Number = "434322344", 
                Issuer = "SPP", 
                IssueDate = "2000-12-12"),
            Phone = Phone(
                CountryCode = "55", 
                AreaCode = "11", 
                Number = "965213244"),
            Address = Address(
                Street = "Av. Brigadeiro Faria Lima", 
                StreetNumber = "2927", 
                District = "Itaim", 
                ZipCode = "01234-000", 
                City = "São Paulo", 
                State = "SP", 
                Country = "BRA")),
        Company = Company(
            Name = "Noma da empresa", 
            BusinessName = "Wirecard Pagamentos", 
            OpeningDate = "2011-01-01",
            TaxDocument = Taxdocument(
                Type = "CNPJ", 
                Number = "11.698.147/0001-13"),
            MainActivity = Mainactivity(
                Cnae = "82.91-1/00",
                Description = "Atividades de cobranças e informações cadastrais"),
            Phone = Phone(
                CountryCode = "55", 
                AreaCode = "11", 
                Number = "32234455"),
            Address = Address(            
                Street = "Av. Brigadeiro Faria Lima",
                StreetNumber = "2927",
                District = "Itaim",
                ZipCode = "01234-000",
                City = "São Paulo",
                State = "SP",
                Country = "BRA")),
        BusinessSegment = Businesssegment(Id = 3),
        Type = "MERCHANT")
let result = 
    async { 
        return! WC.ClassicAccount.Create(body) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Consultar Conta Wirecard
```F#
let result = 
    async { 
        return! WC.ClassicAccount.Consult("MPA-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Solicitar Permissões de Acesso ao Usuário

🚩 O código a seguir não consome API, apenas monta o URL. Mais informações clica [aqui](https://dev.wirecard.com.br/reference#section-como-funciona-a-permiss%C3%A3o).

```F#
let response_type = "code"
let client_id = "APP-FFFGVQMOK123"
let redirect_uri = "https://example.com/abc?DEF=あいう えお"
let scope = "RECEIVE_FUNDS,MANAGE_ACCOUNT_INFO,DEFINE_PREFERENCES"
let url = Utilities.RequestUserAccessPermissions(response_type, client_id, redirect_uri, scope)

//https://connect-sandbox.moip.com.br/oauth/authorize?response_type=code&client_id=APP-
//FFFGVQMOK123&redirect_uri=https://example.com/abc?DEF=%E3%81%82%E3%81%84%E3%81%86%20%
//E3%81%88%E3%81%8A&scope=RECEIVE_FUNDS,MANAGE_ACCOUNT_INFO,DEFINE_PREFERENCES
```

Veja [aqui](https://dev.wirecard.com.br/reference#section-como-funciona-a-permiss%C3%A3o) como funciona a permissão.

#### Gerar Access Token
```F#
let client_id = "APP-M11STAPPOAU"
let client_secret = "SplxlOBeZQQYbYS6WxSbIA"
let redirect_uri = "http://localhost/moip/callback"
let grant_type = "authorization_code"
let code = "4d9e0466bc14aad85b894237145b217219e9a825"
let result = 
    async { 
        return! WC.ClassicAccount.GenerateAccessToken(client_id, client_secret, redirect_uri, grant_type, code) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Atualizar accessToken
```F#
let grant_type = "refresh_token"
let refresh_token = "2381dfbbcbd645268af1dd0e4456bfe1_v2"
let result = 
    async { 
        return! WC.ClassicAccount.UpdateAccessToken(grant_type, refresh_token) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Obter chave pública de uma Conta Wirecard
```F#
let result = 
    async { 
        return! WC.ClassicAccount.GetPublickey() |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

## Conta Transparente
#### Criar Conta Wirecard Transparente
```F#
let body =
    TransparentAccountRequest(
        TransparentAccount = true,
        Type = "MERCHANT",
        Email = Email(
            Address = "teste@hotmail.com"),
        Person = Person(
            Name = "",
            LastName = "",
            TaxDocument = Taxdocument(
                Type = "CPF",
                Number = "123.456.798-91"),
            BirthDate = "2011-01-01",
            Phone = Phone(
                CountryCode = "55",
                AreaCode = "11",
                Number = "965213244"),
            Address = Address(
                Street = "Av. Brigadeiro Faria Lima",
                StreetNumber = "2927",
                District = "Itaim",
                ZipCode = "01234000",
                City = "Osasco",
                State = "SP",
                Country = "BRA")))
let result = 
    async { 
        return! WC.TransparentAccount.Create(body) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

## Clientes
#### Criar Cliente - (E-COMMERCE)
```F#
let body =
    CustomerRequest(
        OwnId = "meu_id_customer_002",
        FullName = "Maria Oliveira",
        Email = "maria@email.com",
        BirthDate = "1980-5-10",
        TaxDocument = Taxdocument(
            Type = "CPF",
            Number = "22288866644"),
        Phone = Phone(    
            CountryCode = "55",
            AreaCode = "11",
            Number = "55552266"),
        ShippingAddress = Shippingaddress(    
            City = "São Paulo",
            Complement = "10",
            District = "Itaim Bibi",
            Street = "Avenida Faria Lima",
            StreetNumber = "500",
            ZipCode = "01234000",
            State = "SP",
            Country = "BRA"),
        FundingInstrument = Fundinginstrument(
            Method = "CREDIT_CARD",
            CreditCard = Creditcard(
                ExpirationMonth = "06",
                ExpirationYear = "22",
                Number = "6362970000457013",
                Cvc = "123",
                Holder = Holder(
                    FullName = "Maria Oliveira",
                    BirthDate = "1988-12-30",
                    TaxDocument = Taxdocument(
                        Type = "CPF",
                        Number = "33333333333"),
                    BillingAddress = Billingaddress(
                        City = "Rio de Janeiro",
                        District = "Copacabana",
                        Street = "Rua Raimundo Corrêa",
                        StreetNumber = "1200",
                        ZipCode = "05246200",
                        State = "SP",
                        Country = "BRA"),
                    Phone = Phone(
                        CountryCode = "55",
                        AreaCode = "11",
                        Number = "66778899")))))
let result = 
    async { 
        return! WC.Customer.Create(body) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Criar Cliente - (MARKETPLACE / PLATAFORMA)
```F#
let body =
    CustomerRequest(
        OwnId = "meu_id_customer",
        FullName = "Maria Oliveira",
        Email = "maria@email.com",
        BirthDate = "1980-5-10",
        TaxDocument = Taxdocument(
            Type = "CPF",
            Number = "22288866644"),
        Phone = Phone(    
            CountryCode = "55",
            AreaCode = "11",
            Number = "55552266"),
        ShippingAddress = Shippingaddress(    
            City = "São Paulo",
            Complement = "10",
            District = "Itaim Bibi",
            Street = "Avenida Faria Lima",
            StreetNumber = "500",
            ZipCode = "01234000",
            State = "SP",
            Country = "BRA"))
let result = 
    async { 
        return! WC.Customer.Create(body) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Adicionar Cartão de Crédito
```F#
let body =
    CustomerRequest(
        Method = "CREDIT_CARD",
        CreditCard = Creditcard(
            ExpirationMonth = "06",
            ExpirationYear = "2022",
            Number = "4012001037141112",
            Cvc = "123",
            Holder = Holder(
                FullName = "João da Silva",
                BirthDate = "1961-03-01",
                TaxDocument = Taxdocument(
                    Type = "CPF",
                    Number = "11111111111"),
                Phone = Phone(
                    CountryCode = "55",
                    AreaCode = "11",
                    Number = "111111111"))))
let result = 
    async { 
        return! WC.Customer.AddCreditCard(body, "CUS-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Deletar Cartão de Crédito
```F#
let result = 
    async { 
        return! WC.Customer.DeleteCreditCard("CRC-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Consultar Cliente
```F#
let result = 
    async { 
        return! WC.Customer.Consult("CUS-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Listar Todos os Clientes
```F#
let result = 
    async { 
        return! WC.Customer.List() |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

## Pedidos
#### Criar Pedido
```F#
let items = ResizeArray<Item>()
items.Add(Item(
            Product = "Descrição do pedido", 
            Category = "VIDEO_GAME_SOFTWARE", 
            Quantity = 1, 
            Detail = "Mais info...", 
            Price = 2200
let receivers = ResizeArray<Receiver>()
receivers.Add(Receiver(
                Type = "SECONDARY", 
                FeePayor = false, 
                MoipAccount = Moipaccount(
                    Id = "MPA-E3C8493A06AE"),
                Amount = Amount(
                    Fixed = 5000
let body = 
    OrderRequest(
        OwnId = "id_pedido",
        Amount = Amount(
            Currency = "BRL",
            Subtotals = Subtotals(
                Shipping = 1000)),
        Items = items,
        Customer = Customer(
            Id = "CUS-7AKU0VORZ2D4"),
        Receivers = receivers)
let result = 
    async { 
        return! WC.Order.Create(body) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Consultar Pedido
```F#
let result = 
    async { 
        return! WC.Order.Consult("ORD-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Listar Todos os Pedidos - Sem Filtros
```F#
let result = 
    async { 
        return! WC.Order.List() |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Listar Todos os Pedidos - Com Filtros
```F#
let filtros = "q=josesilva&filters=status::in(PAID,WAITING)|paymentMethod::in(CREDIT_CARD,BOLETO)|value::bt(5000,10000)&limit=3&offset=0"
let result = 
    async { 
        return! WC.Order.ListFilter(filtros) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
 Veja a tabela filtros de busca [aqui](#tabela---filtros-de-busca).
 
 ## Pagamentos
 #### Criar Pagamento - Cartão de Crédito
 ```F#
let body = 
    PaymentRequest(
        InstallmentCount = 1,
        FundingInstrument = Fundinginstrument(
            Method = "CREDIT_CARD",
            CreditCard = Creditcard(
                Id = "CRC-XXXXXXXXXXXX",
                Cvc = "123",
                Holder = Holder(
                    FullName = "Jose Portador da Silva",
                    BirthDate = "1988-12-30",
                    TaxDocument = Taxdocument(
                        Type = "CPF",
                        Number = "33333333333")))))
let result = 
    async { 
        return! WC.Payment.Create(body, "ORD-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Criar Pagamento - Boleto

```F#
let body = 
    PaymentRequest(
        StatementDescriptor = "Minha Loja",
        FundingInstrument = Fundinginstrument(
            Method = "BOLETO",
            Boleto = Boleto(
                ExpirationDate = "2020-06-20", //yyyy-MM-dd
                InstructionLines = Instructionlines(
                    First = "Atenção",
                    Second = "fique atento à data de vencimento do boleto.",
                    Third = "Pague em qualquer casa lotérica."))))
let result = 
    async { 
        return! WC.Payment.Create(body, "ORD-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Criar Pagamento - Débito Online

```F#
let body = 
    PaymentRequest(
        FundingInstrument = Fundinginstrument(
            Method = "ONLINE_BANK_DEBIT",
            OnlineBankDebit = Onlinebankdebit(
                BankNumber = "341",
                ExpirationDate = "2017-10-22")))
let result = 
    async { 
        return! WC.Payment.Create(body, "ORD-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Liberação de Custódia
```F#
let result = 
    async { 
        return! WC.Payment.ReleaseCustody("ECW-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Capturar Pagamento Pré-autorizado
```F#
let result = 
    async { 
        return! WC.Payment.CaptureAuthorized("PAY-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Cancelar Pagamento Pré-autorizado
```F#
let result = 
    async { 
        return! WC.Payment.CancelAuthorized("PAY-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Consultar Pagamento
```F#
let result = 
    async { 
        return! WC.Payment.Consult("PAY-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Simular Pagamentos (sandbox)
```F#
let result = 
    async { 
        return! WC.Payment.Simulate("PAY-XXXXXXXXXXXX", 26500) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

## Multipedidos
#### Criar Multipedido
```VB.NET
Dim body = New MultiOrderRequest With {
    .OwnId = "meu_multiorder_id",
    .Orders = New List(Of Order) From {
        New Order With {
            .OwnId = "pedido_1_id",
            .Amount = New Amount With {
                .Currency = "BRL",
                .Subtotals = New Subtotals With {
                    .Shipping = 2000
                }
            },
            .Items = New List(Of Item) From {
                New Item With {
                    .Product = "Camisa Verde e Amarelo - Brasil",
                    .Quantity = 1,
                    .Detail = "Seleção Brasileira",
                    .Price = 2000
                }
            },
            .Customer = New Customer With {
                .OwnId = "customer[1234]",
                .FullName = "Joao Souza",
                .Email = "joao.sousa@email.com",
                .BirthDate = "1988-12-30",
                .TaxDocument = New Taxdocument With {
                    .Type = "CPF",
                    .Number = "22222222222"
                },
                .Phone = New Phone With {
                    .CountryCode = "55",
                    .AreaCode = "11",
                    .Number = "66778899"
                },
                .ShippingAddress = New Shippingaddress With {
                    .City = "São Paulo",
                    .Complement = "10",
                    .District = "Itaim Bibi",
                    .Street = "Avenida Faria Lima",
                    .StreetNumber = "500",
                    .ZipCode = "01234000",
                    .State = "SP",
                    .Country = "BRA"
                }
            },
            .Receivers = New List(Of Receiver) From {
                New Receiver With {
                    .MoipAccount = New Moipaccount With {
                        .Id = "MPA-VB5OGTVPCI52"
                    },
                    .Type = "PRIMARY"
                }
            }
        },
        New Order With {
            .OwnId = "pedido_2_id",
            .Amount = New Amount With {
                .Currency = "BRL",
                .Subtotals = New Subtotals With {
                    .Shipping = 2000
                }
            },
            .Items = New List(Of Item) From {
                New Item With {
                    .Product = "Camisa Preta e Vermelha - Alemanha",
                    .Quantity = 1,
                    .Detail = "Camiseta da Copa 2014",
                    .Price = 2000
                }
            },
            .Customer = New Customer With {
                .OwnId = "customer[1234]",
                .FullName = "Joao Souza",
                .Email = "joao.sousa@email.com",
                .BirthDate = "1988-12-30",
                .TaxDocument = New Taxdocument With {
                    .Type = "CPF",
                    .Number = "22222222222"
                },
                .Phone = New Phone With {
                    .CountryCode = "55",
                    .AreaCode = "11",
                    .Number = "66778899"
                },
                .ShippingAddress = New Shippingaddress With {
                    .City = "São Paulo",
                    .Complement = "10",
                    .District = "Itaim Bibi",
                    .Street = "Avenida Faria Lima",
                    .StreetNumber = "500",
                    .ZipCode = "01234000",
                    .State = "SP",
                    .Country = "BRA"
                }
            },
            .Receivers = New List(Of Receiver) From {
                New Receiver With {
                    .MoipAccount = New Moipaccount With {
                        .Id = "MPA-KQB1QFWS6QNM"
                    },
                    .Type = "SECONDARY",
                    .FeePayor = False,
                    .Amount = New Amount With {
                        .Fixed = 55
                    }
                }
            }
        }
    }
}
Dim result = Await WC.MultiOrder.Create(body)
```

#### Consultar Multipedido
```VB.NET
Dim result = Await WC.MultiOrder.Consult("MOR-XXXXXXXXXXXX")
```

## Multipagamentos
#### Criar Multipagamento
```VB.NET
Dim body = New MultiPaymentRequest With {
    .InstallmentCount = 1,
    .FundingInstrument = New Fundinginstrument With {
        .Method = "CREDIT_CARD",
        .CreditCard = New Creditcard With {
            .Hash = "HhL0...pIkjl2+3Q==",
            .Holder = New Holder With {
                .FullName = "",
                .BirthDate = "1988-12-30",
                .TaxDocument = New Taxdocument With {
                    .Type = "CPF",
                    .Number = "33333333333"
                },
                .Phone = New Phone With {
                    .CountryCode = "55",
                    .AreaCode = "11",
                    .Number = "66778899"
                }
            }
        }
    }
}
Dim result = Await WC.MultiPayment.Create(body, "MOR-XXXXXXXXXXXX")
```
#### Consultar Multipagamento
```VB.NET
Dim result = Await WC.MultiPayment.Consult("MPY-XXXXXXXXXXXX")
```
#### Capturar Multipagamento Pré-autorizado
```VB.NET
Dim result = Await WC.MultiPayment.CaptureAuthorized("MPY-XXXXXXXXXXXX")
```
#### Cancelar Multipagamento Pré-autorizado
```VB.NET
Dim result = Await WC.MultiPayment.CancelAuthorized("MPY-XXXXXXXXXXXX")
```
#### Liberação de Custódia
```VB.NET
Dim result = Await WC.MultiPayment.ReleaseCustody("ECW-XXXXXXXXXXXX")
```
## Notificações
#### Criar Preferência de Notificação para Conta Wirecard
```VB.NET
Dim body = New NotificationRequest With {
    .Events = New List(Of String) From {
        "ORDER.*",
        "PAYMENT.AUTHORIZED",
        "PAYMENT.CANCELLED"
    },
    .Target = "https://webhook.site/a54daf-da54-8d5a-8d5d1-kfa4gahf42",
    .Media = "WEBHOOK"
}
Dim result = Await WC.Notification.CreatAccountWirecard(body)
```

#### Criar Preferência de Notificação para App
Caso não tenha uma URL disponível, você pode usar o **Webhook Tester** para fazer seus testes e receber os webhooks. 

Para isso basta acessar o [site](https://webhook.site) e gera uma URL automaticamente.

```VB.NET
Dim body = New NotificationRequest With {
    .Events = New List(Of String) From {
        "ORDER.*"
    },
    .Target = "https://webhook.site/a54daf-da54-8d5a-8d5d1-kfa4gahf42",
    .Media = "WEBHOOK"
}
Dim result = Await WC.Notification.CreateApp(body)
```
#### Criar Preferência de Notificação para App com código identificador
```VB.NET
Dim body = New NotificationRequest With {
    .Events = New List(Of String) From {
        "ORDER.*"
    },
    .Target = "https://webhook.site/a54daf-da54-8d5a-8d5d1-kfa4gahf42",
    .Media = "WEBHOOK"
}
Dim result = Await WC.Notification.CreateApp(body, "APP-3984HG73HE9")
```
#### Consultar Preferência de Notificação
```VB.NET
Dim result = Await WC.Notification.Consult("NPR-XXXXXXXXXXXX")
```
#### Listar Todas as Preferências de Notificação
```VB.NET
Dim result = Await WC.Notification.List()
```
#### Remover Preferência de Notificação
```VB.NET
Dim result = Await WC.Notification.Remove("NPR-XXXXXXXXXXXX")
If result = HttpStatusCode.NoContent Then
'Caso a Preferência de Notificação tenha sido deletada, você deve receber uma response vazia (NoContent)
End If
```
#### Consultar Webhook Enviado
```VB.NET
Dim result = Await WC.Notification.ConsultWebhook("PAY-XXXXXXXXXXXX")
```
#### Listar Todos os Webhooks Enviados
```VB.NET
Dim result = Await WC.Notification.ListWebhooks()
```
#### Desserializar WebHook
Ao configurar suas Preferências de Notificação você deve receber os webhooks em formato JSON e você pode desserializar.

```VB.NET
Dim json = "{ ""date"": """", ""env"": """", ... }"
Dim result = Utilities.DeserializeWebHook(json)
```
Veja um exemplo do webhook [aqui](https://gist.githubusercontent.com/matmiranda/61b8fac6159d0a61c1cd52deb0941fd8/raw/c08a41818abd135d56c7608587f353bc0bd99df7/Exemplo%2520WebHook.json).

Para aumentar a segurança da sua aplicação e garantir que apenas a Wirecard pode enviar notificações para o seu sistema, você pode conferir o token enviado no header dos webhooks. Este token é o mesmo que é gerado no momento do cadastro da sua URL:
```VB.NET
Dim token = Request.Headers("Authorization")
```

## Contas Bancárias
#### Criar Conta Bancária
```VB.NET
Dim body = New BankAccountRequest With {
    .bankNumber = "237",
    .agencyNumber = "12345",
    .agencyCheckNumber = "0",
    .accountNumber = "12345678",
    .accountCheckNumber = "7",
    .type = "CHECKING",
    .holder = New Holder With {
        .taxDocument = New Taxdocument With {
            .type = "CPF",
            .number = "622.134.533-22"
        },
        .fullname = "Demo Wirecard"
    }
}
Dim accesstoken As String = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"
Dim result = Await WC.BankAccount.Create(body, accesstoken, "MPA-XXXXXXXXXXXX")
```
#### Consultar Conta Bancária
```VB.NET
Dim accesstoken As String = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"
Dim result = Await WC.BankAccount.Consult(accesstoken, "BKA-XXXXXXXXXXXX")
```
#### Listar Todas Contas Bancárias
```VB.NET
Dim accesstoken As String = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"
Dim result = Await WC.BankAccount.List(accesstoken, "MPA-XXXXXXXXXXXX")
```
#### Deletar Conta Bancária
```VB.NET
Dim accesstoken As String = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"
Dim result = Await WC.BankAccount.Delete(accesstoken, "BKA-XXXXXXXXXXXX")
```
#### Atualizar Conta Bancária
```VB.NET
Dim body = New BankAccountRequest With {
    .BankNumber = "237",
    .AgencyNumber = "12345",
    .AgencyCheckNumber = "8",
    .AccountNumber = "12345678",
    .AccountCheckNumber = "8",
    .Type = "CHECKING",
    .Holder = New Holder With {
        .TaxDocument = New Taxdocument With {
            .Type = "CPF",
            .Number = "622.134.533-22"
        },
        .FullName = "Nome Completo"
    }
}
Dim accesstoken As String = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"
Dim result = Await WC.BankAccount.Update(body, accesstoken, "BKA-XXXXXXXXXXXX")
```
## Saldo Wirecard
#### Consultar Saldos
```VB.NET
Dim result = Await WC.Balance.Consult()
```
## Lançamentos
#### Consultar Lançamento
```VB.NET
Dim result = Await WC.Launch.Consult("ENT-XXXXXXXXXXXX")
```
#### Listar Todos Lançamentos
```VB.NET
Dim result = Await WC.Launch.List()
```
#### Listar Todos Lançamentos com Filtro
```VB.NET
Dim filtros As String = "filters=status::in(SETTLED)"
Dim result = Await WC.Launch.ListFilter(filtros)
```
## Transferências
#### Criar Transferência
```VB.NET
Dim body = New TransferRequest With {
    .Amount = 500,
    .TransferInstrument = New Transferinstrument With {
        .Method = "",
        .BankAccount = New Bankaccount With {
            .Type = "CHECKING",
            .BankNumber = "001",
            .AgencyNumber = "1111",
            .AgencyCheckNumber = "2",
            .AccountNumber = "9999",
            .AccountCheckNumber = "8",
            .Holder = New Holder With {
                .FullName = "Nome do Portador",
                .TaxDocument = New Taxdocument With {
                    .Type = "CPF",
                    .Number = "22222222222"
                }
            }
        }
    }
}
Dim accessToken As String = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx_v2"
Dim result = Await WC.Transfer.Create(body, accessToken)
```
#### Reverter Transferência
```VB.NET
Dim accessToken As String = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx_v2"
Dim result = Await WC.Transfer.Revert("TRA-XXXXXXXXXXXX", accessToken)
```
#### Consultar Transferência
```VB.NET
Dim accessToken As String = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx_v2"
Dim result = Await WC.Transfer.Consult("TRA-XXXXXXXXXXXX", accessToken)
```
#### Listar Todas Transferências
```VB.NET
Dim result = Await WC.Transfer.List()
```
#### Listar Todas Transferências com filtros
```VB.NET
Dim filtros As String = "filters=transferInstrument.method::in(MOIP_ACCOUNT)&limit=3&offset=0"
Dim result = Await WC.Transfer.List()
```
## Reembolsos
#### Reembolsar Pagamento
```VB.NET
Dim body = New RefundRequest With {
    .Amount = "2000"
}
Dim result = Await WC.Refund.RefundPayment(body, "PAY-XXXXXXXXXXXX")
```
#### Reembolsar Pedido via Cartão de Crédito
```VB.NET
Dim body = New RefundRequest With {
    .Amount = "2000"
}
Dim result = Await WC.Refund.RefundRequestCreditCard(body, "ORD-XXXXXXXXXXXX")
```
#### Consultar Reembolso
```VB.NET
Dim result = Await WC.Refund.Consult("REF-XXXXXXXXXXXX")
```
#### Listar Reembolsos do Pagamento
```VB.NET
Dim result = Await WC.Refund.ListPayments("PAY-XXXXXXXXXXXX")
```
#### Listar Reembolsos do Pedido
```VB.NET
Dim result = Await WC.Refund.ListOrders("ORD-XXXXXXXXXXXX")
```
## Conciliação
#### Obter Arquivo de Vendas
```VB.NET
Dim result = Await WC.Conciliation.GetSalesFile("20180829")
'Data no formato YYYYMMDD
```
#### Obter Arquivo Financeiro
```VB.NET
Dim result = Await WC.Conciliation.GetFinancialFile("2018-08-29")
'Data no formato YYYY-MM-DD
```
## Assinatura
#### Criar Plano
```VB.NET
Dim body = New PlanRequest With {
    .Code = "plan103",
    .Name = "Plano Especial",
    .Description = "Descrição do Plano Especial",
    .Amount = 990,
    .Setup_Fee = 500,
    .Max_Qty = 1,
    .Interval = New Interval With {
        .Length = 1,
        .Unit = "MONTH"
    },
    .Billing_Cycles = 12,
    .Trial = New Trial With {
        .Days = 30,
        .Enabled = True,
        .Hold_Setup_Fee = True
    }
}
Dim result = Await WC.Signature.CreatePlan(body)
```
#### Listar Planos
```VB.NET
Dim result = Await WC.Signature.ListPlans()
```
#### Consultar Plano
```VB.NET
Dim result = Await WC.Signature.ConsultPlan("plan101")
```
#### Ativar Plano
```VB.NET
Dim result = Await WC.Signature.EnablePlan("plan101")
```
#### Desativar Plano
```VB.NET
Dim result = Await WC.Signature.DisablePlan("plan101")
```
#### Alterar Plano
```VB.NET
Dim body = New PlanRequest With {
    .Name = "Plano Especial",
    .Description = "",
    .Amount = 1290,
    .Setup_Fee = 800,
    .Max_Qty = 1,
    .Payment_Method = "CREDIT_CARD",
    .Interval = New Interval With {
        .Length = 1,
        .Unit = "MONTH"
    },
    .Billing_Cycles = 12,
    .Trial = New Trial With {
        .Days = 30,
        .Enabled = True,
        .Hold_Setup_Fee = True
    }
}
Dim result = Await WC.Signature.ChangePlan(body, "plan101")
```
#### Criar Assinante
```VB.NET
Dim body = New SubscriberRequest With {
    .Code = "cliente03",
    .Email = "nome@exemplo.com.br",
    .FullName = "Nome Sobrenome",
    .Cpf = "22222222222",
    .Phone_Area_Code = "11",
    .Phone_Number = "934343434",
    .BirthDate_Day = "26",
    .BirthDate_Month = "04",
    .BirthDate_Year = "1980",
    .Address = New Address With {
        .Street = "Rua Nome da Rua",
        .StreetNumber = "100",
        .Complement = "casa",
        .District = "Nome do Bairro",
        .City = "São Paulo",
        .State = "SP",
        .Country = "BRA",
        .ZipCode = "05015010"
    },
    .Billing_Info = New Billing_Info With {
        .Credit_Card = New Credit_Card With {
            .Holder_Name = "Nome Completo",
            .Number = "4111111111111111",
            .Expiration_Month = "06",
            .Expiration_Year = "22"
        }
    }
}
Dim result = Await WC.Signature.CreateSubscriber(body, True)
```
#### Listar Assinantes
```VB.NET
Dim result = Await WC.Signature.ListSubscribers()
```
#### Consultar Assinante
```VB.NET
Dim result = Await WC.Signature.ConsultSubscriber("cliente01")
```
#### Alterar Assinante
```VB.NET
Dim body = New SubscriberRequest With {
    .Code = "cliente01",
    .Email = "nome@exemplo.com.br",
    .FullName = "Nome Sobrenome",
    .Cpf = "22222222222",
    .Phone_Area_Code = "11",
    .Phone_Number = "934343434",
    .BirthDate_Day = "26",
    .BirthDate_Month = "04",
    .BirthDate_Year = "1980",
    .Address = New Address With {
        .Street = "Rua Nome da Rua1",
        .StreetNumber = "100",
        .Complement = "casa",
        .District = "Nome do Bairro",
        .City = "São Paulo",
        .State = "SP",
        .Country = "BRA",
        .ZipCode = "05015010"
    }
}
Dim result = Await WC.Signature.ChangeSubscriber(body, "cliente01")
```
#### Atualizar Cartão do Assinante
```VB.NET
Dim body = New SubscriberRequest With {
    .Billing_Info = New Billing_Info With {
        .Credit_Card = New Credit_Card With {
            .Holder_Name = "Novo nome222",
            .Number = "5555666677778884",
            .Expiration_Month = "12",
            .Expiration_Year = "20"
        }
    }
}
Dim result = Await WC.Signature.UpdateSubscriberCard(body, "cliente01")
```
#### Criar Assinaturas
```VB.NET
Dim body = New SubscriptionRequest With {
    .Code = "assinatura04",
    .Amount = "9000",
    .Plan = New Plan With {
        .Code = "plan101"
    },
    .Payment_Method = "CREDIT_CARD",
    .Customer = New Customer With {
        .Code = "cliente01"
    }
}
Dim result = Await WC.Signature.CreateSubscriptions(body, False)
```
#### Listar Todas Assinaturas
```VB.NET
Dim result = Await WC.Signature.ListAllSubscriptions()
```
#### Consultar Assinatura -Sem Filtro
```VB.NET
Dim result = Await WC.Signature.ConsultSubscriptionFilter("assinatura01")
```
#### Consultar Assinatura - Com Filtro
```VB.NET
Dim filter = "q=assinatura01&filters=status::eq(ACTIVE)"
Dim result = Await WC.Signature.ConsultSubscription(filter)
```
Alguns exemplos de como filtrar:

1. Pesquisar e Filtrar assinaturas (``` q=teste&filters=status::eq(EXPIRED) ```)
2. Filtrar assinaturas por status (``` filters=status::eq(EXPIRED)&limit=10&offset=0 ```)
3. Filtrar assinaturas por creation_date (``` filters=creation_date::bt(2014-11-08,2015-05-07)&limit=100&offset=0 ```)
4. Filtrar assinaturas por next_invoice_date (``` filters=next_invoice_date::bt(2015-10-12,2015-10-12)&limit=100&offset=0 ```)
5. Filtrar assinaturas por plano (``` filters=plan.code::eq(TESTE_WIRECARD)&limit=100&offset=0 ```)
6. Filtrar assinaturas por customer.code (``` filters=customer.code::eq(HHDGOo)&limit=100&offset=0 ```)
7. Filtrar assinaturas por customer.email (``` filters=customer.email::eq(joao.silva@email.com.br)&limit=100&offset=0 ```)
8. Filtrar assinaturas por customer.cpf (``` filters=customer.cpf::eq(22222222222)&limit=100&offset=0 ```)
9. Filtrar assinaturas por valor (``` filters=amount::bt(100,100000) ```)
10. Pesquisar Assinatura (``` q=diego nunes&limit=10&offset=0 ```)
#### Suspender Assinatura
```VB.NET
Dim result = Await WC.Signature.SuspendSubscription("assinatura01")
```
#### Reativar Assinatura
```VB.NET
Dim result = Await WC.Signature.ReactivateSignature("assinatura01")
```
#### Cancelar Assinatura
```VB.NET
Dim result = Await WC.Signature.CancelSignature("assinatura01")
```
#### Alterar Assinatura
```VB.NET
Dim body = New SubscriptionRequest With {
    .Plan = New Plan With {
        .Code = "plan101"
    },
    .Amount = "9990",
    .Next_Invoice_Date = New Next_Invoice_Date With {
        .Day = 15,
        .Month = 12,
        .Year = 2018
    }
}
Dim result = Await WC.Signature.ChangeSubscription(body, "assinatura01")
```
#### Alterar método de pagamento
```VB.NET
Dim body = New SubscriptionRequest With {
    .Payment_Method = "BOLETO"
}
Dim result = Await WC.Signature.ChangePaymentMethod(body, "assinatura01")
```
#### Listar Todas as Faturas de Uma Assinatura
```VB.NET
Dim result = Await WC.Signature.ListSignatureInvoices("assinatura01")
```
#### Consultar Fatura
```VB.NET
Dim result = Await WC.Signature.ConsultInvoice("10865746")
```
#### Listar todos os pagamentos de fatura
```VB.NET
Dim result = Await WC.Signature.ListAllInvoicePayments("10865746")
```
#### Consultar pagamento de assinatura
```VB.NET
Dim result = Await WC.Signature.ConsultSubscriptionPayment("PAY-123456789012")
```
#### Criar Cupom
```VB.NET
Dim body = New CouponRequest With {
    .Code = "coupon-0002",
    .Name = "Coupon name",
    .Description = "My new coupon",
    .Discount = New Discount With {
        .Value = 1000,
        .Type = "percent"
    },
    .Status = "active",
    .Duration = New Duration With {
        .Type = "repeating",
        .Occurrences = 12
    },
    .Max_Redemptions = 100,
    .Expiration_Date = New Expiration_Date With {
        .Year = 2020,
        .Month = 08,
        .Day = 01
    }
}
Dim result = Await WC.Signature.CreateCoupon(body)
```
#### Associar Cupom para Assinatura
```VB.NET
Dim body = New CouponRequest With {
    .Coupon = New Coupon With {
        .Code = "coupon-0001"
    }
}
Dim result = Await WC.Signature.AssociateCouponForExistingSignature(body, "assinatura01")
```
#### Associar Cupom para Nova Assinatura
```VB.NET
Dim body = New CouponRequest()
Dim result = Await WC.Signature.AssociateCouponForExistingSignature(body, "true")
```
#### Consultar Cupom
```VB.NET
Dim result = Await WC.Signature.ConsultCoupon("coupon-0001")
```
#### Listar Todos os Cupons
```VB.NET
Dim result = Await WC.Signature.ListAllCoupons()
```
#### Ativar e Inativar Cupons
```VB.NET
Dim result = Await WC.Signature.EnableOrDisableCoupon("coupon-0001", "inactive")
```
#### Excluir Cupom de uma Assinatura
```VB.NET
Dim result = Await WC.Signature.DeleteSignatureCoupon("assinatura01")
```
#### Retentativa de pagamento de uma fatura
```VB.NET
Dim result = Await WC.Signature.RetentiveInvoicePayment("1548222")
```
#### Gerar um novo boleto para uma fatura
```VB.NET
Dim body = New RetentativeRequest With {
    .Year = 2020,
    .Month = 08,
    .Day = 01
}
Dim result = Await WC.Signature.CreateNewInvoiceBoleto(body, "1548222")
```
#### Criar Regras de Retentativas Automáticas
```VB.NET
Dim body = New RetentativeRequest With {
    .First_Try = 1,
    .Second_Try = 3,
    .Third_Try = 5,
    .[Finally] = "cancel"
}
Dim result = Await WC.Signature.CreateAutomaticRetentionRules(body)
```

#### Criar Preferência de Notificação
```VB.NET
Dim body = New NotificationRequest With {
    .Notification = New Notification With {
        .Webhook = New Webhook With {
            .Url = "http://exemploldeurl.com.br/assinaturas"
        },
        .Email = New Email With {
            .Merchant = New Merchant With {
                .Enabled = True
            },
            .Customer = New Customer With {
                .Enabled = True
            }
        }
    }
}
Dim result = Await WC.Signature.CreateNotificationPreference(body)
```

## Convertendo objeto para json

As vezes você enfrenta um problema e o suporte Wirecard pede o código json para verificar se realmente está no json:

```VB.NET
Imports Newtonsoft.Json;

Dim body = New PaymentRequest With {
    .DelayCapture = True,
    .InstallmentCount = 1,
    .FundingInstrument = New Fundinginstrument With {
        .Method = "CREDIT_CARD",
        .CreditCard = New Creditcard With {
            .Id = "CRC-XXXXXXXXXXXX",
            .Cvc = "123",
            .Holder = New Holder With {
                .FullName = "Jose Portador da Silva",
                .BirthDate = "1988-12-30",
                .TaxDocument = New Taxdocument With {
                    .Type = "CPF",
                    .Number = "33333333333"
                }
            }
        }
    }
}

'Aqui você pode obter json e compratilhar para suporte Wirecard
Dim json As String = JsonConvert.SerializeObject(body, Formatting.Indented)
```

Veja como ficou na variável json:

```json
{
  "installmentCount": 1,
  "delayCapture": true,
  "fundingInstrument": {
    "method": "CREDIT_CARD",
    "creditCard": {
      "id": "CRC-XXXXXXXXXXXX",
      "cvc": "123",
      "holder": {
        "fullname": "Jose Portador da Silva",
        "birthdate": "1988-12-30",
        "taxDocument": {
          "type": "CPF",
          "number": "33333333333"
        }
      }
    }
  }
}
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
```VB.NET
Imports Wirecard.Exception

Try
    Dim result = Await WC.Customer.Create(New CustomerRequest())
Catch ex As WirecardException
    Dim t = ex.wirecardError
    Dim t_text = ex.GetExceptionText()
End Try
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
