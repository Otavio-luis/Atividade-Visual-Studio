using System;
using System.Collections.Generic;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Filme> filmes = new List<Filme>();
            int opcao = 0;

            while (opcao != 3)
            {
                Console.Clear();

                Console.WriteLine("===== CADASTRO DE FILMES =====");
                Console.WriteLine("1 - Cadastrar filme");
                Console.WriteLine("2 - Listar filmes");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Filme filme = new Filme();

                    Console.Write("Título: ");
                    filme.Titulo = Console.ReadLine();

                    Console.Write("Gênero: ");
                    filme.Genero = Console.ReadLine();

                    Console.Write("Ano: ");
                    filme.Ano = int.Parse(Console.ReadLine());

                    Console.Write("Duração em minutos: ");
                    filme.Duracao = int.Parse(Console.ReadLine());

                    Console.Write("Nota: ");
                    filme.Nota = double.Parse(Console.ReadLine());

                    filmes.Add(filme);

                    Console.WriteLine("Filme cadastrado!");
                    Console.ReadLine();
                }
                else if (opcao == 2)
                {
                    Console.Clear();

                    foreach (Filme filme in filmes)
                    {
                        filme.ExibirInformacoes();
                        Console.WriteLine("----------------------");
                    }

                    Console.ReadLine();
                }
            }
        }
    }
}