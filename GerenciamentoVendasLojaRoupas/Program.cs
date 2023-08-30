using System;
using GerenciamentoVendasLojaRoupas.UI;

namespace GerenciamentoVendasLojaRoupas
{
    class Program
    {
        static void Main(string[] args)
        {

            CategoriaUI categoriaUI = new CategoriaUI ();
            ProdutoUI produtoUI = new ProdutoUI ();
            ClienteUI clienteUI = new ClienteUI ();
            VendaUI vendaUI = new VendaUI ();

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Gerenciamento de categorias");
                Console.WriteLine("2 - Gerenciamento de produtos");
                Console.WriteLine("3 - Gerenciamento de clientes");
                Console.WriteLine("4 - Realizar vendas");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
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
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }

        static void GerenciamentoCategoria( CategoriaUI categoriaUI)
        {
            Console.WriteLine ("Selecione a opção desejada:");
            Console.WriteLine ("1 - Registrar categoria");
            Console.WriteLine ("2 - Alterar categoria");
            Console.WriteLine ("3 - Buscar por todas as categorias");
            Console.WriteLine ("4 - Buscar categoria atraves do ID");
            Console.WriteLine ("5 - Remover categoria");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Nome da categoria: ");
                    string nomeCategoria = Console.ReadLine();
                    Console.Write("Descrição da categoria: ");
                    string descricaoCategoria = Console.ReadLine();

                    categoriaUI.RegistrarCategoria(nomeCategoria, descricaoCategoria);
                    Console.WriteLine("Categoria registrada.");
                    break;
                case 2:
                    Console.Write("ID da categoria a ser modificada: ");
                    int idCategoriaAlterar = int.Parse(Console.ReadLine());

                    Categoria CategoriaAlterar = categoriaUI.BuscarCategoriaId(idCategoriaAlterar);
                    if (CategoriaAlterar != null)
                    {
                        Console.Write("Novo nome da categoria: ");
                        string novoNomeCategoria = Console.ReadLine();
                        Console.Write("Nova descrição da categoria: ");
                        string novaDescricaoCategoria = Console.ReadLine();

                        categoriaUI.AlterarCategoria(idCategoriaAlterar, novoNomeCategoria, novaDescricaoCategoria);
                        Console.WriteLine("Categoria alterada.");
                    }
                    else
                    {
                        Console.WriteLine("Categoria desconhecida.");
                    }
                    break;
                case 3:
                    List<Categoria> todasCategorias = categoriaUI.BuscarTodasCategorias();
                    foreach (Categoria categoria in todasCategorias)
                    {
                        Console.WriteLine($"ID: {categoria.Id}, Nome: {categoria.Nome}, Descrição: {categoria.Descricao}");
                    }   
                    break;
                case 4:
                    Console.Write("ID da categoria que deseja buscar: ");
                    int idCategoriaBuscar = int.Parse(Console.ReadLine());

                    Categoria categoriaBuscar = categoriaUI.BuscarCategoriaId(idCategoriaBuscar);
                    if (categoriaBuscar != null)
                    {
                        Console.WriteLine($"ID: {categoriaBuscar.Id}, Nome: {categoriaBuscar.Nome}, Descricao: {categoriaBuscar.Descricao}");
                    }
                    else
                    {
                        Console.WriteLine("Categoria não encontrada.");
                    }
                    break;
                case 5:
                    Console.Write("Informe o ID da categoria que deseja excluir: ");
                    int idCategoriaRemover = int.Parse(Console.ReadLine());

                    categoriaUI.RemoverCategoria(idCategoriaRemover);
                    Console.WriteLine("Categoria removida.");
                    break;
                    
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
