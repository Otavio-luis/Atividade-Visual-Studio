using System;
using System.Collections.Generic;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Livro> livros = new List<Livro>();
            int opcao = 0;

            while (opcao != 3)
            {
                Console.Clear();

                Console.WriteLine("===== CADASTRO DE LIVROS =====");
                Console.WriteLine("1 - Cadastrar livro");
                Console.WriteLine("2 - Listar livros");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Livro livro = new Livro();

                    Console.Write("Título: ");
                    livro.Titulo = Console.ReadLine();

                    Console.Write("Autor: ");
                    livro.Autor = Console.ReadLine();

                    Console.Write("Ano: ");
                    livro.Ano = int.Parse(Console.ReadLine());

                    Console.Write("Categoria: ");
                    livro.Categoria = Console.ReadLine();

                    Console.Write("Está disponível? (S/N): ");
                    string resposta = Console.ReadLine();

                    livro.Disponivel = resposta.ToUpper() == "S";

                    livros.Add(livro);

                    Console.WriteLine("Livro cadastrado!");
                    Console.ReadLine();
                }
                else if (opcao == 2)
                {
                    Console.Clear();

                    if (livros.Count == 0)
                    {
                        Console.WriteLine("Nenhum livro cadastrado.");
                    }

                    foreach (Livro livro in livros)
                    {
                        livro.MostrarLivro();
                        Console.WriteLine("----------------------");
                    }

                    Console.ReadLine();
                }
            }
        }
    }
}