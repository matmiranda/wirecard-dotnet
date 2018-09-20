<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://res.cloudinary.com/https-github-com-matmiranda-moipcsharp/image/upload/v1536852276/moip.png" alt="Moip logo" width=170>
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
PM> Install-Package MoipCSharp -Version 3.1.1
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
var result = await MoipCSharpClient.ContaClassica.ContaExiste("meu_email@email.com");
```

#### Verificar se usuário já possui Conta Moip (documento)
```C#
var result = await MoipCSharpClient.ContaClassica.ContaExiste("123.456.789-01");
```

#### Criar Conta Moip Clássica
```C#
var body = new ContaClassicaRequest
{
    //informe os campos aqui
};
var result = await MoipCSharpClient.ContaClassica.Criar(body);
```

#### Consultar Conta Moip
```C#
var result = await MoipCSharpClient.ContaClassica.Consultar("MPA-XXXXXXXXXXXX");
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
var body = new ContaTransparenteRequest
{
    //informe os campos aqui
};
var result = await MoipCSharpClient.ContaTrasparente.Criar(body);
```

## Clientes
#### Criar Cliente
```C#
var body = new ClienteRequest
{
    //informe os campos aqui
};
var result = await MoipCSharpClient.Cliente.Criar(body);
```

#### Adicionar Cartão de Crédito
```C#
var body = new ClienteRequest
{
    //informe os campos aqui
};
var result = await MoipCSharpClient.Cliente.AdicionarCartaoCredito(body, "CUS-XXXXXXXXXXXX");
```

#### Deletar Cartão de Crédito
```C#
var result = await MoipCSharpClient.Cliente.DeletarCartaoCredito("CRC-XXXXXXXXXXXX");
```

#### Consultar Cliente
```C#
var result = await MoipCSharpClient.Cliente.Consultar("CUS-XXXXXXXXXXXX");
```

#### Listar Todos os Clientes
```C#
var result = await MoipCSharpClient.Cliente.Listar();
```

## Pedidos
#### Criar Pedido
```C#
var body = new CriarPedidoRequest
{
    //informe os campos aqui
};
var result = await MoipCSharpClient.Pedido.Criar(body);
```

#### Consultar Pedido
```C#
var result = await MoipCSharpClient.Pedido.Consultar("ORD-XXXXXXXXXXXX");
```

#### Listar Todos os Pedidos - Sem Filtros
```C#
var result = await MoipCSharpClient.Pedido.Listar();
```

#### Listar Todos os Pedidos - Com Filtros
```C#
string filtros = "q=josesilva&filters=status::in(PAID,WAITING)|paymentMethod::in(CREDIT_CARD,BOLETO)|value::bt(5000,10000)&limit=3&offset=0";
var result = await MoipCSharpClient.Pedido.ListarFiltro(filtros);
```
 Veja a tabela filtros de busca [aqui](#tabela---filtros-de-busca).
 
 ## Pagamentos
 #### Criar Pagamento
 ```C#
