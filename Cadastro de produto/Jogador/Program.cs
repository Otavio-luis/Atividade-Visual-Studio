using System;
using System.Collections.Generic;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jogador> jogadores = new List<Jogador>();

            int opcao = 0;

            while (opcao != 5)
            {
                Console.Clear();

                Console.WriteLine("================================");
                Console.WriteLine("      CADASTRO DE JOGADORES");
                Console.WriteLine("================================");
                Console.WriteLine("1 - Cadastrar jogador");
                Console.WriteLine("2 - Listar jogadores");
                Console.WriteLine("3 - Pesquisar jogador");
                Console.WriteLine("4 - Jogadores com mais de 10 gols");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Jogador jogador = new Jogador();

                    Console.Write("Nome: ");
                    jogador.Nome = Console.ReadLine();

                    Console.Write("Idade: ");
                    jogador.Idade = int.Parse(Console.ReadLine());

                    Console.Write("Posição: ");
                    jogador.Posicao = Console.ReadLine();

                    Console.Write("Time: ");
                    jogador.Time = Console.ReadLine();

                    Console.Write("Número da camisa: ");
                    jogador.NumeroCamisa = int.Parse(Console.ReadLine());

                    Console.Write("Quantidade de gols: ");
                    jogador.Gols = int.Parse(Console.ReadLine());

                    jogadores.Add(jogador);

                    Console.WriteLine();
                    Console.WriteLine("Jogador cadastrado com sucesso!");
                    Console.ReadLine();
                }
                else if (opcao == 2)
                {
                    Console.Clear();

                    Console.WriteLine("===== JOGADORES CADASTRADOS =====");

                    if (jogadores.Count == 0)
                    {
                        Console.WriteLine("Nenhum jogador cadastrado.");
                    }

                    foreach (Jogador jogador in jogadores)
                    {
                        jogador.MostrarJogador();
                        Console.WriteLine("----------------------");
                    }

                    Console.ReadLine();
                }
                else if (opcao == 3)
                {
                    Console.Write("Digite o nome do jogador: ");
                    string pesquisa = Console.ReadLine().ToLower();

                    bool encontrado = false;

                    foreach (Jogador jogador in jogadores)
                    {
                        if (jogador.Nome.ToLower().Contains(pesquisa))
                        {
                            jogador.MostrarJogador();
                            Console.WriteLine("----------------------");
                            encontrado = true;
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("Jogador não encontrado.");
                    }

                    Console.ReadLine();
                }
                else if (opcao == 4)
                {
                    Console.Clear();

                    Console.WriteLine("===== JOGADORES COM MAIS DE 10 GOLS =====");

                    bool encontrado = false;

                    foreach (Jogador jogador in jogadores)
                    {
                        if (jogador.Gols > 10)
                        {
                            jogador.MostrarJogador();
                            Console.WriteLine("----------------------");
                            encontrado = true;
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("Nenhum jogador com mais de 10 gols.");
                    }

                    Console.ReadLine();
                }
            }

            Console.WriteLine("Programa encerrado.");
        }
    }
}