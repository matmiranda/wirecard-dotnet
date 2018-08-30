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
- [Instalação]()
- [Autenticando e configurando o ambiente]()
- [Conta Clássica]()
- [Conta Transparente]()
- [Clientes]()
- [Pedidos]()
- [Pagamentos]()
- [Multipedidos]()
- [Multipagamentos]()
- [Notificações]()
- [Contas Bancárias]()
- [Saldo Moip]()
- [Lançamentos]()
- [Transferências]()
- [Reembolsos]()
- [Conciliação]()
- [Tabela - Filtros de busca]()
- [Licença]()

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
 Veja a tabela filtros de busca [aqui]().
 
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
CSharpando...
```

## Licença

[The MIT License](https://github.com/matmiranda/MoipCSharp/blob/master/LICENSE)

Tem dúvidas? Fale com a gente no [Slack](https://slackin-cqtchmfquq.now.sh/)!
Algum problema ? Abre issues!
