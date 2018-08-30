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
PM> Install-Package MoipCSharp -Version 1.1.5
```

## Autenticando e configurando o ambiente
Para gerar o client, informe seu token oAuth e em qual environment você quer executar suas ações:
```C#
using MoipCSharp;
using MoipCSharp.Models;
using static MoipCSharp.Configuration;

private HttpClient client = SetClient("XXXXXXXXXXXXXXXXXXXXX_v2", BaseAddress.SANDBOX); //PRODUCTION == PRODUÇÃO
```

## Conta Clássica
#### Verificar se usuário já possui Conta Moip
```C#
var result = await ContaClassica.VerificarSeUsuarioJaPossuiContaMoipAsync("meu_email@email.com");
```

#### Criar Conta Moip Clássica
```C#
var body = new CriarContaMoipClassicaRequest
{
    //informe os campos aqui
};
var result = await ContaClassica.CriarContaMoipClassicaAsync(body);
```

#### Consultar Conta Moip
```C#
var result = await ContaClassica.ConsultarContaMoipAsync("MPA-XXXXXXXXXXXX");
```

#### Solicitar Permissões de Acesso ao Usuário
```C#
var result = await ContaClassica.SolicitarPermissoesDeAcessoUsuarioAsync(/*informe o valor de cada parâmetro*/);
```

#### Gerar Access Token
```C#
var result = await ContaClassica.GerarAccessTokenAsync(/*informe o valor de cada parâmetro*/);
```

#### Atualizar accessToken
```C#
var result = await ContaClassica.AtualizarAccessTokenAsync(/*informe o valor de cada parâmetro*/);
```

#### Obter chave pública de uma Conta Moip
```C#
var result = await ContaClassica.ObterChavePublicaContaMoipAsync();
```

## Conta Transparente
#### Criar Conta Moip Transparente
```C#
var body = new CriarContaMoipTransparenteRequest
{
    //informe os campos aqui
};
var result = await ContaTrasparente.CriarContaMoipTransparenteAsync(body);
```

## Clientes
#### Criar Cliente
```C#
var body = new ClienteRequest
{
    //informe os campos aqui
};
var result = await Clientes.CriarClienteAsync(body);
```

#### Adicionar Cartão de Crédito
```C#
var body = new CartaoDeCreditoRequest
{
    //informe os campos aqui
};
var result = await Clientes.AdicionarCartaoDeCreditoAsync(body, "CUS-XXXXXXXXXXXX");
```

#### Atualizar Cliente
```C#
var body = new AtualizarClienteRequest
{
    //informe os campos aqui
};
var result = await Clientes.AtualizarClienteAsync(body);
```

#### Deletar Cartão de Crédito
```C#
var result = await Clientes.DeletarCartaoDeCreditoAsync("CRC-XXXXXXXXXXXX");
```

#### Consultar Cliente
```C#
var result = await Clientes.ConsultarClienteAsync("CUS-XXXXXXXXXXXX");
```

#### Listar Todos os Clientes
```C#
var result = await Clientes.ListarTodosOsClientes();
```

## Pedidos
#### Criar Pedido
```C#
var body = new CriarPedidoRequest
{
    //informe os campos aqui
};
var result = await Pedidos.CriarPedidoAsync(body);
```

#### Consultar Pedido
```C#
var result = await Pedidos.ConsultarPedidoAsync("ORD-XXXXXXXXXXXX");
```

#### Listar Todos os Pedidos - Sem Filtros
```C#
var result = await Pedidos.ListarTodosOsPedidosAsync();
```

#### Listar Todos os Pedidos - Com Filtros
```C#
string filtros = "q=josesilva&filters=status::in(PAID,WAITING)|paymentMethod::in(CREDIT_CARD,BOLETO)|value::bt(5000,10000)&limit=3&offset=0";
var result = await Pedidos.ListarTodosOsPedidosFiltrosAsync(filtros);
```
 Veja a tabela filtros de busca [aqui](#tabela---filtros-de-busca).
 
 ## Pagamentos
 #### Criar Pagamento
 ```C#
