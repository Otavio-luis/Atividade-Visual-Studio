using System;
using System.Collections.Generic;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            int opcao = 0;

            while (opcao != 4)
            {
                Console.Clear();

                Console.WriteLine("===== CADASTRO DE VEÍCULOS =====");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Listar veículos");
                Console.WriteLine("3 - Pesquisar veículo");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Veiculo veiculo = new Veiculo();

                    Console.Write("Marca: ");
                    veiculo.Marca = Console.ReadLine();

                    Console.Write("Modelo: ");
                    veiculo.Modelo = Console.ReadLine();

                    Console.Write("Ano: ");
                    veiculo.Ano = int.Parse(Console.ReadLine());

                    Console.Write("Cor: ");
                    veiculo.Cor = Console.ReadLine();

                    Console.Write("Placa: ");
                    veiculo.Placa = Console.ReadLine();

                    veiculos.Add(veiculo);

                    Console.WriteLine("Veículo cadastrado!");
                    Console.ReadLine();
                }
                else if (opcao == 2)
                {
                    Console.Clear();

                    foreach (Veiculo veiculo in veiculos)
                    {
                        veiculo.MostrarVeiculo();
                        Console.WriteLine("----------------------");
                    }

                    Console.ReadLine();
                }
                else if (opcao == 3)
                {
                    Console.Write("Digite a marca ou modelo: ");
                    string pesquisa = Console.ReadLine().ToLower();

                    bool encontrado = false;

                    foreach (Veiculo veiculo in veiculos)
                    {
                        if (veiculo.Marca.ToLower().Contains(pesquisa) ||
                            veiculo.Modelo.ToLower().Contains(pesquisa))
                        {
                            veiculo.MostrarVeiculo();
                            Console.WriteLine("----------------------");
                            encontrado = true;
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("Veículo não encontrado.");
                    }

                    Console.ReadLine();
                }
            }
        }
    }
}