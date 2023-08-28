using System;
using System.Collections.Generic;

namespace GerenciamentoVendasLojaRoupas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Produto> produtos = new List<Produto>();

            CategoriaUI categoriaUI = new CategoriaUI();
            ProdutoUI produtoUI = new ProdutoUI();
            ClienteUI clienteUI = new ClienteUI();
            VendaUI vendaUI = new VendaUI(clientes, produtos);

            while (true)
            {
                Console.WriteLine("Menu Principal:");
                Console.WriteLine("1 - Categorias");
                Console.WriteLine("2 - Produtos");
                Console.WriteLine("3 - Clientes");
                Console.WriteLine("4 - Vendas");
                Console.WriteLine("5 - Sair");
                Console.Write("Digite a opção desejada: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        // Menu Categorias
                        while (true)
                        {
                            Console.WriteLine("Menu Categorias:");
                            Console.WriteLine("1 - Registrar Categoria");
                            Console.WriteLine("2 - Alterar Categoria");
                            Console.WriteLine("3 - Buscar Todas Categorias");
                            Console.WriteLine("4 - Buscar Categoria por Nome");
                            Console.WriteLine("5 - Remover Categoria");
                            Console.WriteLine("6 - Voltar");
                            Console.Write("Digite a opção desejada: ");
                            int opcaoCategoria = int.Parse(Console.ReadLine());

                            switch (opcaoCategoria)
                            {
                                case 1:
                                    categoriaUI.RegistrarCategoria();
                                    break;
                                case 2:
                                    categoriaUI.AlterarCategoria();
                                    break;
                                case 3:
                                    categoriaUI.BuscarTodasCategorias();
                                    break;
                                case 4:
                                    categoriaUI.BuscarCategoriaPorNome();
                                    break;
                                case 5:
                                    categoriaUI.RemoverCategoria();
                                    break;
                                case 6:
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;
                            }

                            if (opcaoCategoria == 6)
                                break;
                        }
                        break;
                    case 2:
                        // Menu Produtos
                        while (true)
                        {
                            Console.WriteLine("Menu Produtos:");
                            Console.WriteLine("1 - Registrar Produto");
                            Console.WriteLine("2 - Alterar Produto");
                            Console.WriteLine("3 - Buscar Todos Produtos");
                            Console.WriteLine("4 - Buscar Produto por Nome");
                            Console.WriteLine("5 - Remover Produto");
                            Console.WriteLine("6 - Voltar");
                            Console.Write("Digite a opção desejada: ");
                            int opcaoProduto = int.Parse(Console.ReadLine());

                            switch (opcaoProduto)
                            {
                                case 1:
                                    produtoUI.RegistrarProduto();
                                    break;
                                case 2:
                                    produtoUI.AlterarProduto();
                                    break;
                                case 3:
                                    produtoUI.BuscarTodosProdutos();
                                    break;
                                case 4:
                                    produtoUI.BuscarProdutoPorNome();
                                    break;
                                case 5:
                                    produtoUI.RemoverProduto();
                                    break;
                                case 6:
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;
                            }

                            if (opcaoProduto == 6)
                                break;
                        }
                        break;
                    case 3:
                        // Menu Clientes
                        while (true)
                        {
                            Console.WriteLine("Menu Clientes:");
                            Console.WriteLine("1 - Registrar Cliente");
                            switch (opcaoCliente)
                            {
                                case 1:
                                    clienteUI.RegistrarCliente();
                                    break;
                                case 2:
                                    clienteUI.AlterarCliente();
                                    break;
                                case 3:
                                    clienteUI.BuscarTodosClientes();
                                    break;
                                case 4:
                                    clienteUI.BuscarClientePorNome();
                                    break;
                                case 5:
                                    clienteUI.RemoverCliente();
                                    break;
                                case 6:
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;
                            }

                            if (opcaoCliente == 6)
                                break;
                        }
                        break;
                    case 4:
                        // Menu Vendas
                        while (true)
                        {
                            Console.WriteLine("Menu Vendas:");
                            Console.WriteLine("1 - Registrar Venda");
                            Console.WriteLine("2 - Buscar Todas Vendas");
                            Console.WriteLine("3 - Voltar");
                            Console.Write("Digite a opção desejada: ");
                            int opcaoVenda = int.Parse(Console.ReadLine());

                            switch (opcaoVenda)
                            {
                                case 1:
                                    vendaUI.RegistrarVenda();
                                    break;
                                case 2:
                                    vendaUI.BuscarTodasVendas();
                                    break;
                                case 3:
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;
                            }

                            if (opcaoVenda == 3)
                                break;
                        }
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