var body = new CriarPagamentoRequest
{
    //informe os campos aqui
};            
var result = await Pagamentos.CriarPagamentoAsync(body, "ORD-XXXXXXXXXXXX");
```

#### Liberação de Custódia
```C#
var result = await Pagamentos.LiberacaoDeCustodiaAsync("ECW-XXXXXXXXXXXX");
```

#### Capturar Pagamento Pré-autorizado
```C#
var result = await Pagamentos.CapturarPagamentoPreAutorizadoAsync("PAY-XXXXXXXXXXXX");
```

#### Cancelar Pagamento Pré-autorizado
```C#
var result = await Pagamentos.CancelarPagamentoPreAutorizadoAsync("PAY-XXXXXXXXXXXX");
```

#### Consultar Pagamento
```C#
var result = await Pagamentos.ConsultarPagamentoAsync("PAY-XXXXXXXXXXXX");
```

#### Simular Pagamentos (sandbox)
```C#
var result = await Pagamentos.SimularPagamentosAsync("PAY-XXXXXXXXXXXX", 26500);
```

## Multipedidos
#### Criar Multipedido
```C#
var body = new CriarMultiPedidoRequest
{
    //informe os campos aqui
};            
var result = await MultiPedidos.CriarMultiPedidoAsync(body);
```

#### Consultar Multipedido
```C#
var result = await MultiPedidos.ConsultarMultiPedidoAsync("MOR-XXXXXXXXXXXX");
```

## Multipagamentos
#### Criar Multipagamento
```C#
var body = new CriarMultiPagamentoRequest
{
    //informe os campos aqui
};            
var result = await MultiPagamentos.CriarMultiPagamentoAsync(body, "MOR-XXXXXXXXXXXX");
```
#### Consultar Multipagamento
```C#
var result = await MultiPagamentos.ConsultarMultiPagamentoAsync("MPY-XXXXXXXXXXXX");
```
#### Capturar Multipagamento Pré-autorizado
```C#
var result = await MultiPagamentos.CapturarMultiPagamentoPreAutorizadoAsync("MPY-XXXXXXXXXXXX");
```
#### Cancelar Multipagamento Pré-autorizado
```C#
var result = await MultiPagamentos.CancelarMultiPagamentoPreAutorizadoAsync("MPY-XXXXXXXXXXXX");
```
#### Liberação de Custódia
```C#
var result = await MultiPagamentos.LiberarCustodiaAsync("ECW-XXXXXXXXXXXX");
```

## Notificações
#### Criar Preferência de Notificação para Conta Moip
```C#
var body = new CriarPreferenciaDeNotificacaoParaContaMoipRequest
{
    //informe os campos aqui
};            
var result = await Notificacoes.CriarPreferenciaDeNotificacaoParaContaMoipAsync(body);
```

#### Criar Preferência de Notificação para App
```C#
var body = new CriarPreferenciaDeNotificacaoParaAppRequest
{
    //informe os campos aqui
};            
var result = await Notificacoes.CriarPreferenciaDeNotificacaoParaAppAsync(body, "APP-XXXXXXXXXXXX");
```

#### Consultar Preferência de Notificação
```C#
var result = await Notificacoes.ConsultarPreferenciaDeNotificacaoAsync("NPR-XXXXXXXXXXXX");
```

#### Listar Todas as Preferências de Notificação
```C#
var result = await Notificacoes.ListarTodasAsPreferenciasDeNotificacaoAsync();
```

#### Remover Preferência de Notificação
```C#
var result = await Notificacoes.RemoverPreferenciaDeNotificacaoAsync("NPR-XXXXXXXXXXXX");
```

#### Consultar Webhook Enviado
```C#
var result = await Notificacoes.ConsultarWebhookEnviadoAsync("PAY-XXXXXXXXXXXX"); 
```

#### Listar Todos os Webhooks Enviados
```C#
var result = await Notificacoes.ListarTodosOsWebhooksEnviadosAsync();
```

## Contas Bancárias
#### Criar Conta Bancária
```C#
var body = new CriarContaBancariaRequest
{
    //informe os campos aqui
};            
var result = await ContasBancarias.CriarContaBancariaAsync(body, "MPA-XXXXXXXXXXXX");
```

#### Consultar Conta Bancária
```C#
var result = await ContasBancarias.ConsultarContaBancariaAsync("BKA-XXXXXXXXXXXX");
```

#### Listar Todas Contas Bancárias
```C#
var result = await ContasBancarias.ListarTodasContasBancariasAsync("MPA-XXXXXXXXXXXX");
```

#### Deletar Conta Bancária
```C#
var result = await ContasBancarias.DeletarContaBancariaAsync("BKA-XXXXXXXXXXXX");
```

#### Atualizar Conta Bancária
```C#
var body = new AtualizarContaBancariaRequest
{
    //informe os campos aqui
};            
var result = await ContasBancarias.AtualizarContaBancariaAsync(body, "BKA-XXXXXXXXXXXX");
```

## Saldo Moip
#### Consultar Saldos
```C#
var result = await SaldoMoip.ConsultarSaldosAsync();
```

## Lançamentos
#### Consultar Lançamento
```C#
var result = await Lancamento.ConsultarLancamentoAsync("ENT-XXXXXXXXXXXX");
```

#### Listar Todos Lançamentos
```C#
var result = await Lancamento.ListarTodosLancamentosAsync();
```

## Transferências
#### Criar Transferência
```C#
var body = new CriarTransferenciaRequest
{
    //informe os campos aqui
};            
var result = await Transferencias.CriarTransferenciaAsync(body);
```

#### Reverter Transferência
```C#
var result = await Transferencias.ReverterTransferenciaAsync("TRA-XXXXXXXXXXXX");
```

#### Consultar Transferência
```C#
var result = await Transferencias.ConsultarTransferenciaAsync("TRA-XXXXXXXXXXXX");
```

#### Listar Todas Transferências
```C#
var result = await Transferencias.ListarTodasTransferenciasAsync();
```

## Reembolsos
#### Reembolsar Pagamento
```C#
var body = new ReembolsarPagamentoRequest
{
    //informe os campos aqui
};            
var result = await Reembolsos.ReembolsarPagamentoAsync(body, "PAY-XXXXXXXXXXXX");
```

#### Reembolsar Pedido via Cartão de Crédito
```C#
var body = new ReembolsarPedidoViaCartaoDeCreditoRequest
{
    //informe os campos aqui
};            
var result = await Reembolsos.ReembolsarPedidoViaCartaoDeCreditoAsync(body, "ORD-XXXXXXXXXXXX");
```

#### Consultar Reembolso
```C#
var result = await Reembolsos.ConsultarReembolsoAsync("REF-XXXXXXXXXXXX");
```

#### Listar Reembolsos do Pagamento
```C#
var result = await Reembolsos.ListarReembolsosDoPagamentoAsync("PAY-XXXXXXXXXXXX");
```

#### Listar Reembolsos do Pedido
```C#
var result = await Reembolsos.ListarReembolsosDoPedidoAsync("ORD-XXXXXXXXXXXX");
```

## Conciliação
#### Obter Arquivo de Vendas
```C#
var result = await Conciliacao.ObterArquivoDeVendasAsync("20180829"); // Data no formato YYYYMMDD
```

#### Obter Arquivo Financeiro
```C#
var result = await Conciliacao.ObterArquivoFinanceiroAsync("2018-08-29"); // Data no formato YYYY-MM-DD
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

## Licença

[The MIT License](https://github.com/matmiranda/MoipCSharp/blob/master/LICENSE)

Tem dúvidas? Fale com a gente no [Slack](https://slackin-cqtchmfquq.now.sh/)!
Algum problema ? Abre issues!
