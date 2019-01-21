*Ler em outras linguagens de programação: [C#](README.md), [Visual Basic](README.VisualBasic.md).*

## Índice - F#
- [Implementações .NET com suporte](#implementações-net-com-suporte)
- [Aviso Importante](#aviso-importante)
- [Instalação](#instalação)
- [Autenticando e configurando o ambiente (E-Commerce)](#autenticando-e-configurando-o-ambiente-e-commerce)
- [Autenticando e configurando o ambiente (Marketplace)](#autenticando-e-configurando-o-ambiente-marketplace)
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

```F#
open System.Net
ServicePointManager.SecurityProtocol <- SecurityProtocolType.Tls12
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
            Price = 2200))
let receivers = ResizeArray<Receiver>()
receivers.Add(Receiver(
                Type = "SECONDARY", 
                FeePayor = false, 
                MoipAccount = Moipaccount(
                    Id = "MPA-E3C8493A06AE"),
                Amount = Amount(
                    Fixed = 5000)))
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
```F#
let body =
    MultiOrderRequest(
        OwnId = "meu_multiorder_id",
        Orders = ResizeArray<Order>([
            Order(
                OwnId = "pedido_1_id",
                Amount = Amount(
                    Currency = "BRL",
                    Subtotals = Subtotals(
                        Shipping = 2000)),
                Items = ResizeArray<Item>([
                    Item(
                        Product = "Camisa Verde e Amarelo - Brasil",
                        Quantity = 1,
                        Detail = "Seleção Brasileira",
                        Price = 2000
                    )]),
                Customer = Customer(
                    OwnId = "customer[1234]",
                    FullName = "Joao Souza",
                    Email = "joao.sousa@email.com",
                    BirthDate = "1988-12-30",
                    TaxDocument = Taxdocument(
                        Type = "CPF",
                        Number = "22222222222"),
                    Phone = Phone(
                        CountryCode = "55",
                        AreaCode = "11",
                        Number = "66778899"),
                    ShippingAddress = Shippingaddress(
                        City = "São Paulo",
                        Complement = "10",
                        District = "Itaim Bibi",
                        Street = "Avenida Faria Lima",
                        StreetNumber = "500",
                        ZipCode = "01234000",
                        State = "SP",
                        Country = "BRA")),
                Receivers = ResizeArray<Receiver>([
                    Receiver(
                        MoipAccount = new Moipaccount(
                            Id = "MPA-VB5OGTVPCI52"),
                            Type = "PRIMARY")]));
            Order(
                OwnId = "pedido_2_id",
                Amount = Amount(
                    Currency = "BRL",
                    Subtotals = Subtotals(
                        Shipping = 2000)),
                Items = ResizeArray<Item>([
                    Item(
                        Product = "Camisa Preta e Vermelha - Alemanha",
                        Quantity = 1,
                        Detail = "Camiseta da Copa 2014",
                        Price = 2000
                    )]),
                Customer = Customer(
                    OwnId = "customer[1234]",
                    FullName = "Joao Souza",
                    Email = "joao.sousa@email.com",
                    BirthDate = "1988-12-30",
                    TaxDocument = Taxdocument(
                        Type = "CPF",
                        Number = "22222222222"),
                    Phone = Phone(
                        CountryCode = "55",
                        AreaCode = "11",
                        Number = "66778899"),
                    ShippingAddress = Shippingaddress(
                        City = "São Paulo",
                        Complement = "10",
                        District = "Itaim Bibi",
                        Street = "Avenida Faria Lima",
                        StreetNumber = "500",
                        ZipCode = "01234000",
                        State = "SP",
                        Country = "BRA")),
                Receivers = ResizeArray<Receiver>([
                    Receiver(
                        MoipAccount = new Moipaccount(
                            Id = "MPA-VB5OGTVPCI52"),
                            Type = "SECONDARY",
                            FeePayor = false,
                            Amount = Amount(
                                Fixed = 55))]))]))
let result = 
    async { 
        return! WC.MultiOrder.Create(body) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Consultar Multipedido
```F#
let result = 
    async { 
        return! WC.MultiOrder.Consult("MOR-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

## Multipagamentos
#### Criar Multipagamento
```F#
let body = 
    MultiPaymentRequest(
        InstallmentCount = 1,
        FundingInstrument = Fundinginstrument(
            Method = "CREDIT_CARD",
                CreditCard = Creditcard(
                    Hash = "HhL0...pIkjl2+3Q==",
                    Holder = Holder(
                        FullName = "",
                        BirthDate = "1988-12-30",
                        TaxDocument = new Taxdocument(
                            Type = "CPF",
                            Number = "33333333333"),
                        Phone = new Phone(
                            CountryCode  = "55",
                            AreaCode = "11",
                            Number = "66778899")))))
let result = 
    async { 
        return! WC.MultiPayment.Create(body, "MOR-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Consultar Multipagamento
```F#
let result = 
    async { 
        return! WC.MultiPayment.Consult("MPY-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Capturar Multipagamento Pré-autorizado
```F#
let result = 
    async { 
        return! WC.MultiPayment.CaptureAuthorized("MPY-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Cancelar Multipagamento Pré-autorizado
```F#
let result = 
    async { 
        return! WC.MultiPayment.CancelAuthorized("MPY-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Liberação de Custódia
```F#
let result = 
    async { 
        return! WC.MultiPayment.ReleaseCustody |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
## Notificações
#### Criar Preferência de Notificação para Conta Wirecard
```F#
let body = 
    NotificationRequest(
        Events = ResizeArray<string>(["ORDER.*"; "PAYMENT.AUTHORIZED"; "PAYMENT.CANCELLED"]),
        Target = "https://webhook.site/a54daf-da54-8d5a-8d5d1-kfa4gahf42",
        Media = "WEBHOOK")
let result = 
    async { 
        return! WC.Notification.CreatAccountWirecard(body) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Criar Preferência de Notificação para App
Caso não tenha uma URL disponível, você pode usar o **Webhook Tester** para fazer seus testes e receber os webhooks. 

Para isso basta acessar o [site](https://webhook.site) e gera uma URL automaticamente.

```F#
let body = 
    NotificationRequest(
        Events = ResizeArray<string>(["ORDER.*"]),
        Target = "https://webhook.site/a54daf-da54-8d5a-8d5d1-kfa4gahf42",
        Media = "WEBHOOK")
let result = 
    async { 
        return! WC.Notification.CreateApp(body) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Criar Preferência de Notificação para App com código identificador
```F#
let body = 
    NotificationRequest(
        Events = ResizeArray<string>(["ORDER.*"]),
        Target = "https://webhook.site/a54daf-da54-8d5a-8d5d1-kfa4gahf42",
        Media = "WEBHOOK")
let result = 
    async { 
        return! WC.Notification.CreateApp(body, "APP-3984HG73HE9") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Consultar Preferência de Notificação
```F#
let result = 
    async { 
        return! WC.Notification.Consult("NPR-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Listar Todas as Preferências de Notificação
```F#
let result = 
    async { 
        return! WC.Notification.List() |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Remover Preferência de Notificação
```F#
let result = 
    async { 
        return! WC.Notification.Remove("NPR-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
if  result = HttpStatusCode.NoContent
    then printfn "Caso a Preferência de Notificação tenha sido deletada, você deve receber uma response vazia (NoContent)"
```
#### Consultar Webhook Enviado
```F#
let result = 
    async { 
        return! WC.Notification.ConsultWebhook("PAY-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Listar Todos os Webhooks Enviados
```F#
let result = 
    async { 
        return! WC.Notification.ListWebhooks() |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Desserializar WebHook
Ao configurar suas Preferências de Notificação você deve receber os webhooks em formato JSON e você pode desserializar.

```F#
let json = "{ \"date\": \"\", \"env\": \"\" }";
let result = Utilities.DeserializeWebHook(json)
```
Veja um exemplo do webhook [aqui](https://gist.githubusercontent.com/matmiranda/61b8fac6159d0a61c1cd52deb0941fd8/raw/c08a41818abd135d56c7608587f353bc0bd99df7/Exemplo%2520WebHook.json).

Para aumentar a segurança da sua aplicação e garantir que apenas a Wirecard pode enviar notificações para o seu sistema, você pode conferir o token enviado no header dos webhooks. Este token é o mesmo que é gerado no momento do cadastro da sua URL:
```F#
let token = Request.Headers["Authorization"]
```

## Contas Bancárias
#### Criar Conta Bancária
```F#
let body =
    BankAccountRequest(
        BankNumber = "237",
        AgencyNumber = "12345",
        AgencyCheckNumber = "0",
        AccountNumber = "12345678",
        AccountCheckNumber = "7",
        Type = "CHECKING",
        Holder = Holder(
            TaxDocument = new Taxdocument(
                Type = "CPF",
                Number = "622.134.533-22"),
                FullName = "Demo Wirecard"))
let accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"
let result = 
    async { 
        return! WC.BankAccount.Create(body, accesstoken, "MPA-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Consultar Conta Bancária
```F#
let accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"
let result = 
    async { 
        return! WC.BankAccount.Consult(accesstoken, "BKA-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Listar Todas Contas Bancárias
```F#
let accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"
let result = 
    async { 
        return! WC.BankAccount.List(accesstoken, "MPA-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Deletar Conta Bancária
```F#
let accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"
let result = 
    async { 
        return! WC.BankAccount.Delete(accesstoken, "BKA-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Atualizar Conta Bancária
```F#
let body =
    BankAccountRequest(
        BankNumber = "237",
        AgencyNumber = "12345",
        AgencyCheckNumber = "8",
        AccountNumber = "12345678",
        AccountCheckNumber = "8",
        Type = "CHECKING",
        Holder = new Holder(
            TaxDocument = new Taxdocument(
                Type = "CPF",
                Number = "622.134.533-22"),
                FullName = "Nome Completo"))
let accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"
let result = 
    async { 
        return! WC.BankAccount.Update(body, accesstoken, "MPA-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
## Saldo Wirecard
#### Consultar Saldos
```F#
let result = 
    async { 
        return! WC.Balance.Consult() |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
## Lançamentos
#### Consultar Lançamento
```F#
let result = 
    async { 
        return! WC.Launch.Consult("ENT-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Listar Todos Lançamentos
```F#
let result = 
    async { 
        return! WC.Launch.List() |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Listar Todos Lançamentos com Filtro
```F#
let filtros = "filters=status::in(SETTLED)"
let result = 
    async { 
        return! WC.Launch.ListFilter(filtros) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
## Transferências
#### Criar Transferência
```F#
let body = 
    TransferRequest(
        Amount = 500,
        TransferInstrument = Transferinstrument(
            Method = "",
                BankAccount = Bankaccount(
                    Type = "CHECKING",
                    BankNumber = "001",
                    AgencyNumber = "1111",
                    AgencyCheckNumber = "2",
                    AccountNumber = "9999",
                    AccountCheckNumber = "8",
                    Holder = Holder(
                        FullName = "Nome do Portador",
                        TaxDocument = Taxdocument(
                            Type = "CPF",
                            Number = "22222222222")))))
let accessToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx_v2"
let result = 
    async { 
        return! WC.Transfer.Create(body, accessToken) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Reverter Transferência
```F#
let accessToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx_v2"
let result = 
    async { 
        return! WC.Transfer.Revert("TRA-XXXXXXXXXXXX", accessToken) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Consultar Transferência
```F#
let accessToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx_v2"
let result = 
    async { 
        return! WC.Transfer.Consult("TRA-XXXXXXXXXXXX", accessToken) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Listar Todas Transferências
```F#
let result = 
    async { 
        return! WC.Transfer.List() |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Listar Todas Transferências com filtros
```F#
let filtros = "filters=transferInstrument.method::in(MOIP_ACCOUNT)&limit=3&offset=0"
let result = 
    async { 
        return! WC.Transfer.ListFilter(filtros) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
## Reembolsos
#### Reembolsar Pagamento
```F#
let body =
    RefundRequest(
        //caso queira fazer um reembolso parcial é necessário informar o atributo amount na requisição
        Amount = "2000")
let result = 
    async { 
        return! WC.Refund.RefundPayment(body, "PAY-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Reembolsar Pedido via Cartão de Crédito
```F#
let body =
    RefundRequest(
        Amount = "2000")
let result = 
    async { 
        return! WC.Refund.RefundRequestCreditCard(body, "ORD-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Consultar Reembolso
```F#
let result = 
    async { 
        return! WC.Refund.Consult("REF-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Listar Reembolsos do Pagamento
```F#
let result = 
    async { 
        return! WC.Refund.ListPayments("PAY-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Listar Reembolsos do Pedido
```F#
let result = 
    async { 
        return! WC.Refund.ListOrders("ORD-XXXXXXXXXXXX") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
## Conciliação
#### Obter Arquivo de Vendas
```F#
let result = 
    async { 
        return! WC.Conciliation.GetSalesFile("20180829") |> Async.AwaitTask 
    } |> Async.RunSynchronously
//Data no formato YYYYMMDD
```
#### Obter Arquivo Financeiro
```F#
let result = 
    async { 
        return! WC.Conciliation.GetFinancialFile("2018-08-29") |> Async.AwaitTask 
    } |> Async.RunSynchronously
//Data no formato YYYY-MM-DD
```
## Assinatura
#### Criar Plano
```F#
let body = 
    PlanRequest(
        Code = "plan103",
        Name = "Plano Especial",
        Description = "Descrição do Plano Especial",
        Amount = 990,
        Setup_Fee = 500,
        Max_Qty = 1,
        Interval = Interval(
            Length = 1,
            Unit = "MONTH"),
        Billing_Cycles = 12,
        Trial = Trial(
            Days = 30,
            Enabled = true,
            Hold_Setup_Fee = true))
let result = 
    async { 
        return! WC.Signature.CreatePlan(body) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Listar Planos
```F#
let result = 
    async { 
        return! WC.Signature.ListPlans() |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Consultar Plano
```F#
let result = 
    async { 
        return! WC.Signature.ConsultPlan("plan101") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Ativar Plano
```F#
let result = 
    async { 
        return! WC.Signature.EnablePlan("plan101") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Desativar Plano
```F#
let result = 
    async { 
        return! WC.Signature.DisablePlan("plan101") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Alterar Plano
```F#
let body = 
    PlanRequest(
        Name = "Plano Especial",
        Description = "",
        Amount = 1290,
        Setup_Fee = 800,
        Max_Qty = 1,
        Payment_Method = "CREDIT_CARD",
        Interval = Interval(
            Length = 1,
            Unit = "MONTH"),
        Billing_Cycles = 12,
        Trial = Trial(
            Days = 30,
            Enabled = true,
            Hold_Setup_Fee = true))
let result = 
    async { 
        return! WC.Signature.ChangePlan(body, "plan101") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Criar Assinante
```F#
let body = 
    SubscriberRequest(
        Code = "cliente03",
        Email = "nome@exemplo.com.br",
        FullName = "Nome Sobrenome",
        Cpf = "22222222222",
        Phone_Area_Code = "11",
        Phone_Number = "934343434",
        BirthDate_Day = "26",
        BirthDate_Month = "04",
        BirthDate_Year = "1980",
        Address = Address(
            Street = "Rua Nome da Rua",
            StreetNumber = "100",
            Complement = "casa",
            District = "Nome do Bairro",
            City = "São Paulo",
            State = "SP",
            Country = "BRA",
            ZipCode = "05015010"),
        Billing_Info = Billing_Info(
            Credit_Card = Credit_Card(
                Holder_Name = "Nome Completo",
                Number = "4111111111111111",
                Expiration_Month = "06",
                Expiration_Year = "22")))
let result = 
    async { 
        return! WC.Signature.CreateSubscriber(body, true) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Listar Assinantes
```F#
let result = 
    async { 
        return! WC.Signature.ListSubscribers() |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Consultar Assinante
```F#
let result = 
    async { 
        return! WC.Signature.ConsultSubscriber("cliente01") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Alterar Assinante
```F#
let body = 
    SubscriberRequest(
        Code = "cliente01",
        Email = "nome@exemplo.com.br",
        FullName = "Nome Sobrenome",
        Cpf = "22222222222",
        Phone_Area_Code = "11",
        Phone_Number = "934343434",
        BirthDate_Day = "26",
        BirthDate_Month = "04",
        BirthDate_Year = "1980",
        Address = Address(
            Street = "Rua Nome da Rua1",
            StreetNumber = "100",
            Complement = "casa",
            District = "Nome do Bairro",
            City = "São Paulo",
            State = "SP",
            Country = "BRA",
            ZipCode = "05015010"))
let result = 
    async { 
        return! WC.Signature.ChangeSubscriber(body, "cliente01") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Atualizar Cartão do Assinante
```F#
let body = 
    SubscriberRequest(
        Billing_Info = Billing_Info(
            Credit_Card = Credit_Card(
                Holder_Name = "Novo nome222",
                Number = "5555666677778884",
                Expiration_Month = "12",
                Expiration_Year = "20")))
let result = 
    async { 
        return! WC.Signature.UpdateSubscriberCard(body, "cliente01") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Criar Assinaturas
```F#
let body = 
    SubscriptionRequest(
        Code = "assinatura04",
        Amount = "9000",
        Plan = Plan(
            Code = "plan101"),
        Payment_Method = "CREDIT_CARD",
        Customer = Customer(
            Code = "cliente01"))
let result = 
    async { 
        return! WC.Signature.CreateSubscriptions(body, false) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Listar Todas Assinaturas
```F#
let result = 
    async { 
        return! WC.Signature.ListAllSubscriptions() |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Consultar Assinatura -Sem Filtro
```F#
let result = 
    async { 
        return! WC.Signature.ConsultSubscriptionFilter("assinatura01") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Consultar Assinatura - Com Filtro
```F#
let filter = "q=assinatura01&filters=status::eq(ACTIVE)"
let result = 
    async { 
        return! WC.Signature.ConsultSubscription(filter) |> Async.AwaitTask 
    } |> Async.RunSynchronously
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
```F#
let result = 
    async { 
        return! WC.Signature.SuspendSubscription("assinatura01") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Reativar Assinatura
```F#
let result = 
    async { 
        return! WC.Signature.ReactivateSignature("assinatura01") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Cancelar Assinatura
```F#
let result = 
    async { 
        return! WC.Signature.CancelSignature("assinatura01") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Alterar Assinatura
```F#
let body =
    SubscriptionRequest(
        Plan = Plan(
            Code = "plan101"),
        Amount = "9990",
        Next_Invoice_Date = Next_Invoice_Date(
            Day = 15,
            Month = 12,
            Year = 2018))
let result = 
    async { 
        return! WC.Signature.ChangeSubscription(body, "assinatura01") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Alterar método de pagamento
```F#
let body =
    SubscriptionRequest(
        Payment_Method = "BOLETO")
let result = 
    async { 
        return! WC.Signature.ChangePaymentMethod(body, "assinatura01") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Listar Todas as Faturas de Uma Assinatura
```F#
let result = 
    async { 
        return! WC.Signature.ListSignatureInvoices("assinatura01") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Consultar Fatura
```F#
let result = 
    async { 
        return! WC.Signature.ConsultInvoice("10865746") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Listar todos os pagamentos de fatura
```F#
let result = 
    async { 
        return! WC.Signature.ListAllInvoicePayments("10865746") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Consultar pagamento de assinatura
```F#
let result = 
    async { 
        return! WC.Signature.ConsultSubscriptionPayment("PAY-123456789012") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Criar Cupom
```F#
let body = 
    CouponRequest(
        Code = "coupon-0002",
        Name = "Coupon name",
        Description = "My new coupon",
        Discount = Discount(
            Value = 1000,
            Type = "percent"),
        Status = "active",
        Duration = Duration(
            Type = "repeating",
            Occurrences = 12),
        Max_Redemptions = 100,
        Expiration_Date = Expiration_Date(
            Year = 2020,
            Month = 08,
            Day = 01))
let result = 
    async { 
        return! WC.Signature.CreateCoupon(body) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Associar Cupom para Assinatura
```F#
let body = 
    CouponRequest(
        Coupon = Coupon(
            Code = "coupon-0001"))
let result = 
    async { 
        return! WC.Signature.AssociateCouponForExistingSignature(body, "assinatura01") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Associar Cupom para Nova Assinatura
```F#
let body = CouponRequest()
let result = 
    async { 
        return! WC.Signature.AssociateCouponForExistingSignature(body, "true") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Consultar Cupom
```F#
let result = 
    async { 
        return! WC.Signature.ConsultCoupon("coupon-0001") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Listar Todos os Cupons
```F#
let result = 
    async { 
        return! WC.Signature.ListAllCoupons() |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Ativar e Inativar Cupons
```F#
let result = 
    async { 
        return! WC.Signature.EnableOrDisableCoupon("coupon-0001", "inactive") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Excluir Cupom de uma Assinatura
```F#
let result = 
    async { 
        return! WC.Signature.DeleteSignatureCoupon("assinatura01") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Retentativa de pagamento de uma fatura
```F#
let result = 
    async { 
        return! WC.Signature.RetentiveInvoicePayment("1548222") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Gerar um novo boleto para uma fatura
```F#
let body = 
    RetentativeRequest(
        Year = 2020,
        Month = 08,
        Day = 01)
let result = 
    async { 
        return! WC.Signature.CreateNewInvoiceBoleto(body,"1548222") |> Async.AwaitTask 
    } |> Async.RunSynchronously
```
#### Criar Regras de Retentativas Automáticas
```F#
let body = 
    RetentativeRequest(
        First_Try = 1,
        Second_Try = 3,
        Third_Try = 5,
        Finally = "cancel")
let result = 
    async { 
        return! WC.Signature.CreateAutomaticRetentionRules(body) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

#### Criar Preferência de Notificação
```F#
let body = 
    NotificationRequest(
        Notification = Notification(
            Webhook = Webhook(
                Url = "http://exemploldeurl.com.br/assinaturas"),
            Email = Email(
                Merchant = Merchant(
                    Enabled = true),
                Customer = Customer(
                    Enabled = true))))
let result = 
    async { 
        return! WC.Signature.CreateNotificationPreference(body) |> Async.AwaitTask 
    } |> Async.RunSynchronously
```

## Convertendo objeto para json

As vezes você enfrenta um problema e o suporte Wirecard pede o código json para verificar se realmente está no json:

```F#
open Newtonsoft.Json

let body = 
    PaymentRequest(
        DelayCapture = true,
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
 //Aqui você pode obter json e compratilhar para suporte Wirecard
let json = JsonConvert.SerializeObject(body, Formatting.Indented);
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
```F#
open Wirecard.Exception

try
    let result = 
        async { 
            return! WC.Customer.Create(new CustomerRequest()) |> Async.AwaitTask 
        } |> Async.RunSynchronously
    ()
with
    | :? WirecardException as ex -> 
        let t = ex.wirecardError
        let t_text = ex.GetExceptionText()
        ()
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
