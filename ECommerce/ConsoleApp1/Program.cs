using ConsoleApp1.Entidades.Enums;
using ConsoleApp1.Entidades;

//StatusPedido status = StatusPedido.AguardandoPagamento;
//int status1 = (int) StatusPedido.Processando;
//string status2 = StatusPedido.Enviado.ToString();
//StatusPedido status3 = (StatusPedido) 3;
//StatusPedido status4 = Enum.Parse<StatusPedido>("Cancelado");

//Console.WriteLine(status);
//Console.WriteLine($"Codigo do status Processando: {status1}");
//Console.WriteLine($"Status 2: {status2}");
//Console.WriteLine($"Status 3: {status3}");
//Console.WriteLine($"Status 4: {status4}");

//Pedido pedido = new Pedido()
//{
//    Id = 1,
//    DataPedido = DateTime.Now,
//    Valor = 235.8,
//    Status = StatusPedido.AguardandoPagamento,
//    Pagamento = FormaPagamento.CartaoDebito
//};

//Console.WriteLine(pedido);

List<Produto> produtos = new List<Produto>();
List<Cliente> clientes = new List<Cliente>();
List<Pedido> pedidos = new List<Pedido>();

int opcao = 0;

do
{
    Console.WriteLine("1 - Cadastrar Produto");
    Console.WriteLine("2 - Cadastrar Cliente");
    Console.WriteLine("3 - Cadastrar Pedido");
    Console.WriteLine("4 - Listar Produtos");
    Console.WriteLine("5 - Listar Clientes");
    Console.WriteLine("6 - Listar Pedidos");
    Console.WriteLine("7 - Sair");
    Console.Write("Opcao: ");

    opcao = int.Parse(Console.ReadLine());

    Console.Clear();

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Cadastrar Produto");
            Produto produto = new Produto();

            Console.Write("Id: ");
            produto.Id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Valor: ");
            produto.Valor = double.Parse(Console.ReadLine());

            produtos.Add(produto);
            break;

        case 2:
            Console.WriteLine("Cadastrar Cliente");
            Cliente cliente = new Cliente();

            Console.Write("Id: ");
            cliente.Id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Email: ");
            cliente.Email = Console.ReadLine();

            Console.Write("CPF: ");
            cliente.Cpf = Console.ReadLine();

            clientes.Add(cliente);

            break;

        case 3:
            Console.WriteLine("Cadastrar Pedido");
            Pedido pedido = new Pedido();

            Console.Write("Id do Cliente: ");
            int idCliente = int.Parse(Console.ReadLine());

            pedido.Cliente = clientes.Find(cliente => cliente.Id == idCliente);

            Console.Write("Quantos itens irão compor o pedido? ");
            int qtdItens = int.Parse(Console.ReadLine());

            for (int i=0; i<qtdItens; i++)
            {
                ItemPedido item = new ItemPedido();

                Console.Write($"Id do Produto {i + 1}: ");
                int idProduto = int.Parse(Console.ReadLine());

                item.Produto = produtos.Find(produto => produto.Id == idProduto);
                item.Valor = item.Produto.Valor;

                Console.Write($"Quantidade do Produto {i+1}: ");
                item.Quantidade = int.Parse(Console.ReadLine());

                pedido.AdicionarItem(item);
            }

            pedido.DataPedido = DateTime.Now;
            pedido.Status = StatusPedido.AguardandoPagamento;
            pedido.Pagamento = FormaPagamento.CartaoCredito;

            pedidos.Add(pedido);

            break;

        case 4:
            Console.WriteLine("Listar Produtos");

            produtos.ForEach(produto =>
            {
                Console.WriteLine(produto);
            });

            break;

        case 5:
            Console.WriteLine("Listar Clientes");

            clientes.ForEach(cliente =>
            {
                Console.WriteLine(cliente);
            });

            break;

        case 6:
            Console.WriteLine("Listar Pedidos");

            pedidos.ForEach(pedido =>
            {
                Console.WriteLine(pedido);
            });

            break;
    }

    Console.ReadKey();
    Console.Clear();
} while (opcao != 7);