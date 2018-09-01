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
- [Informação](#informação)
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

## Informação

Essa biblioteca usa a classe [HttpClient](https://docs.microsoft.com/pt-br/dotnet/api/system.net.http.httpclient?view=netframework-4.7.2) e disponibiliza os principais métodos (GET, POST, PUT, DELETE).

## Instalação
Execute o comando para instalar via [NuGet](https://www.nuget.org/packages/MoipCSharp/):

```xml
PM> Install-Package MoipCSharp -Version 2.0.1
```

## Autenticando e configurando o ambiente
Para gerar o HttpClient, informe seu token oAuth e em qual environment você quer executar suas ações:
```C#
using MoipCSharp;
using MoipCSharp.Models;

private static HttpClient HttpClient = new HttpClient();

Uri uri = new Uri(BaseAddress.SANDBOX);
HttpClient.BaseAddress = uri;
HttpClient.DefaultRequestHeaders.Clear();
HttpClient.DefaultRequestHeaders.ConnectionClose = false;
HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
ServicePointManager.FindServicePoint(uri).ConnectionLeaseTimeout = 60 * 1000; //1 minuto
ServicePointManager.DnsRefreshTimeout = 60 * 1000; //1 minuto
HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "xxxxxxxxxxxxxxxxxxxxxxxxxxx_v2");
```

## Conta Clássica
#### Verificar se usuário já possui Conta Moip
```C#
var result = await ContaClassica.VerificarSeUsuarioJaPossuiContaMoip(HttpClient, "meu_email@email.com");
```

#### Criar Conta Moip Clássica
```C#
var body = new CriarContaMoipClassicaRequest
{
    //informe os campos aqui
};
var result = await ContaClassica.CriarContaMoipClassica(HttpClient, body);
```

#### Consultar Conta Moip
```C#
var result = await ContaClassica.ConsultarContaMoip(HttpClient, "MPA-XXXXXXXXXXXX");
```

#### Solicitar Permissões de Acesso ao Usuário
```C#
var result = await ContaClassica.SolicitarPermissoesAcessoUsuario(HttpClient, /*informe o valor de cada parâmetro*/);
```

#### Gerar Access Token
```C#
var result = await ContaClassica.GerarAccessToken(HttpClient, /*informe o valor de cada parâmetro*/);
```

#### Atualizar accessToken
```C#
var result = await ContaClassica.AtualizarAccessToken(HttpClient, /*informe o valor de cada parâmetro*/);
```

#### Obter chave pública de uma Conta Moip
```C#
var result = await ContaClassica.ObterChavePublicaContaMoip(HttpClient);
```

## Conta Transparente
#### Criar Conta Moip Transparente
```C#
var body = new CriarContaMoipTransparenteRequest
{
    //informe os campos aqui
};
var result = await ContaTrasparente.CriarContaMoipTransparente(HttpClient, body);
```

## Clientes
#### Criar Cliente
```C#
var body = new ClienteRequest
{
    //informe os campos aqui
};
var result = await Clientes.CriarCliente(body);
```

#### Adicionar Cartão de Crédito
```C#
var body = new CartaoDeCreditoRequest
{
    //informe os campos aqui
};
var result = await Clientes.AdicionarCartaoDeCredito(HttpClient, body, "CUS-XXXXXXXXXXXX");
```

#### Atualizar Cliente
```C#
var body = new AtualizarClienteRequest
{
    //informe os campos aqui
};
var result = await Clientes.AtualizarCliente(HttpClient, body);
```

#### Deletar Cartão de Crédito
```C#
var result = await Clientes.DeletarCartaoCredito(HttpClient, "CRC-XXXXXXXXXXXX");
```

#### Consultar Cliente
```C#
var result = await Clientes.ConsultarCliente(HttpClient, "CUS-XXXXXXXXXXXX");
```

#### Listar Todos os Clientes
```C#
var result = await Clientes.ListarTodosClientes(HttpClient);
```

## Pedidos
#### Criar Pedido
```C#
var body = new CriarPedidoRequest
{
    //informe os campos aqui
};
var result = await Pedidos.CriarPedido(HttpClient, body);
```

#### Consultar Pedido
```C#
var result = await Pedidos.ConsultarPedido(HttpClient, "ORD-XXXXXXXXXXXX");
```

#### Listar Todos os Pedidos - Sem Filtros
```C#
var result = await Pedidos.ListarTodosPedidos(HttpClient);
```

#### Listar Todos os Pedidos - Com Filtros
```C#
string filtros = "q=josesilva&filters=status::in(PAID,WAITING)|paymentMethod::in(CREDIT_CARD,BOLETO)|value::bt(5000,10000)&limit=3&offset=0";
var result = await Pedidos.ListarTodosPedidosFiltros(HttpClient, filtros);
```
 Veja a tabela filtros de busca [aqui](#tabela---filtros-de-busca).
 
 ## Pagamentos
 #### Criar Pagamento
 ```C#
var body = new CriarPagamentoRequest
{
    //informe os campos aqui
};            
var result = await Pagamentos.CriarPagamento(HttpClient, body, "ORD-XXXXXXXXXXXX");
```

#### Liberação de Custódia
```C#
var result = await Pagamentos.LiberarCustodia(HttpClient, "ECW-XXXXXXXXXXXX");
```

#### Capturar Pagamento Pré-autorizado
```C#
var result = await Pagamentos.CapturarPagamentoPreAutorizado(HttpClient, "PAY-XXXXXXXXXXXX");
```

#### Cancelar Pagamento Pré-autorizado
```C#
var result = await Pagamentos.CancelarPagamentoPreAutorizado(HttpClient, "PAY-XXXXXXXXXXXX");
```

#### Consultar Pagamento
```C#
var result = await Pagamentos.ConsultarPagamento(HttpClient, "PAY-XXXXXXXXXXXX");
```

#### Simular Pagamentos (sandbox)
```C#
var result = await Pagamentos.SimularPagamentos(HttpClient, "PAY-XXXXXXXXXXXX", 26500);
```

## Multipedidos
#### Criar Multipedido
```C#
var body = new CriarMultiPedidoRequest
{
    //informe os campos aqui
};            
var result = await MultiPedidos.CriarMultiPedido(HttpClient, body);
```

#### Consultar Multipedido
```C#
var result = await MultiPedidos.ConsultarMultiPedido(HttpClient, "MOR-XXXXXXXXXXXX");
```

## Multipagamentos
#### Criar Multipagamento
```C#
var body = new CriarMultiPagamentoRequest
{
    //informe os campos aqui
};            
var result = await MultiPagamentos.CriarMultiPagamento(HttpClient, body, "MOR-XXXXXXXXXXXX");
```
#### Consultar Multipagamento
```C#
var result = await MultiPagamentos.ConsultarMultiPagamento(HttpClient, "MPY-XXXXXXXXXXXX");
```
#### Capturar Multipagamento Pré-autorizado
```C#
var result = await MultiPagamentos.CapturarMultiPagamentoPreAutorizado(HttpClient, "MPY-XXXXXXXXXXXX");
```
#### Cancelar Multipagamento Pré-autorizado
```C#
var result = await MultiPagamentos.CancelarMultiPagamentoPreAutorizado(HttpClient, "MPY-XXXXXXXXXXXX");
```
#### Liberação de Custódia
```C#
var result = await MultiPagamentos.LiberarCustodia(HttpClient, "ECW-XXXXXXXXXXXX");
```

## Notificações
#### Criar Preferência de Notificação para Conta Moip
```C#
var body = new CriarPreferenciaNotificacaoContaMoipRequest
{
    //informe os campos aqui
};            
var result = await Notificacoes.CriarPreferenciaNotificacaoContaMoip(HttpClient, body);
```

#### Criar Preferência de Notificação para App
```C#
var body = new CriarPreferenciaNotificacaoAppRequest
{
    //informe os campos aqui
};            
var result = await Notificacoes.CriarPreferenciaNotificacaoApp(HttpClient, body, "APP-XXXXXXXXXXXX");
```

#### Consultar Preferência de Notificação
```C#
var result = await Notificacoes.ConsultarPreferenciaNotificacao(HttpClient, "NPR-XXXXXXXXXXXX");
```

#### Listar Todas as Preferências de Notificação
```C#
var result = await Notificacoes.ListarTodasPreferenciasNotificacaoAsync(HttpClient);
```

#### Remover Preferência de Notificação
```C#
var result = await Notificacoes.RemoverPreferenciaNotificacao(HttpClient, "NPR-XXXXXXXXXXXX");
```

#### Consultar Webhook Enviado
```C#
var result = await Notificacoes.ConsultarWebhookEnviado(HttpClient, "PAY-XXXXXXXXXXXX"); 
```

#### Listar Todos os Webhooks Enviados
```C#
var result = await Notificacoes.ListarTodosWebhooksEnviados(HttpClient);
```

## Contas Bancárias
#### Criar Conta Bancária
```C#
var body = new CriarContaBancariaRequest
{
    //informe os campos aqui
};            
var result = await ContasBancarias.CriarContaBancaria(HttpClient, body, "MPA-XXXXXXXXXXXX");
```

#### Consultar Conta Bancária
```C#
var result = await ContasBancarias.ConsultarContaBancaria(HttpClient, "BKA-XXXXXXXXXXXX");
```

#### Listar Todas Contas Bancárias
```C#
var result = await ContasBancarias.ListarTodasContasBancarias(HttpClient, "MPA-XXXXXXXXXXXX");
```

#### Deletar Conta Bancária
```C#
var result = await ContasBancarias.DeletarContaBancaria(HttpClient, "BKA-XXXXXXXXXXXX");
```

#### Atualizar Conta Bancária
```C#
var body = new AtualizarContaBancariaRequest
{
    //informe os campos aqui
};            
var result = await ContasBancarias.AtualizarContaBancaria(HttpClient, body, "BKA-XXXXXXXXXXXX");
```

## Saldo Moip
#### Consultar Saldos
```C#
var result = await SaldoMoip.ConsultarSaldos();
```

## Lançamentos
#### Consultar Lançamento
```C#
var result = await Lancamento.ConsultarLancamento(HttpClient, "ENT-XXXXXXXXXXXX");
```

#### Listar Todos Lançamentos
```C#
var result = await Lancamento.ListarTodosLancamentos(HttpClient);
```

## Transferências
#### Criar Transferência
```C#
var body = new CriarTransferenciaRequest
{
    //informe os campos aqui
};            
var result = await Transferencias.CriarTransferencia(HttpClient, body);
```

#### Reverter Transferência
```C#
var result = await Transferencias.ReverterTransferencia(HttpClient, "TRA-XXXXXXXXXXXX");
```

#### Consultar Transferência
```C#
var result = await Transferencias.ConsultarTransferencia(HttpClient, "TRA-XXXXXXXXXXXX");
```

#### Listar Todas Transferências
```C#
var result = await Transferencias.ListarTodasTransferencias(HttpClient);
```

## Reembolsos
#### Reembolsar Pagamento
```C#
var body = new ReembolsarPagamentoRequest
{
    //informe os campos aqui
};            
var result = await Reembolsos.ReembolsarPagamento(HttpClient, body, "PAY-XXXXXXXXXXXX");
```

#### Reembolsar Pedido via Cartão de Crédito
```C#
var body = new ReembolsarPedidoCartaoCreditoRequest
{
    //informe os campos aqui
};            
var result = await Reembolsos.ReembolsarPedidoCartaoCredito(HttpClient, body, "ORD-XXXXXXXXXXXX");
```

#### Consultar Reembolso
```C#
var result = await Reembolsos.ConsultarReembolso(HttpClient, "REF-XXXXXXXXXXXX");
```

#### Listar Reembolsos do Pagamento
```C#
var result = await Reembolsos.ListarReembolsosPagamento(HttpClient, "PAY-XXXXXXXXXXXX");
```

#### Listar Reembolsos do Pedido
```C#
var result = await Reembolsos.ListarReembolsosPedido(HttpClient, "ORD-XXXXXXXXXXXX");
```

## Conciliação
#### Obter Arquivo de Vendas
```C#
var result = await Conciliacao.ObterArquivoVendas(HttpClient, "20180829"); // Data no formato YYYYMMDD
```

#### Obter Arquivo Financeiro
```C#
var result = await Conciliacao.ObterArquivoFinanceiro(HttpClient, "2018-08-29"); // Data no formato YYYY-MM-DD
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
Você pode recuperar os atributos `code`, `path`, `description` e `message`, veja no exemplo abaixo:
```C#
using MoipCSharp.Exceptions;

try
{
    var result = await Clientes.CriarCliente(HttpClient, new CriarClienteRequest());
}
catch (Exception moip)
{
    var erros = JsonConvert.DeserializeObject<MoipException>(moip.Message);
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
