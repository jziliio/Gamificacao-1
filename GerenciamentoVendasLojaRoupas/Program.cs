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
            Console.WriteLine ("Selecione uma opção:");
            Console.WriteLine ("1 - Registrar categoria");
            Console.WriteLine ("2 - Alterar categoria");
            Console.WriteLine ("3 - Buscar por todas as categorias");
            Console.WriteLine ("4 - Buscar categoria atraves do ID");
            Console.WriteLine ("5 - Remover categoria")

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
                        Console.WriteLine("Categoria alterada.")
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
                    Console.Write("Informe o ID da categoria que deseja buscar: ");
                    int idCategoriaBuscar = int.Parse(Console.ReadLine());

                    Categoria categoriaBuscar = categoriaUI.BuscarCategoriaId(idCategoriaBuscar);
                    if (categoriaBuscar != null)
                    {
                        Console.WriteLine($"ID: {categoriaBuscar.Id}, Nome: {categoriaBuscar.Nome}, Descricao: {categoriaBuscar.Descricao}");
                    }
                    else
                    {
                        Console.WriteLine("Categoria não encontrada.")
                    }
                    break;
                case 5:
                    Console.Write("Informe o ID da categoria que deseja excluir: ");
                    int idCategoriaRemover = int.Parse(Console.ReadLine());

                    categoriaUI.RemoverCategoria(idCategoriaRemover);
                    Console.WriteLine("Categoria removida.");
                    break;
                    
                default:
                    Console.WriteLine("Opção inválida.")
                    break;
            }
        }

        static void GerenciamentoProdutos(ProdutoUI produtoUI)
        {
            Console.WriteLine("Seleciona uma opção:");
            Console.WriteLine("1 - Registrar Produto");
            Console.WriteLine("2 - Alterar Produto");
            Console.WriteLine("3 - Buscar Todos os Produtos");
            Console.WriteLine("4 - Buscar Produto por ID");
            Console.WriteLine("5 - Remover Produto");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Nome do Produto: ");
                    string nomeProduto = Console.ReadLine();
                    Console.Write("Descrição do Produto: ");
                    string descricaoProduto = Console.ReadLine();
                    Console.Write("Preço do Produto: ");
                    decimal precoProduto = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Categorias disponíveis:");
                    List<Categoria> categorias = categoriaUI.BuscarTodasCategorias();
                    foreach (Categoria categoria in categorias)
                    {
                        Console.WriteLine($"ID: {categoria.Id}, Nome: {categoria.Nome}");
                    }  

                    Console.Write("ID da Categoria do Produto: ");
                    int idCategoriaProduto = int.Parse(Console.ReadLine());

                    Categoria categoriaProduto = categorias.Find(c => c.Id == idCategoriaProduto);
                    if (categoriaProduto == null)
                    {
                        Console.WriteLine("Categoria não encontrada.");
                        break;
                    }

                    produtoUI.RegistrarProduto(nomeProduto, descricaoProduto, precoProduto, categoriaProduto);
                    Console.WriteLine("Produto registrado com sucesso!");
                    break;
                case 2:
                    Console.Write("ID do Produto a ser alterado: ");
                    int idProdutoAlterar = int.Parse(Console.ReadLine());

                    Produto produtoAlterar = produtoUI.BuscarProdutoId(idProdutoAlterar);
                    if (produtoAlterar != null)
                    {
                        Console.Write("Novo Nome do Produto: ");
                        string novoNomeProduto = Console.ReadLine();
                        Console.Write("Nova Descrição do Produto: ");
                        string novaDescricaoProduto = Console.ReadLine();
                        Console.Write("Novo Preço do Produto: ");
                        decimal novoPrecoProduto = decimal.Parse(Console.ReadLine());
    
                        Console.WriteLine("Categorias disponíveis:");
                        List<Categoria> categorias = categoriaUI.BuscarTodasCategorias();
                        foreach (Categoria categoria in categorias)
                        {
                            Console.WriteLine($"ID: {categoria.Id}, Nome: {categoria.Nome}");
                        }

                        Console.Write("Informe o ID da nova categoria do produto: ");
                        int idNovaCategoriaProduto = int.Parse(Console.ReadLine());

                        Categoria novaCategoriaProduto = categorias.Find(c => c.Id == idNovaCategoriaProduto);
                        if (novaCategoriaProduto == null)
                        {
                            Console.WriteLine("Nova Categoria não encontrada.");
                            break;
                        }

                        produtoUI.AlterarProduto(idProdutoAlterar, novoNomeProduto, novaDescricaoProduto, novoPrecoProduto, novaCategoriaProduto);
                        Console.WriteLine("Produto alterado.");
                    }
                    else
                    {
                        Console.WriteLine("Produto não encontrado.");
                    }
                    break;
                case 3:
                    List<Produto> todosProdutos = produtoUI.BuscarTodosProdutos();
                    if (todosProdutos.Count > 0)
                    {
                        Console.WriteLine("Lista de Todos os Produtos:");
                        foreach (Produto produto in todosProdutos)
                        {
                            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Preco}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhum produto foi encontrado.");
                    }
                    break;
                case 4: 
                    Console.Write("Informe o ID do produto que deseja buscar: ");
                    int idProdutoBuscar = int.Parse(Console.ReadLine());

                    Produto produtoBuscar = produtoUI.BuscarProdutoPorId(idProdutoBuscar);
                    if (produtoBuscar != null)
                    {
                        Console.WriteLine($"Produto Encontrado:");
                        Console.WriteLine($"ID: {produtoBuscar.Id}, Nome: {produtoBuscar.Nome}, Descrição: {produtoBuscar.Descricao}, Preço: {produtoBuscar.Preco}");
                    }
                    else
                    {
                        Console.WriteLine("Produto não encontrado.");
                    }
                    break;
                case 5:
                    Console.Write("Informe o ID do Produto que será removido: ");
                    int idProdutoRemover = int.Parse(Console.ReadLine());

                    produtoUI.RemoverProduto(idProdutoRemover);
                    Console.WriteLine("Produto removido.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }        
}