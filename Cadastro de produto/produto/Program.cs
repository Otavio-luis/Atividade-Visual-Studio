using System;
using System.Collections.Generic;

namespace cadastro_de_produto.produto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            int opcao = 0;

            while (opcao != 3)
            {
                Console.Clear();

                Console.WriteLine("================================");
                Console.WriteLine("       CADASTRO DE PRODUTOS");
                Console.WriteLine("================================");
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Listar produtos");
                Console.WriteLine("3 - Sair");
                Console.Write("Digite uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Produto produto = new Produto();

                    Console.WriteLine();
                    Console.WriteLine("=== NOVO PRODUTO ===");

                    Console.Write("Nome: ");
                    produto.Nome = Console.ReadLine();

                    Console.Write("Categoria: ");
                    produto.Categoria = Console.ReadLine();

                    Console.Write("Preço: ");
                    produto.Preco = double.Parse(Console.ReadLine());

                    Console.Write("Quantidade: ");
                    produto.Quantidade = int.Parse(Console.ReadLine());

                    produtos.Add(produto);

                    Console.WriteLine();
                    Console.WriteLine("Produto cadastrado com sucesso!");
                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ReadLine();
                }
                else if (opcao == 2)
                {
                    Console.Clear();

                    Console.WriteLine("================================");
                    Console.WriteLine("       PRODUTOS CADASTRADOS");
                    Console.WriteLine("================================");

                    if (produtos.Count == 0)
                    {
                        Console.WriteLine("Nenhum produto cadastrado.");
                    }
                    else
                    {
                        foreach (Produto produto in produtos)
                        {
                            Console.WriteLine();

                            produto.MostrarProduto();

                            Console.WriteLine("-------------------------------");
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para voltar...");
                    Console.ReadLine();
                }
                else if (opcao != 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ReadLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Programa encerrado.");
        }
    }
}