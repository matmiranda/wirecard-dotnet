<p align="center">
  <a href="https://dev.wirecard.com.br/v2.0/">
    <img src="https://raw.githubusercontent.com/matmiranda/Wirecard-NET/master/Images/Wirecard%20%2B%20.NET.jpg" alt="Wirecard logo" width=400>
  </a>
</p>
<p align="center">
    O jeito mais simples e rápido de integrar o Wirecard a sua aplicação .NET e feito com base nas APIs REST do Wirecard.
  <br>
  <br>
    <a href="https://dev.wirecard.com.br/v2.0/docs">
        <img src="https://img.shields.io/badge/Docs-Wirecard-orange.svg"
            alt="Docs"></a>
    <a href="https://dev.wirecard.com.br/v2.0/reference">
        <img src="https://img.shields.io/badge/API%20Reference-Wirecard-darkblue.svg"
            alt="API Reference"></a>
    <a href="https://slackin-cqtchmfquq.now.sh/">
        <img src="https://img.shields.io/badge/Slack-Wirecard%20Devs-black.svg"
            alt="Slack"/></a>
    <a href="https://github.com/matmiranda/Wirecard/blob/master/LICENSE">
        <img src="https://img.shields.io/badge/License-MIT-brightgreen.svg"
            alt="MIT"></a>
    <a href="https://www.nuget.org/packages/Wirecard">
        <img src="https://img.shields.io/badge/Nuget-v3.1.7-blue.svg"
            alt="NuGet"></a>
      <a href="https://www.nuget.org/stats/packages/Wirecard?groupby=Version">
        <img src="https://img.shields.io/badge/Statistics-155.svg"
            alt="Statistics"></a>
      <a href="https://github.com/matmiranda/Wirecard-NET/blob/master/NugetTotalDownloads.md">
            <img src="https://img.shields.io/badge/Downloads-27k-red.svg"
            alt="Downloads"></a>
</p>

