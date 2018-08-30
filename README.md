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
- [Instalação](#instalação)
- [Autenticando e configurando o ambiente](#autenticando-e-configurando-o-ambiente)
- [Exemplos de Uso](#clientes):
  - [Pedidos](#pedidos)
    - [Criação](#criação)
    - [Consulta](#consulta)
      - [Pedido Específico](#pedido-específico)
      - [Todos os Pedidos](#todos-os-pedidos)
        - [Sem Filtro](#sem-filtro)
        - [Com Filtros](#com-filtros)
        - [Com Paginação](#com-paginação)
        - [Consulta Valor Específico](#consulta-valor-específico)
  - [Pagamentos](#pagamentos)
    - [Criação](#criação-1)
      - [Cartão de Crédito](#cartão-de-crédito)
      - [Boleto](#boleto)
    - [Consulta](#consulta-1)
    - [Capturar pagamento pré-autorizado](#capturar-pagamento-pré-autorizado)
    - [Cancelar pagamento pré-autorizado](#cancelar-pagamento-pré-autorizado)
  - [Clientes](#clientes)
    - [Criação](#criação-2)
    - [Consulta](#consulta-2)
    - [Adicionar cartão de crédito](#adicionar-cartão-de-crédito)
  - [Preferências de Notificação](#preferências-de-notificação)
    -  [Criação](#criação-3)
    -  [Consulta](#consulta-3)
    -  [Exclusão](#exclusão)
    -  [Listagem](#listagem)
  - [Reembolsos](#reembolsos)
    - [Pedido](#pedido)
    - [Pagamento](#pagamento)
    - [Consulta](#consulta-4)
  - [Multipedidos](#multipedidos)
    - [Criação](#criação-4)
    - [Consulta](#consulta-5)
  - [Multipagamentos](#multipagamentos)
    - [Criação](#criação-5)
      - [Cartão de Crédito](#cartão-de-crédito-1)
      - [Boleto Bancário](#boleto-bancário)
    - [Consulta](#consulta-6)
    - [Capturar multipagamento pré-autorizado](#capturar-multipagamento-pré-autorizado)
    - [Cancelar multipagamento pré-autorizado](#cancelar-multipagamento-pré-autorizado)
  - [Conta Moip](#conta-moip)
    - [Criação](#criação-6)
    - [Consulta](#consulta-7)
    - [Verifica se usuário já possui Conta Moip](#verifica-se-usuário-já-possui-conta-moip)
  - [Contas Bancárias](#contas-bancárias)
    - [Criação](#criação-7)
    - [Consulta](#consulta-8)
    - [Exclusão](#exclusão-1)
    - [Atualização](#atualização)
    - [Listagem](#listagem-1)
  - [Transferência](#transferência)
    - [Criação](#criação-8)
      -[Conta Bancária](#conta-bancária)
      -[Conta Moip](#conta-moip-1)
    - [Consulta](#consulta-9)
    - [Listagem](#listagem-2)
    - [Reversão](#reversão)
  - [Custódia](#custódia)
    - [Pagamento com custódia](#pagamento-com-custódia)
    - [Liberação de custódia](#liberação-de-custódia)
  - [OAuth (Moip Connect)](#oauth-(moip-connect))
    - [Solicitar permissões de acesso ao usuário](#solicitar-permissões-de-acesso-ao-usuário)
    - [Gerar Token OAuth](#gerar-token-oauth)
    - [Atualizar Token OAuth](#atualizar-token-oauth)
- [Tratamento de Exceções](#tratamento-de-exceções)
- [Documentação](#documentação)
- [Licença](#licença)
- [Comunidade Slack](#comunidade-slack-) [![Slack](https://user-images.githubusercontent.com/4432322/37355972-ba0e9f32-26c3-11e8-93d3-39917eb24109.png)](https://slackin-cqtchmfquq.now.sh)

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
