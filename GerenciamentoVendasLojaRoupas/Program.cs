using System;
using GerenciamentoVendasLojaRoupas.UI;

namespace GerenciamentoVendasLojaRoupas
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Gerenciar Categorias");
                Console.WriteLine("2. Gerenciar Produtos");
                Console.WriteLine("3. Gerenciar Clientes");
                Console.WriteLine("4. Realizar Venda");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CategoriaUI.Menu();
                        break;
                    case 2:
                        ProdutoUI.Menu();
                        break;
                    case 3:
                        ClienteUI.Menu();
                        break;
                    case 4:
                        VendaUI.RealizarVenda();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
