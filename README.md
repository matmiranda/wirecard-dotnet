<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://www.linknacional.com.br/wp-content/uploads/2016/03/moip-boleto-pagamento-whmcs.png" alt="Moip logo" width=150>
  </a>
  <p align="center">
    O jeito mais simples e rápido de integrar o Moip a sua aplicação .NET
    <br>
    <a href="https://dev.moip.com.br/v2.0/docs">Documentação</a>
    .
    <a href="https://dev.moip.com.br/v2.0/reference">Referência API</a>
    ·
    <a href="https://slackin-cqtchmfquq.now.sh/">Slack</a>
  </p>
</p>

## Índice
-[Conta Clássica]()
-[Conta Transparente]()
-[Clientes]()
-[Pedidos]()
-[Pagamentos]()
-[Multipedidos]()
-[Multipagamentos]()
-[Notificações]()
-[Contas Bancárias]()
-[Saldo Moip]()
-[Lançamentos]()
-[Transferências]()
-[Reembolsos]()
-[Conciliação]()

## Instalação
Execute o comando para instalar via [NuGet](https://www.nuget.org/packages/MoipCSharp/):

```xml
PM> Install-Package MoipCSharp -Version 1.1.4
```

## Autenticando e configurando o ambiente
Para gerar o client, informe seu token oAuth e em qual environment você quer executar suas ações:
```C#
using MoipCSharp;
using MoipCSharp.Models;
using static MoipCSharp.Configuration;

private HttpClient client = SetClient("XXXXXXXXXXXXXXXXXXXXX_v2", BaseAddress.SANDBOX); //PRODUCTION == PRODUÇÃO
```


## Licença

[The MIT License](https://github.com/moip/moip-sdk-dotnet/blob/master/LICENSE)

Tem dúvidas? Fale com a gente no [Slack](https://slackin-cqtchmfquq.now.sh/)!
Algum problema ? Abre issues!