*Ler em outras linguagens de programação: [Visual Basic](README.VisualBasic.md), [F#](README.FSharp.md).*

| Biblioteca                                                     | Descrição                      | Status            |
| --------------------------------------------------------------- | -------------------------------| ----------------- |
| [MoipCSharp](https://www.nuget.org/packages/MoipCSharp/)        | Onde tudo começou...           | ❌ Descontinuado |
| [WirecardCSharp](https://www.nuget.org/packages/WirecardCSharp/)| Quando a Moip virou Wirecard...| ❌ Descontinuado |
| [Wirecard](https://www.nuget.org/packages/Wirecard/)            | Projeto atual                  | ✔️ Atual         |

## Índice - C#
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
  - [Reenviar Webhook](#reenviar-webhook)
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
- [Extratos](#extratos)
  - [Listar Extrato](#listar-extrato)
  - [Detalhes do Extrato](#detalhes-do-extrato)
  - [Listar Extrato Futuro](#listar-extrato-futuro)
  - [Detalhes do Extrato Futuro](#detalhes-do-extrato-futuro)
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
- [Alterando accesstoken](#alterando-accesstoken)
- [Tabela](#tabela)
  - [Tipos de Lançamentos](#tipos-de-lançamentos)
  - [Filtros de busca](#filtros-de-busca)
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

```C#
using Wirecard;
using Wirecard.Models;

private const string token = "xxxxxxxxxxxxxxxxxxx";
private const string key = "xxxxxxxxxxxxxxxxxxxxxxxxxx";
private WirecardClient WC = new WirecardClient(Environments.SANDBOX, token, key);
```
Para obter um token e a chave, primeiro faça o login [aqui](https://connect-sandbox.wirecard.com.br/login).

Você pode acessá-las em **Minha conta** > **Configurações** > **Chaves de Acesso**.

## Autenticando e configurando o ambiente (Marketplace)
Escolha o "ambiente" você quer executar suas ações e informe seu accesstoken: 
```C#
using Wirecard;
using Wirecard.Models;

private const string accessToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx_v2";
private WirecardClient WC = new WirecardClient(Environments.SANDBOX, accessToken);
```

Para obter o accesstoken, você precisa criar um [App](https://dev.wirecard.com.br/reference#1-criar-um-app).

## Assíncrona x Síncrona
Todos os métodos são **assíncronos**, caso você queira executar de forma **síncrona**, veja o exemplo:

```C#
var result = Task.Run(() => WC.Customer.List()).Result;
```

## Conta Clássica
#### Verificar se usuário já possui Conta Wirecard (email)
🚩 Essa função funciona somente na conta clássica.
```C#
var result = await WC.ClassicAccount.AccountExist("meu_email@email.com");
if (result == HttpStatusCode.OK)
{
    // já existe
    //HttpStatusCode.OK == 200 (já existe)
    //HttpStatusCode.BadRequest == 400 (CPF inválido)
    //HttpStatusCode.NotFound == 404 (Para CPF válido, mas não possui Conta Wirecard)
}
```

#### Verificar se usuário já possui Conta Wirecard (documento)
🚩 Essa função funciona somente na conta clássica.
```C#
var result = await WC.ClassicAccount.AccountExist("123.456.789-01");
if (result == HttpStatusCode.OK)
{
    // já existe
    //HttpStatusCode.OK == 200 (já existe)
    //HttpStatusCode.BadRequest == 400 (CPF inválido)
    //HttpStatusCode.NotFound == 404 (Para CPF válido, mas não possui Conta Wirecard)
}
```

#### Criar Conta Wirecard Clássica (Conta PF)
```C#
var body = new ClassicAccountRequest
{
    Email = new Email
    {
        Address = "fulano@hotmail.com"
    },
    Person = new Person
    {
        Name = "Fulano",
        LastName = "da Silva",
        TaxDocument = new Taxdocument
        {
            Type = "CPF",
            Number = "123.456.789-91"
        },
        IdentityDocument = new Identitydocument
        {
            Type = "RG",
            Number = "434322344",
            Issuer = "SPP",
            IssueDate = "2000-12-12"
        },
        BirthDate = "1990-01-01",
        Phone = new Phone
        {
            CountryCode = "55",
            AreaCode = "11",
            Number = "965213244"
        },
        Address = new Address
        {
            Street = "Av. Brigadeiro Faria Lima",
            StreetNumber = "2927",
            District = "Itaim",
            ZipCode = "01234-000",
            City = "São Paulo",
            State = "SP",
            Country = "BRA"
        }
    },
    Type = "MERCHANT"
};
var result = await WC.ClassicAccount.Create(body);
```
#### Criar Conta Wirecard Clássica (Conta PJ)
```C#
var body = new ClassicAccountRequest
{
    Email = new Email
    {
        Address = "fulano@hotmail.com"
    },
    Person = new Person
    {
        Name = "Fulano",
        LastName = "da Silva",
        BirthDate = "1990-01-01",
        TaxDocument = new Taxdocument
        {
            Type = "CPF",
            Number = "123.456.789-91"
        },
        IdentityDocument = new Identitydocument
        {
            Type = "RG",
            Number = "434322344",
            Issuer = "SPP",
            IssueDate = "2000-12-12"
        },
        Phone = new Phone
        {
            CountryCode = "55",
            AreaCode = "11",
            Number = "965213244"
        },
        Address = new Address
        {
            Street = "Av. Brigadeiro Faria Lima",
            StreetNumber = "2927",
            District = "Itaim",
            ZipCode = "01234-000",
            City = "São Paulo",
            State = "SP",
            Country = "BR"
        }
    },
    Company = new Company
    {
        Name = "Noma da empresa",
        BusinessName = "Wirecard Pagamentos",
        OpeningDate = "2011-01-01",
        TaxDocument = new Taxdocument
        {
            Type = "CNPJ",
            Number = "11.698.147/0001-13"
        },
        MainActivity = new Mainactivity
        {
            Cnae = "82.91-1/00",
            Description = "Atividades de cobranças e informações cadastrais"
        },
        Phone = new Phone
        {
            CountryCode = "55",
            AreaCode = "11",
            Number = "32234455"
        },
        Address = new Address
        {
            Street = "Av. Brigadeiro Faria Lima",
            StreetNumber = "2927",
            District = "Itaim",
            ZipCode = "01234-000",
            City = "São Paulo",
            State = "SP",
            Country = "BRA"
        }
    },
    BusinessSegment = new Businesssegment
    {
        Id = 3
    },
    Type = "MERCHANT"
};
var result = await WC.ClassicAccount.Create(body);
```

#### Consultar Conta Wirecard
```C#
var result = await WC.ClassicAccount.Consult("MPA-XXXXXXXXXXXX");
```

#### Solicitar Permissões de Acesso ao Usuário

🚩 O código a seguir não consome API, apenas monta o URL. Mais informações clica [aqui](https://dev.wirecard.com.br/reference#section-como-funciona-a-permiss%C3%A3o).

```C#
string response_type = "code";
string client_id = "APP-FFFGVQMOK123";
string redirect_uri = "https://example.com/abc?DEF=あいう\x20えお";
string scope = "RECEIVE_FUNDS,MANAGE_ACCOUNT_INFO,DEFINE_PREFERENCES";
var url = Utilities.RequestUserAccessPermissions(response_type, client_id, redirect_uri, scope);

//https://connect-sandbox.moip.com.br/oauth/authorize?response_type=code&client_id=APP-
//FFFGVQMOK123&redirect_uri=https://example.com/abc?DEF=%E3%81%82%E3%81%84%E3%81%86%20%
//E3%81%88%E3%81%8A&scope=RECEIVE_FUNDS,MANAGE_ACCOUNT_INFO,DEFINE_PREFERENCES
```

Veja [aqui](https://dev.wirecard.com.br/reference#section-como-funciona-a-permiss%C3%A3o) como funciona a permissão.

#### Gerar Access Token
```C#
string client_id = "APP-M11STAPPOAU";
string client_secret = "SplxlOBeZQQYbYS6WxSbIA";
string redirect_uri = "http://localhost/moip/callback";
string grant_type = "authorization_code";
string code = "4d9e0466bc14aad85b894237145b217219e9a825";
var result = await WC.ClassicAccount.GenerateAccessToken(
                client_id, client_secret, redirect_uri, grant_type, code);
```

#### Atualizar accessToken
```C#
string grant_type = "refresh_token";
string refresh_token = "2381dfbbcbd645268af1dd0e4456bfe1_v2";
var result = await WC.ClassicAccount.UpdateAccessToken(grant_type, refresh_token);
```

#### Obter chave pública de uma Conta Wirecard
```C#
var result = await WC.ClassicAccount.GetPublickey();
```

## Conta Transparente
#### Criar Conta Wirecard Transparente
```C#
var body = new TransparentAccountRequest
{
    TransparentAccount = true,
    Type = "MERCHANT",
    Email = new Email
    {
        Address = "teste@hotmail.com"
    },
    Person = new Person
    {
        Name = "PrimeiroNome",
        LastName = "SegundoNome",
        TaxDocument = new Taxdocument
        {
            Type = "CPF",
            Number = "123.456.798-91"
        },
        BirthDate = "2011-01-01",
        Phone = new Phone
        {
            CountryCode = "55",
            AreaCode = "11",
            Number = "965213244"
        },
        Address = new Address
        {
            Street = "Av. Brigadeiro Faria Lima",
            StreetNumber = "2927",
            District = "Itaim",
            ZipCode = "01234000",
            City = "Osasco",
            State = "SP",
            Country = "BRA"
        }
    }
};
var result = await WC.TransparentAccount.Create(body);
```

## Clientes
#### Criar Cliente - (E-COMMERCE)
```C#
var body = new CustomerRequest
{
    OwnId = "meu_id_customer_002",
    FullName = "Maria Oliveira",
    Email = "maria@email.com",
    BirthDate = "1980-5-10",
    TaxDocument = new Taxdocument
    {
        Type = "CPF",
        Number = "22288866644"
    },
    Phone = new Phone
    {
        CountryCode = "55",
        AreaCode = "11",
        Number = "55552266"
    },
    ShippingAddress = new Shippingaddress
    {
        City = "São Paulo",
        Complement = "10",
        District = "Itaim Bibi",
        Street = "Avenida Faria Lima",
        StreetNumber = "500",
        ZipCode = "01234000",
        State = "SP",
        Country = "BRA"
    },
    FundingInstrument = new Fundinginstrument
    {
        Method = "CREDIT_CARD",
        CreditCard = new Creditcard
        {
            ExpirationMonth = "06",
            ExpirationYear = "22",
            Number = "6362970000457013",
            Cvc = "123",
            Holder = new Holder
            {
                FullName = "Maria Oliveira",
                BirthDate = "1988-12-30",
                TaxDocument = new Taxdocument
                {
                    Type = "CPF",
                    Number = "33333333333"
                },
                BillingAddress = new Billingaddress
                {
                    City = "Rio de Janeiro",
                    District = "Copacabana",
                    Street = "Rua Raimundo Corrêa",
                    StreetNumber = "1200",
                    ZipCode = "05246200",
                    State = "SP",
                    Country = "BRA"
                },
                Phone = new Phone
                {
                    CountryCode = "55",
                    AreaCode = "11",
                    Number = "66778899"
                }
            }
        }
    }
};
var result = await WC.Customer.Create(body);
```
#### Criar Cliente - (MARKETPLACE / PLATAFORMA)
```C#
 var body = new CustomerRequest
 {
     OwnId = "meu_id_customer",
     FullName = "João Silva",
     Email = "joao@email.com",
     BirthDate = "1990-10-22",
     TaxDocument = new Taxdocument
     {
         Type = "CPF",
         Number = "22288866644"
     },
     Phone = new Phone
     {
         CountryCode = "55",
         AreaCode = "11",
         Number = "55552266"
     },
     ShippingAddress = new Shippingaddress
     {
         City = "São Paulo",
         Complement = "10",
         District = "Itaim Bibi",
         Street = "Avenida Faria Lima",
         StreetNumber = "500",
         ZipCode = "01234000",
         State = "SP",
         Country = "BRA"
     }
 };
var result = await WC.Customer.Create(body);
```

#### Adicionar Cartão de Crédito
```C#
var body = new CustomerRequest
{
    Method = "CREDIT_CARD",
    CreditCard = new Creditcard
    {
        ExpirationMonth = "06",
        ExpirationYear = "2022",
        Number = "4012001037141112",
        Cvc = "123",
        Holder = new Holder
        {
            FullName = "João da Silva",
            BirthDate = "1961-03-01",
            TaxDocument = new Taxdocument
            {
                Type = "CPF",
                Number = "11111111111"
            },
            Phone = new Phone
            {
                CountryCode = "55",
                AreaCode = "11",
                Number = "111111111"
            }
        }
    }
};
var result = await WC.Customer.AddCreditCard(body, "CUS-XXXXXXXXXXXX");
```

#### Deletar Cartão de Crédito
```C#
var result = await WC.Customer.DeleteCreditCard("CRC-XXXXXXXXXXXX");
```

#### Consultar Cliente
```C#
var result = await WC.Customer.Consult("CUS-XXXXXXXXXXXX");
```

#### Listar Todos os Clientes
```C#
var result = await WC.Customer.List();
```

## Pedidos
#### Criar Pedido
```C#
var body = new OrderRequest
{
    OwnId = "id_pedido",
    Amount = new Amount
    {
        Currency = "BRL",
        Subtotals = new Subtotals
        {
            Shipping = 1000
        }
    },
    Items = new List<Item>
    {
        new Item
        {
            Product = "Descrição do pedido",
            Category = "VIDEO_GAME_SOFTWARE",
            Quantity = 1,
            Detail = "Mais info...",
            Price = 22000
        }
    },
    Customer = new Customer
    {
        Id = "CUS-7AKU0VORZ2D4"
    },
    Receivers = new List<Receiver>
    {
        new Receiver
        {
            Type = "SECONDARY",
            FeePayor = false,
            MoipAccount = new Moipaccount
            {
                Id = "MPA-E3C8493A06AE"
            },
            Amount = new Amount
            {
                Fixed = 5000
            }
        }
    }
};
var result = await WC.Order.Create(body);
```

#### Consultar Pedido
```C#
var result = await WC.Order.Consult("ORD-XXXXXXXXXXXX");
```

#### Listar Todos os Pedidos - Sem Filtros
```C#
var result = await WC.Order.List();
```

#### Listar Todos os Pedidos - Com Filtros
```C#
string filtros = "q=josesilva&filters=status::in(PAID,WAITING)|paymentMethod::in(CREDIT_CARD,BOLETO)|value::bt(5000,10000)&limit=3&offset=0";
var result = await WC.Order.ListFilter(filtros);
```
 Veja a tabela filtros de busca [aqui](#filtros-de-busca).
 
 ## Pagamentos
 #### Criar Pagamento - Cartão de Crédito
 ```C#
var body = new PaymentRequest
{
    //informe os campos aqui
    InstallmentCount = 1,
    FundingInstrument = new Fundinginstrument
    {
        Method = "CREDIT_CARD",
        CreditCard = new Creditcard
        {
            Id = "CRC-XXXXXXXXXXXX",
            Cvc = "123",
            Holder = new Holder
            {
                FullName = "Jose Portador da Silva",
                BirthDate = "1988-12-30",
                TaxDocument = new Taxdocument
                {
                    Type = "CPF",
                    Number = "33333333333"
                }
            }
        }
    }
};          
var result = await WC.Payment.Create(body, "ORD-XXXXXXXXXXXX");
```

#### Criar Pagamento - Boleto

```C#
var body = new PaymentRequest
{
    //informe os campos aqui
    StatementDescriptor = "Minha Loja",
    FundingInstrument = new Fundinginstrument
    {
        Method = "BOLETO",
        Boleto = new Boleto
        {
            ExpirationDate = "2020-06-20", //yyyy-MM-dd
            InstructionLines = new Instructionlines
            {
                First = "Atenção",
                Second = "fique atento à data de vencimento do boleto.",
                Third = "Pague em qualquer casa lotérica."
            }
        }        
    }
};
var result = await WC.Payment.Create(body, "ORD-XXXXXXXXXXXX");
var link = result._Links.Payboleto.PrintHref; // <--- obter o link para impressão
```
#### Criar Pagamento - Débito Online

```C#
var body = new PaymentRequest
{
    FundingInstrument = new Fundinginstrument
    {
        Method = "ONLINE_BANK_DEBIT",
        OnlineBankDebit = new Onlinebankdebit
        {
            BankNumber = "341",
            ExpirationDate = "2017-10-22"
        }
    }
};
var result = await WC.Payment.Create(body, "ORD-XXXXXXXXXXXX");
```

#### Liberação de Custódia
```C#
var result = await WC.Payment.ReleaseCustody("ECW-XXXXXXXXXXXX");
```

#### Capturar Pagamento Pré-autorizado
```C#
var result = await WC.Payment.CaptureAuthorized("PAY-XXXXXXXXXXXX");
```

#### Cancelar Pagamento Pré-autorizado
```C#
var result = await WC.Payment.CancelAuthorized("PAY-XXXXXXXXXXXX");
```

#### Consultar Pagamento
```C#
var result = await WC.Payment.Consult("PAY-XXXXXXXXXXXX");
```

#### Simular Pagamentos (sandbox)
```C#
var result = await WC.Payment.Simulate("PAY-XXXXXXXXXXXX", 26500);
```

## Multipedidos
#### Criar Multipedido
```C#
var body = new MultiOrderRequest
{
    OwnId = "meu_multiorder_id",
    Orders = new List<Order>
    {
        new Order
        {
            OwnId = "pedido_1_id",
            Amount = new Amount
            {
                Currency = "BRL",
                Subtotals = new Subtotals
                {
                    Shipping = 2000
                }
            },
            Items = new List<Item>
            {
                new Item
                {
                    Product = "Camisa Verde e Amarelo - Brasil",
                    Quantity = 1,
                    Detail = "Seleção Brasileira",
                    Price = 2000
                }
            },
            Customer = new Customer
            {
                OwnId = "customer[1234]",
                FullName = "Joao Souza",
                Email = "joao.sousa@email.com",
                BirthDate = "1988-12-30",
                TaxDocument = new Taxdocument
                {
                    Type = "CPF",
                    Number = "22222222222"
                },
                Phone = new Phone
                {
                    CountryCode = "55",
                    AreaCode = "11",
                    Number = "66778899"
                },
                ShippingAddress = new Shippingaddress
                {
                    City = "São Paulo",
                    Complement = "10",
                    District = "Itaim Bibi",
                    Street = "Avenida Faria Lima",
                    StreetNumber = "500",
                    ZipCode = "01234000",
                    State = "SP",
                    Country = "BRA"
                }
            },
            Receivers = new List<Receiver>
            {
                new Receiver
                {
                    MoipAccount = new Moipaccount
                    {
                        Id = "MPA-VB5OGTVPCI52"
                    },
                    Type = "PRIMARY"
                }
            }
        },
        new Order
        {
            OwnId = "pedido_2_id",
            Amount = new Amount
            {
                Currency = "BRL",
                Subtotals = new Subtotals
                {
                    Shipping = 2000
                }
            },
            Items = new List<Item>
            {
                new Item
                {
                    Product = "Camisa Preta e Vermelha - Alemanha",
                    Quantity = 1,
                    Detail = "Camiseta da Copa 2014",
                    Price = 2000
                }
            },
            Customer = new Customer
            {
                OwnId = "customer[1234]",
                FullName = "Joao Souza",
                Email = "joao.sousa@email.com",
                BirthDate = "1988-12-30",
                TaxDocument = new Taxdocument
                {
                    Type = "CPF",
                    Number = "22222222222"
                },
                Phone = new Phone
                {
                    CountryCode = "55",
                    AreaCode = "11",
                    Number = "66778899"
                },
                ShippingAddress = new Shippingaddress
                {
                    City = "São Paulo",
                    Complement = "10",
                    District = "Itaim Bibi",
                    Street = "Avenida Faria Lima",
                    StreetNumber = "500",
                    ZipCode = "01234000",
                    State = "SP",
                    Country = "BRA"
                }
            },
            Receivers = new List<Receiver>
            {
                new Receiver
                {
                    MoipAccount = new Moipaccount
                    {
                        Id = "MPA-KQB1QFWS6QNM"
                    },
                    Type = "SECONDARY",
                    FeePayor = false,
                    Amount = new Amount
                    {
                        Fixed = 55
                    }
                }
            }
        }
    }
};            
var result = await WC.MultiOrder.Create(body);
```

#### Consultar Multipedido
```C#
var result = await WC.MultiOrder.Consult("MOR-XXXXXXXXXXXX");
```

## Multipagamentos
#### Criar Multipagamento
```C#
var body = new MultiPaymentRequest
{
    InstallmentCount = 1,
    FundingInstrument = new Fundinginstrument
    {
        Method = "CREDIT_CARD",
        CreditCard = new Creditcard
        {
            Hash = "HhL0...pIkjl2+3Q==",
            Holder = new Holder
            {
                FullName = "",
                BirthDate = "1988-12-30",
                TaxDocument = new Taxdocument
                {
                    Type = "CPF",
                    Number = "33333333333"
                },
                Phone = new Phone
                {
                    CountryCode  = "55",
                    AreaCode = "11",
                    Number = "66778899"
                }
            }
        }
    }
};            
var result = await WC.MultiPayment.Create(body, "MOR-XXXXXXXXXXXX");
```
#### Consultar Multipagamento
```C#
var result = await WC.MultiPayment.Consult("MPY-XXXXXXXXXXXX");
```
#### Capturar Multipagamento Pré-autorizado
```C#
var result = await WC.MultiPayment.CaptureAuthorized("MPY-XXXXXXXXXXXX");
```
#### Cancelar Multipagamento Pré-autorizado
```C#
var result = await WC.MultiPayment.CancelAuthorized("MPY-XXXXXXXXXXXX");
```
#### Liberação de Custódia
```C#
var result = await WC.MultiPayment.ReleaseCustody("ECW-XXXXXXXXXXXX");
```
## Notificações
#### Criar Preferência de Notificação para Conta Wirecard
```C#
var body = new NotificationRequest
{
    Events = new List<string> { "ORDER.*", "PAYMENT.AUTHORIZED", "PAYMENT.CANCELLED" },
    Target = "https://webhook.site/a54daf-da54-8d5a-8d5d1-kfa4gahf42",
    Media = "WEBHOOK"
};           
var result = await WC.Notification.CreatAccountWirecard(body);
```

#### Criar Preferência de Notificação para App
Caso não tenha uma URL disponível, você pode usar o **Webhook Tester** para fazer seus testes e receber os webhooks. 

Para isso basta acessar o [site](https://webhook.site) e gera uma URL automaticamente.

```C#
var body = new NotificationRequest
{
    Events = new List<string> { "ORDER.*" },
    Target = "https://webhook.site/a54daf-da54-8d5a-8d5d1-kfa4gahf42",
    Media = "WEBHOOK"
};           
var result = await WC.Notification.CreateApp(body);
```
#### Criar Preferência de Notificação para App com código identificador
```C#
var body = new NotificationRequest
{
    Events = new List<string> { "ORDER.*" },
    Target = "https://webhook.site/a54daf-da54-8d5a-8d5d1-kfa4gahf42",
    Media = "WEBHOOK"
};           
var result = await WC.Notification.CreateApp(body, "APP-3984HG73HE9");
```
#### Consultar Preferência de Notificação
```C#
var result = await WC.Notification.Consult("NPR-XXXXXXXXXXXX");
```
#### Listar Todas as Preferências de Notificação
```C#
var result = await WC.Notification.List();
```
#### Remover Preferência de Notificação
```C#
var result = await WC.Notification.Remove("NPR-XXXXXXXXXXXX");
if (result == HttpStatusCode.NoContent)
{
    // Caso a Preferência de Notificação tenha sido deletada, você deve receber uma response vazia (NoContent)
}
```
#### Consultar Webhook Enviado
```C#
var result = await WC.Notification.ConsultWebhook("PAY-XXXXXXXXXXXX"); 
```
#### Listar Todos os Webhooks Enviados
```C#
var result = await WC.Notification.ListWebhooks();
```
#### Reenviar Webhook
```C#
var body = new NotificationRequest
{
    ResourceId = "PAY-XJM2SF6IS7FU",
    Event = "PAYMENT.AUTHORIZED"
};
var result = await WC.Notification.ResendWebhook(body);
```
#### Desserializar WebHook
Ao configurar suas Preferências de Notificação você deve receber os webhooks em formato JSON e você pode desserializar.

```C#
var json = "{ \"date\": \"\", \"env\": \"\", ... }";
var result = Utilities.DeserializeWebHook(json);
```
Veja um exemplo do webhook [aqui](https://gist.githubusercontent.com/matmiranda/61b8fac6159d0a61c1cd52deb0941fd8/raw/c08a41818abd135d56c7608587f353bc0bd99df7/Exemplo%2520WebHook.json).

Para aumentar a segurança da sua aplicação e garantir que apenas a Wirecard pode enviar notificações para o seu sistema, você pode conferir o token enviado no header dos webhooks. Este token é o mesmo que é gerado no momento do cadastro da sua URL:
```C#
var token = Request.Headers["Authorization"];
```

## Contas Bancárias
#### Criar Conta Bancária
```C#
var body = new BankAccountRequest
{
    BankNumber = "237",
    AgencyNumber = "12345",
    AgencyCheckNumber = "0",
    AccountNumber = "12345678",
    AccountCheckNumber = "7",
    Type = "CHECKING",
    Holder = new Holder
    {
        TaxDocument = new Taxdocument
        {
            Type = "CPF",
            Number = "622.134.533-22"
        },
        FullName = "Demo Wirecard"
    }
};
string accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"; // accesstoken do recebedor
var result = await WC.BankAccount.Create(body, accesstoken, "MPA-XXXXXXXXXXXX");
```
#### Consultar Conta Bancária
```C#
string accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"; // accesstoken do recebedor
var result = await WC.BankAccount.Consult(accesstoken, "BKA-XXXXXXXXXXXX");
```
#### Listar Todas Contas Bancárias
```C#
string accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"; // accesstoken do recebedor
var result = await WC.BankAccount.List(accesstoken, "MPA-XXXXXXXXXXXX");
```
#### Deletar Conta Bancária
```C#
string accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"; // accesstoken do recebedor
var result = await WC.BankAccount.Delete(accesstoken, "BKA-XXXXXXXXXXXX");
```
#### Atualizar Conta Bancária
```C#
var body = new BankAccountRequest
{
    BankNumber = "237",
    AgencyNumber = "12345",
    AgencyCheckNumber = "8",
    AccountNumber = "12345678",
    AccountCheckNumber = "8",
    Type = "CHECKING",
    Holder = new Holder
    {
        TaxDocument = new Taxdocument
        {
            Type = "CPF",
            Number = "622.134.533-22"
        },
        FullName = "Nome Completo"
    }
};
string accesstoken = "XXXXXXXXXXXXXXXXXXXXXXXXXXX_v2"; // accesstoken do recebedor
var result = await WC.BankAccount.Update(body, accesstoken, "BKA-XXXXXXXXXXXX");
```
## Saldo Wirecard
#### Consultar Saldos
```C#
var result = await WC.Balance.Consult();
```
## Lançamentos
#### Consultar Lançamento
```C#
var result = await WC.Launch.Consult("ENT-XXXXXXXXXXXX");
```
#### Listar Todos Lançamentos
```C#
var result = await WC.Launch.List();
```
#### Listar Todos Lançamentos com Filtro
```C#
string filtros = "filters=status::in(SETTLED)";
var result = await WC.Launch.ListFilter(filtros);
```
## Extratos
#### Listar Extrato
```C#
var result = await WC.Extract.List("2019-01-15", "2019-01-01");
```
#### Detalhes do Extrato
```C#
var result = await WC.Extract.Detail("1", "2018-10-04");
```
#### Listar Extrato Futuro
```C#
var result = await WC.Extract.ListFuture("2018-01-01", "2018-01-15");
```
#### Detalhes do Extrato Futuro
```C#
var result = await WC.Extract.DetailFuture("1", "2018-12-18");
```
Tipo do extrato, disponível na tabela de [tipos de lançamentos](#tipos-de-lançamentos)
## Transferências
#### Criar Transferência
```C#
var body = new TransferRequest
{
    Amount = 500,
    TransferInstrument = new Transferinstrument
    {
        Method = "",
        BankAccount = new Bankaccount
        {
            Type = "CHECKING",
            BankNumber = "001",
            AgencyNumber = "1111",
            AgencyCheckNumber = "2",
            AccountNumber = "9999",
            AccountCheckNumber = "8",
            Holder = new Holder
            {
                FullName = "Nome do Portador",
                TaxDocument = new Taxdocument
                {
                    Type = "CPF",
                    Number = "22222222222"
                }
            }
        }
    }
};
string accessToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx_v2";
var result = await WC.Transfer.Create(body, accessToken);
```
#### Reverter Transferência
```C#
string accessToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx_v2";
var result = await WC.Transfer.Revert("TRA-XXXXXXXXXXXX", accessToken);
```
#### Consultar Transferência
```C#
string accessToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx_v2";
var result = await WC.Transfer.Consult("TRA-XXXXXXXXXXXX", accessToken);
```
#### Listar Todas Transferências
```C#
var result = await WC.Transfer.List();
```
#### Listar Todas Transferências com filtros
```C#
string filtros = "filters=transferInstrument.method::in(MOIP_ACCOUNT)&limit=3&offset=0";
var result = await WC.Transfer.ListFilter(filtros);
```
## Reembolsos
#### Reembolsar Pagamento
```C#
var body = new RefundRequest
{
    //caso queira fazer um reembolso parcial é necessário informar o atributo amount na requisição
    Amount = "2000"
};            
var result = await WC.Refund.RefundPayment(body, "PAY-XXXXXXXXXXXX");
```
#### Reembolsar Pedido via Cartão de Crédito
```C#
var body = new RefundRequest
{
    //caso queira fazer um reembolso parcial é necessário informar o atributo amount na requisição
    Amount = "2000"
};            
var result = await WC.Refund.RefundRequestCreditCard(body, "ORD-XXXXXXXXXXXX");
```
#### Consultar Reembolso
```C#
var result = await WC.Refund.Consult("REF-XXXXXXXXXXXX");
```
#### Listar Reembolsos do Pagamento
```C#
var result = await WC.Refund.ListPayments("PAY-XXXXXXXXXXXX");
```
#### Listar Reembolsos do Pedido
```C#
var result = await WC.Refund.ListOrders("ORD-XXXXXXXXXXXX");
```
## Conciliação
#### Obter Arquivo de Vendas
```C#
var result = await WC.Conciliation.GetSalesFile("20180829"); // Data no formato YYYYMMDD
```
#### Obter Arquivo Financeiro
```C#
var result = await WC.Conciliation.GetFinancialFile("2018-08-29"); // Data no formato YYYY-MM-DD
```
## Assinatura
#### Criar Plano
```C#
var body = new PlanRequest
{
    Code = "plan103",
    Name = "Plano Especial",
    Description = "Descrição do Plano Especial",
    Amount = 990,
    Setup_Fee = 500,
    Max_Qty = 1,
    Interval = new Interval
    {
        Length = 1,
        Unit = "MONTH"
    },
    Billing_Cycles = 12,
    Trial = new Trial
    {
        Days = 30,
        Enabled = true,
        Hold_Setup_Fee = true
    }
};
var result = await WC.Signature.CreatePlan(body);
```
#### Listar Planos
```C#
var result = await WC.Signature.ListPlans();
```
#### Consultar Plano
```C#
var result = await WC.Signature.ConsultPlan("plan101");
```
#### Ativar Plano
```C#
var result = await WC.Signature.EnablePlan("plan101");
```
#### Desativar Plano
```C#
var result = await WC.Signature.DisablePlan("plan101");
```
#### Alterar Plano
```C#
var body = new PlanRequest
{
    Name = "Plano Especial",
    Description = "",
    Amount = 1290,
    Setup_Fee = 800,
    Max_Qty = 1,
    Payment_Method = "CREDIT_CARD",
    Interval = new Interval
    {
        Length = 1,
        Unit = "MONTH"
    },
    Billing_Cycles = 12,
    Trial = new Trial
    {
        Days = 30,
        Enabled = true,
        Hold_Setup_Fee = true
    }
};
var result = await WC.Signature.ChangePlan(body, "plan101");
```
#### Criar Assinante
```C#
var body = new SubscriberRequest
{
    Code = "cliente03",
    Email = "nome@exemplo.com.br",
    FullName = "Nome Sobrenome",
    Cpf = "22222222222",
    Phone_Area_Code = "11",
    Phone_Number = "934343434",
    BirthDate_Day = "26",
    BirthDate_Month = "04",
    BirthDate_Year = "1980",
    Address = new Address
    {
        Street = "Rua Nome da Rua",
        StreetNumber = "100",
        Complement = "casa",
        District = "Nome do Bairro",
        City = "São Paulo",
        State = "SP",
        Country = "BRA",
        ZipCode = "05015010"
    },
    Billing_Info = new Billing_Info
    {
        Credit_Card = new Credit_Card
        {
            Holder_Name = "Nome Completo",
            Number = "4111111111111111",
            Expiration_Month = "06",
            Expiration_Year = "22"
        }
    }
};
var result = await WC.Signature.CreateSubscriber(body, true);
```
#### Listar Assinantes
```C#
var result = await WC.Signature.ListSubscribers();
```
#### Consultar Assinante
```C#
var result = await WC.Signature.ConsultSubscriber("cliente01");
```
#### Alterar Assinante
```C#
var body = new SubscriberRequest
{
    Code = "cliente01",
    Email = "nome@exemplo.com.br",
    FullName = "Nome Sobrenome",
    Cpf = "22222222222",
    Phone_Area_Code = "11",
    Phone_Number = "934343434",
    BirthDate_Day = "26",
    BirthDate_Month = "04",
    BirthDate_Year = "1980",
    Address = new Address
    {
        Street = "Rua Nome da Rua1",
        StreetNumber = "100",
        Complement = "casa",
        District = "Nome do Bairro",
        City = "São Paulo",
        State = "SP",
        Country = "BRA",
        ZipCode = "05015010"
    }
};
var result = await WC.Signature.ChangeSubscriber(body, "cliente01");
```
#### Atualizar Cartão do Assinante
```C#
var body = new SubscriberRequest
{
    Billing_Info = new Billing_Info
    {
        Credit_Card = new Credit_Card
        {
            Holder_Name = "Novo nome222",
            Number = "5555666677778884",
            Expiration_Month = "12",
            Expiration_Year = "20"
        }
    }
};
var result = await WC.Signature.UpdateSubscriberCard(body, "cliente01");
```
#### Criar Assinaturas
```C#
var body = new SubscriptionRequest
{
    Code = "assinatura04",
    Amount = "9000",
    Plan = new Plan
    {
        Code = "plan101"
    },
    Payment_Method = "CREDIT_CARD",
    Customer = new Customer
    {
        Code = "cliente01",
    }
};
var result = await WC.Signature.CreateSubscriptions(body, false);
```
#### Listar Todas Assinaturas
```C#
var result = await WC.Signature.ListAllSubscriptions();
```
#### Consultar Assinatura -Sem Filtro
```C#
var result = await WC.Signature.ConsultSubscriptionFilter("assinatura01");
```
#### Consultar Assinatura - Com Filtro
```C#
var filter = "q=assinatura01&filters=status::eq(ACTIVE)";
var result = await WC.Signature.ConsultSubscription(filter);
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
```C#
var result = await WC.Signature.SuspendSubscription("assinatura01");
```
#### Reativar Assinatura
```C#
var result = await WC.Signature.ReactivateSignature("assinatura01");
```
#### Cancelar Assinatura
```C#
var result = await WC.Signature.CancelSignature("assinatura01");
```
#### Alterar Assinatura
```C#
var body = new SubscriptionRequest
{
    Plan = new Plan
    {
        Code = "plan101"
    },
    Amount = "9990",
    Next_Invoice_Date = new Next_Invoice_Date
    {
        Day = 15,
        Month = 12,
        Year = 2018
    }
};
var result = await WC.Signature.ChangeSubscription(body, "assinatura01");
```
#### Alterar método de pagamento
```C#
var body = new SubscriptionRequest
{
    Payment_Method = "BOLETO"
};
var result = await WC.Signature.ChangePaymentMethod(body, "assinatura01");
```
#### Listar Todas as Faturas de Uma Assinatura
```C#
var result = await WC.Signature.ListSignatureInvoices("assinatura01");
```
#### Consultar Fatura
```C#
var result = await WC.Signature.ConsultInvoice("10865746");
```
#### Listar todos os pagamentos de fatura
```C#
var result = await WC.Signature.ListAllInvoicePayments("10865746");
```
#### Consultar pagamento de assinatura
```C#
var result = await WC.Signature.ConsultSubscriptionPayment("PAY-123456789012");
```
#### Criar Cupom
```C#
var body = new CouponRequest
{
    Code = "coupon-0002",
    Name = "Coupon name",
    Description = "My new coupon",
    Discount = new Discount
    {
        Value = 1000,
        Type = "percent"
    },
    Status = "active",
    Duration = new Duration
    {
        Type = "repeating",
        Occurrences = 12
    },
    Max_Redemptions = 100,
    Expiration_Date = new Expiration_Date
    {
        Year = 2020,
        Month = 08,
        Day = 01    
    }
};
var result = await WC.Signature.CreateCoupon(body);
```
#### Associar Cupom para Assinatura
```C#
var body = new CouponRequest
{
    Coupon = new Coupon
    {
        Code = "coupon-0001"
    }
};
var result = await WC.Signature.AssociateCouponForExistingSignature(body, "assinatura01");
```
#### Associar Cupom para Nova Assinatura
```C#
var body = new CouponRequest
{
    //informar os campos
};
var result = await WC.Signature.AssociateCouponForExistingSignature(body, "true");
```
#### Consultar Cupom
```C#
var result = await WC.Signature.ConsultCoupon("coupon-0001");
```
#### Listar Todos os Cupons
```C#
var result = await WC.Signature.ListAllCoupons();
```
#### Ativar e Inativar Cupons
```C#
var result = await WC.Signature.EnableOrDisableCoupon("coupon-0001", "inactive");
```
#### Excluir Cupom de uma Assinatura
```C#
var result = await WC.Signature.DeleteSignatureCoupon("assinatura01");
```
#### Retentativa de pagamento de uma fatura
```C#
var result = await WC.Signature.RetentiveInvoicePayment("1548222");
```
#### Gerar um novo boleto para uma fatura
```C#
var body = new RetentativeRequest
{
    Year = 2020,
    Month = 08,
    Day = 01
};
var result = await WC.Signature.CreateNewInvoiceBoleto(body,"1548222");
```
#### Criar Regras de Retentativas Automáticas
```C#
var body = new RetentativeRequest
{
    First_Try = 1,
    Second_Try = 3,
    Third_Try = 5,
    Finally = "cancel"
};
var result = await WC.Signature.CreateAutomaticRetentionRules(body);
```

#### Criar Preferência de Notificação
```C#
var body = new NotificationRequest
{
    Notification = new Notification
    {
        Webhook = new Webhook
        {
            Url = "http://exemploldeurl.com.br/assinaturas"
        },
        Email = new Email
        {
            Merchant = new Merchant
            {
                Enabled = true
            },
            Customer = new Customer
            {
                Enabled = true
            }
        }
    }
};
var result = await WC.Signature.CreateNotificationPreference(body);
```

## Convertendo objeto para json

As vezes você enfrenta um problema e o suporte Wirecard pede o código json para verificar se realmente está no json:

```C#
using Newtonsoft.Json;

var body = new PaymentRequest
{
    //informe os campos aqui
    DelayCapture = true,
    InstallmentCount = 1,
    FundingInstrument = new Fundinginstrument
    {
        Method = "CREDIT_CARD",
        CreditCard = new Creditcard
        {
            Id = "CRC-XXXXXXXXXXXX",
            Cvc = "123",
            Holder = new Holder
            {
                FullName = "Jose Portador da Silva",
                BirthDate = "1988-12-30",
                TaxDocument = new Taxdocument
                {
                    Type = "CPF",
                    Number = "33333333333"
                }
            }
        }
    }
};

//Aqui você pode obter json e compratilhar para suporte Wirecard
string json = JsonConvert.SerializeObject(body, Formatting.Indented);
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

## Alterando accesstoken

```C#
WC.ChangeAccessToken("new access token here");
```

## Tabela
#### Tipos de Lançamentos

| Id  | Tipo | Descrição |
| ------------- | ------------- | ------------- |
| 1 | CREDIT_CARD | Recebíveis de cartão de crédito |
| 2 | CREDIT_CARD_INSTALLMENT | Recebíveis de cartão de crédito com parcelamento |
| 3 | DEBIT_CARD | Recebíveis de cartão de débito |
| 4 | BOLETO | Recebíveis de boleto |
| 5 | BANK_FINANCING | Recebíveis de financiamento bancário |
| 6 | BANK_DEBIT | Recebíveis de débito bancário |
| 7 | MOIP_WALLET | Recebíveis de pagamento usando conta Moip |
| 8 | COMMISSION | Recebíveis como recebedor secundário |
| 9 | COMMISSION_INSTALLMENT | Recebíveis como recebedor secundário com parcelamento |
| 10 | TRANSFER_TO_MOIP_ACCOUNT_RECEIVED | Transferências entre contas Moip |
| 11 | TRANSFER_TO_BANK_ACCOUNT_CANCELLED | Devolucao de transferencia para conta bancaria |
| 12 | DEPOSIT | Deposito |
| 13 | AMOUNT_UNBLOCKED | Liberacao de bloqueio de saldo |
| 14 | TRANSFER_TO_BANK_ACCOUNT | Transferencia para conta bancaria |
| 15 | TRANSFER_TO_MOIP_ACCOUNT_PAID | Transferencia entre contas Moip realizada |
| 16 | PAYMENT_REVERSE | Estornos de pagamento |
| 17 | PAYMENT_INSTALLMENT_REVERSE | Estornos de parcelas de pagamento |
| 18 | COMMISSION_REVERSE | Estornos de comissão de pagamento |
| 19 | COMMISSION_INSTALLMENT_REVERSE | Estornos de comissão da parcela |
| 20 | PAYMENT_REFUND | Reembolsos de pagamento |
| 21 | PAYMENT_INSTALLMENT_REFUND | Reembolsos de parcelas de pagamento |
| 22 | PAYMENT_PARCIAL_REFUND | Reembolsos parciais |
| 23 | PAYMENT_PARCIAL_INSTALLMENT_REFUND | Reembolsos parciais de parcelas de pagamento |
| 24 | COMMISSION_REFUND | Reembolsos de comissões de pagamento |
| 25 | COMMISSION_INSTALLMENT_REFUND | Reembolsos de comissões de parcelas de pagamento |
| 26 | MOIP_WALLET_PAYMENT | Pagamento realizado |
| 27 | PRE_PAYMENT_FEE | Taxas de antecipação de recebí­veis |
| 28 | PENALTY | Multa |
| 29 | MOIP_RECURRING_CHARGE | Assinatura Moip |
| 30 | AMOUNT_BLOCKED | Bloqueio de saldo |
| 31 | MOIP_FINANCIAL_ADJUSTEMENT | Ajuste financeiro do Moip |
| 32 | REFUND_REVOKE | Cancelamento do Reembolso do Pagamento |
| 33 | PAYMENT_PARCIAL_REFUND_REVOKE | Cancelamento do Reembolso parcial do Pagamento |
| 34 | PAYMENT_PARCIAL_INSTALLMENT_REFUND_REVOKE | Cancelamento do Reembolso parcial do Pagamento |
| 35 | COMMISSION_REFUND_REVOKE | Cancelamento do Reembolso da Comissao do Pagamento |
| 36 | COMMISSION_INSTALLMENT_REFUND_REVOKE | Cancelamento do Reembolso da Comissao do Pagamento |
| 37 | REMITTANCE_CREDIT | Recebí­veis de pagamento de remessa |
| 38 | REMITTANCE_DEBIT | Pagamento de remessa |
| 39 | BALANCE_ADJUSTMENT | Conciliacao entre plataformas |
| 40 | JUDICIAL_DEBIT | Débito Juridico |
| 41 | TRANSFER_TO_MOIP_ACCOUNT_PAID_REVERTED | Transferencia entre contas revertida |
| 42 | TRANSFER_TO_MOIP_ACCOUNT_RECEIVED_REVERTED | Transferencia entre contas revertida |
| 43 | REMAINING_CREDIT_REFUND | Credito Remanescente de Reembolso |
| 44 | DEBIT_COMPENSATORY_REFUND | Debito Compensatorio de Reembolso |
| 45 | MAINTENANCE_FEE | Taxa de manutencao - conta inativa |
| 46 | ESCROW_BLOCKED | Bloqueio de custódia |
| 47 | ESCROW_UNBLOCKED | Desbloqueio de custódia |
| 48 | BILL_PAYMENT | Pagamento de contas |
| 49 | CARD_PURCHASE | Compra no cartão |
| 50 | CARD_PURCHASE_REVERSAL | Reversão de compra no cartão |
| 51 | CARD_WITHDRAWAL | Saque no cartão |
| 52 | CARD_WITHDRAWAL_REVERSAL | Reversão de saque no cartão |
| 53 | CARD_PREPURCHASE | Pré-compra no cartão |
| 54 | CARD_PREPURCHASE_REVERSAL | Reversão de pré-compra no cartão |
| 55 | CARD_PREPURCHASE_INCREMENT | Incremento de pré-compra no cartão |
| 56 | CARD_PREPURCHASE_INCREMENT_REVERSAL | Reversão de incremento de pré-compra |
| 57 | CARD_PREPURCHASE_COMPLETE | Finalização de pré-compra |
| 58 | CARD_REFUND | Reembolso de compra no cartão |
| 59 | CARD_REFUND_REVERSAL | Reversão de reembolso de compra no cartão |
| 60 | CARD_CHARGEBACK | Chargeback de compra no cartão |
| 61 | CARD_CHARGEBACK_REVERSAL | Reversão de chargeback de compra no cartão |
| 62 | CARD_ISSUED | Taxa de emissão do cartão |
| 63 | CARD_P2PCREDIT | Crédito de P2P |
| 64 | CARD_P2PCREDIT_REVERSAL | Reversão de crédito P2P |
| 65 | BILL_PAYMENT_CANCELLED | Devoluo de pagamento de contas |


## Filtros de busca

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
using Wirecard.Exception;

try
{
    var result = await WC.Customer.Create(new CustomerRequest());
}
catch (WirecardException ex)
{
    var t = ex.wirecardError;
    var t_text = ex.GetExceptionText();
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

[The MIT License](https://github.com/matmiranda/Wirecard/blob/master/LICENSE)

Tem dúvidas? Fale com a gente no [Slack](https://slackin-cqtchmfquq.now.sh/)!
Algum problema ? Abre issues!