var body = new PagamentoRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.Pagamento.Criar(body, "ORD-XXXXXXXXXXXX");
```

#### Liberação de Custódia
```C#
var result = await MoipCSharpClient.Pagamento.LiberarCustodia("ECW-XXXXXXXXXXXX");
```

#### Capturar Pagamento Pré-autorizado
```C#
var result = await MoipCSharpClient.Pagamento.CapturarPreAutorizado("PAY-XXXXXXXXXXXX");
```

#### Cancelar Pagamento Pré-autorizado
```C#
var result = await MoipCSharpClient.Pagamento.CancelarPreAutorizado("PAY-XXXXXXXXXXXX");
```

#### Consultar Pagamento
```C#
var result = await MoipCSharpClient.Pagamento.Consultar("PAY-XXXXXXXXXXXX");
```

#### Simular Pagamentos (sandbox)
```C#
var result = await MoipCSharpClient.Pagamento.Simular("PAY-XXXXXXXXXXXX", 26500);
```

## Multipedidos
#### Criar Multipedido
```C#
var body = new MultiPedidoRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.MultiPedido.Criar(body);
```

#### Consultar Multipedido
```C#
var result = await MoipCSharpClient.MultiPedido.Consultar("MOR-XXXXXXXXXXXX");
```

## Multipagamentos
#### Criar Multipagamento
```C#
var body = new MultiPagamentoRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.MultiPagamento.Criar(body, "MOR-XXXXXXXXXXXX");
```
#### Consultar Multipagamento
```C#
var result = await MoipCSharpClient.MultiPagamento.Consultar("MPY-XXXXXXXXXXXX");
```
#### Capturar Multipagamento Pré-autorizado
```C#
var result = await MoipCSharpClient.MultiPagamento.CapturarPreAutorizado("MPY-XXXXXXXXXXXX");
```
#### Cancelar Multipagamento Pré-autorizado
```C#
var result = await MoipCSharpClient.MultiPagamento.CancelarPreAutorizado("MPY-XXXXXXXXXXXX");
```
#### Liberação de Custódia
```C#
var result = await MoipCSharpClient.MultiPagamento.LiberarCustodia("ECW-XXXXXXXXXXXX");
```

## Notificações
#### Criar Preferência de Notificação para Conta Moip
```C#
var body = new NotificacaoRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.Notificacao.CriarContaMoip(body);
```

#### Criar Preferência de Notificação para App
```C#
var body = new NotificacaoRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.Notificacao.CriarApp(body, "APP-XXXXXXXXXXXX");
```

#### Consultar Preferência de Notificação
```C#
var result = await MoipCSharpClient.Notificacao.Consultar("NPR-XXXXXXXXXXXX");
```

#### Listar Todas as Preferências de Notificação
```C#
var result = await MoipCSharpClient.Notificacao.Listar();
```

#### Remover Preferência de Notificação
```C#
var result = await MoipCSharpClient.Notificacao.Remover("NPR-XXXXXXXXXXXX");
```

#### Consultar Webhook Enviado
```C#
var result = await MoipCSharpClient.Notificacao.ConsultarWebhook("PAY-XXXXXXXXXXXX"); 
```

#### Listar Todos os Webhooks Enviados
```C#
var result = await MoipCSharpClient.Notificacao.ListarWebhooks();
```

## Contas Bancárias
#### Criar Conta Bancária
```C#
var body = new ContaBancariaRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.ContaBancaria.Criar(body, "MPA-XXXXXXXXXXXX");
```

#### Consultar Conta Bancária
```C#
var result = await MoipCSharpClient.ContaBancaria.Consultar("BKA-XXXXXXXXXXXX");
```

#### Listar Todas Contas Bancárias
```C#
var result = await MoipCSharpClient.ContaBancaria.Listar("MPA-XXXXXXXXXXXX");
```

#### Deletar Conta Bancária
```C#
var result = await MoipCSharpClient.ContaBancaria.Deletar("BKA-XXXXXXXXXXXX");
```

#### Atualizar Conta Bancária
```C#
var body = new ContaBancariaRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.ContaBancaria.Atualizar(body, "BKA-XXXXXXXXXXXX");
```

## Saldo Moip
#### Consultar Saldos
```C#
var result = await MoipCSharpClient.Saldo.Consultar();
```

## Lançamentos
#### Consultar Lançamento
```C#
var result = await MoipCSharpClient.Lancamento.Consultar("ENT-XXXXXXXXXXXX");
```

#### Listar Todos Lançamentos
```C#
var result = await MoipCSharpClient.Lancamento.Listar();
```

## Transferências
#### Criar Transferência
```C#
var body = new TransferenciaRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.Transferencia.Criar(body);
```

#### Reverter Transferência
```C#
var result = await MoipCSharpClient.Transferencia.Reverter("TRA-XXXXXXXXXXXX");
```

#### Consultar Transferência
```C#
var result = await MoipCSharpClient.Transferencia.Consultar("TRA-XXXXXXXXXXXX");
```

#### Listar Todas Transferências
```C#
var result = await MoipCSharpClient.Transferencias.Listar();
```

## Reembolsos
#### Reembolsar Pagamento
```C#
var body = new ReembolsarRequest
{
    //informe os campos aqui
};            
var result = await Reembolsos.ReembolsarPagamento(body, "PAY-XXXXXXXXXXXX");
```

#### Reembolsar Pedido via Cartão de Crédito
```C#
var body = new ReembolsarRequest
{
    //informe os campos aqui
};            
var result = await MoipCSharpClient.Reembolso.ReembolsarPedidoCartaoCredito(body, "ORD-XXXXXXXXXXXX");
```

#### Consultar Reembolso
```C#
var result = await MoipCSharpClient.Reembolso.Consultar("REF-XXXXXXXXXXXX");
```

#### Listar Reembolsos do Pagamento
```C#
var result = await MoipCSharpClient.Reembolso.ListarPagamento("PAY-XXXXXXXXXXXX");
```

#### Listar Reembolsos do Pedido
```C#
var result = await MoipCSharpClient.Reembolso.ListarPedido("ORD-XXXXXXXXXXXX");
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
