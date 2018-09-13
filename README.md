<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://res.cloudinary.com/https-github-com-matmiranda-moipcsharp/image/upload/v1536852276/moip.png" alt="Moip logo" width=150>
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

[HttpClient](https://docs.microsoft.com/pt-br/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client#create-and-initialize-httpclient) destina-se a ser instanciada **uma vez** e reutilizada durante a vida útil de um aplicativo. 

As condições a seguir podem resultar em [SocketException](https://msdn.microsoft.com/pt-br/library/system.net.sockets.socketexception(v=vs.110).aspx) erros:
- Criando uma nova instância **HttpClient** por solicitação.
- Servidor sob carga pesada.

Criando uma nova instância **HttpClient** por solicitação, podendo esgotar os soquetes disponíveis.

## Instalação
Execute o comando para instalar via [NuGet](https://www.nuget.org/packages/MoipCSharp/):

```xml
PM> Install-Package MoipCSharp -Version 3.0.3
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
#### Verificar se usuário já possui Conta Moip
```C#
var result = await MoipCSharpClient.ContaClassica.VerificarSeUsuarioJaPossuiContaMoip("meu_email@email.com");
```

#### Criar Conta Moip Clássica
```C#
var body = new CriarContaMoipClassicaRequest
{
    //informe os campos aqui
};
var result = await MoipCSharpClient.ContaClassica.CriarContaMoipClassica(body);
```

#### Consultar Conta Moip
```C#
var result = await MoipCSharpClient.ContaClassica.ConsultarContaMoip("MPA-XXXXXXXXXXXX");
```

#### Solicitar Permissões de Acesso ao Usuário
```C#
var result = await MoipCSharpClient.ContaClassica.SolicitarPermissoesAcessoUsuario(/*informe o valor de cada parâmetro*/);
```

#### Gerar Access Token
```C#
var result = await MoipCSharpClient.ContaClassica.GerarAccessToken(/*informe o valor de cada parâmetro*/);
```

#### Atualizar accessToken
```C#
var result = await MoipCSharpClient.ContaClassica.AtualizarAccessToken(/*informe o valor de cada parâmetro*/);
```

#### Obter chave pública de uma Conta Moip
```C#
var result = await MoipCSharpClient.ContaClassica.ObterChavePublicaContaMoip();
```

## Conta Transparente
#### Criar Conta Moip Transparente
```C#
var body = new CriarContaMoipTransparenteRequest
{
    //informe os campos aqui
};
var result = await MoipCSharpClient.ContaTrasparente.CriarContaMoipTransparente(body);
```

## Clientes
#### Criar Cliente
```C#
var body = new ClienteRequest
{
    //informe os campos aqui
};
var result = await MoipCSharpClient.Cliente.CriarCliente(body);
```

#### Adicionar Cartão de Crédito
```C#
var body = new CartaoDeCreditoRequest
{
    //informe os campos aqui
};
var result = await MoipCSharpClient.Cliente.AdicionarCartaoDeCredito(body, "CUS-XXXXXXXXXXXX");
```

#### Atualizar Cliente
```C#
var body = new AtualizarClienteRequest
{
    //informe os campos aqui
};
var result = await MoipCSharpClient.Cliente.AtualizarCliente(body);
```

#### Deletar Cartão de Crédito
```C#
var result = await MoipCSharpClient.Cliente.DeletarCartaoCredito("CRC-XXXXXXXXXXXX");
```

#### Consultar Cliente
```C#
var result = await MoipCSharpClient.Cliente.ConsultarCliente("CUS-XXXXXXXXXXXX");
```

#### Listar Todos os Clientes
```C#
var result = await MoipCSharpClient.Cliente.ListarTodosClientes();
```

## Pedidos
#### Criar Pedido
```C#
var body = new CriarPedidoRequest
{
    //informe os campos aqui
};
var result = await MoipCSharpClient.Pedido.CriarPedido(body);
```

#### Consultar Pedido
```C#
var result = await MoipCSharpClient.Pedido.ConsultarPedido("ORD-XXXXXXXXXXXX");
```

#### Listar Todos os Pedidos - Sem Filtros
```C#
var result = await MoipCSharpClient.Pedido.ListarTodosPedidos();
```

#### Listar Todos os Pedidos - Com Filtros
```C#
string filtros = "q=josesilva&filters=status::in(PAID,WAITING)|paymentMethod::in(CREDIT_CARD,BOLETO)|value::bt(5000,10000)&limit=3&offset=0";
var result = await MoipCSharpClient.Pedido.ListarTodosPedidosFiltros(filtros);
```
 Veja a tabela filtros de busca [aqui](#tabela---filtros-de-busca).
 
 ## Pagamentos
 #### Criar Pagamento
 ```C#
var body = new CriarPagamentoRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.Pagamento.CriarPagamento(body, "ORD-XXXXXXXXXXXX");
```

#### Liberação de Custódia
```C#
var result = await MoipCSharpClient.Pagamento.LiberarCustodia("ECW-XXXXXXXXXXXX");
```

#### Capturar Pagamento Pré-autorizado
```C#
var result = await MoipCSharpClient.Pagamento.CapturarPagamentoPreAutorizado("PAY-XXXXXXXXXXXX");
```

#### Cancelar Pagamento Pré-autorizado
```C#
var result = await MoipCSharpClient.Pagamento.CancelarPagamentoPreAutorizado("PAY-XXXXXXXXXXXX");
```

#### Consultar Pagamento
```C#
var result = await MoipCSharpClient.Pagamento.ConsultarPagamento("PAY-XXXXXXXXXXXX");
```

#### Simular Pagamentos (sandbox)
```C#
var result = await MoipCSharpClient.Pagamento.SimularPagamentos("PAY-XXXXXXXXXXXX", 26500);
```

## Multipedidos
#### Criar Multipedido
```C#
var body = new CriarMultiPedidoRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.MultiPedido.CriarMultiPedido(body);
```

#### Consultar Multipedido
```C#
var result = await MoipCSharpClient.MultiPedido.ConsultarMultiPedido("MOR-XXXXXXXXXXXX");
```

## Multipagamentos
#### Criar Multipagamento
```C#
var body = new CriarMultiPagamentoRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.MultiPagamento.CriarMultiPagamento(body, "MOR-XXXXXXXXXXXX");
```
#### Consultar Multipagamento
```C#
var result = await MoipCSharpClient.MultiPagamento.ConsultarMultiPagamento("MPY-XXXXXXXXXXXX");
```
#### Capturar Multipagamento Pré-autorizado
```C#
var result = await MoipCSharpClient.MultiPagamento.CapturarMultiPagamentoPreAutorizado("MPY-XXXXXXXXXXXX");
```
#### Cancelar Multipagamento Pré-autorizado
```C#
var result = await MoipCSharpClient.MultiPagamento.CancelarMultiPagamentoPreAutorizado("MPY-XXXXXXXXXXXX");
```
#### Liberação de Custódia
```C#
var result = await MoipCSharpClient.MultiPagamento.LiberarCustodia("ECW-XXXXXXXXXXXX");
```

## Notificações
#### Criar Preferência de Notificação para Conta Moip
```C#
var body = new CriarPreferenciaNotificacaoContaMoipRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.Notificacao.CriarPreferenciaNotificacaoContaMoip(body);
```

#### Criar Preferência de Notificação para App
```C#
var body = new CriarPreferenciaNotificacaoAppRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.Notificacao.CriarPreferenciaNotificacaoApp(body, "APP-XXXXXXXXXXXX");
```

#### Consultar Preferência de Notificação
```C#
var result = await MoipCSharpClient.Notificacao.ConsultarPreferenciaNotificacao("NPR-XXXXXXXXXXXX");
```

#### Listar Todas as Preferências de Notificação
```C#
var result = await MoipCSharpClient.Notificacao.ListarTodasPreferenciasNotificacao();
```

#### Remover Preferência de Notificação
```C#
var result = await MoipCSharpClient.Notificacao.RemoverPreferenciaNotificacao("NPR-XXXXXXXXXXXX");
```

#### Consultar Webhook Enviado
```C#
var result = await MoipCSharpClient.Notificacao.ConsultarWebhookEnviado("PAY-XXXXXXXXXXXX"); 
```

#### Listar Todos os Webhooks Enviados
```C#
var result = await MoipCSharpClient.Notificacao.ListarTodosWebhooksEnviados();
```

## Contas Bancárias
#### Criar Conta Bancária
```C#
var body = new CriarContaBancariaRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.ContaBancaria.CriarContaBancaria(body, "MPA-XXXXXXXXXXXX");
```

#### Consultar Conta Bancária
```C#
var result = await MoipCSharpClient.ContaBancaria.ConsultarContaBancaria("BKA-XXXXXXXXXXXX");
```

#### Listar Todas Contas Bancárias
```C#
var result = await MoipCSharpClient.ContaBancaria.ListarTodasContasBancarias("MPA-XXXXXXXXXXXX");
```

#### Deletar Conta Bancária
```C#
var result = await MoipCSharpClient.ContaBancaria.DeletarContaBancaria("BKA-XXXXXXXXXXXX");
```

#### Atualizar Conta Bancária
```C#
var body = new AtualizarContaBancariaRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.ContaBancaria.AtualizarContaBancaria(body, "BKA-XXXXXXXXXXXX");
```

## Saldo Moip
#### Consultar Saldos
```C#
var result = await MoipCSharpClient.SaldoMoip.ConsultarSaldos();
```

## Lançamentos
#### Consultar Lançamento
```C#
var result = await MoipCSharpClient.Lancamento.ConsultarLancamento("ENT-XXXXXXXXXXXX");
```

#### Listar Todos Lançamentos
```C#
var result = await MoipCSharpClient.Lancamento.ListarTodosLancamentos();
```

## Transferências
#### Criar Transferência
```C#
var body = new CriarTransferenciaRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.Transferencia.CriarTransferencia(body);
```

#### Reverter Transferência
```C#
var result = await MoipCSharpClient.Transferencia.ReverterTransferencia("TRA-XXXXXXXXXXXX");
```

#### Consultar Transferência
```C#
var result = await MoipCSharpClient.Transferencia.ConsultarTransferencia("TRA-XXXXXXXXXXXX");
```

#### Listar Todas Transferências
```C#
var result = await MoipCSharpClient.Transferencias.ListarTodasTransferencias();
```

## Reembolsos
#### Reembolsar Pagamento
```C#
var body = new ReembolsarPagamentoRequest
{
    //informe os campos aqui
};            
var result = await Reembolsos.ReembolsarPagamento(body, "PAY-XXXXXXXXXXXX");
```

#### Reembolsar Pedido via Cartão de Crédito
```C#
var body = new ReembolsarPedidoCartaoCreditoRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.Reembolso.ReembolsarPedidoCartaoCredito(body, "ORD-XXXXXXXXXXXX");
```

#### Consultar Reembolso
```C#
var result = await MoipCSharpClient.Reembolso.ConsultarReembolso("REF-XXXXXXXXXXXX");
```

#### Listar Reembolsos do Pagamento
```C#
var result = await MoipCSharpClient.Reembolso.ListarReembolsosPagamento("PAY-XXXXXXXXXXXX");
```

#### Listar Reembolsos do Pedido
```C#
var result = await MoipCSharpClient.Reembolso.ListarReembolsosPedido("ORD-XXXXXXXXXXXX");
```

## Conciliação
#### Obter Arquivo de Vendas
```C#
var result = await MoipCSharpClient.Conciliacao.ObterArquivoVendas("20180829"); // Data no formato YYYYMMDD
```

#### Obter Arquivo Financeiro
```C#
var result = await MoipCSharpClient.Conciliacao.ObterArquivoFinanceiro("2018-08-29"); // Data no formato YYYY-MM-DD
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
