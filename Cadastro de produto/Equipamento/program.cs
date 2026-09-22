using System;
using System.Collections.Generic;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipamento> equipamentos = new List<Equipamento>();
            int opcao = 0;

            while (opcao != 5)
            {
                Console.Clear();

                Console.WriteLine("===== CADASTRO DE EQUIPAMENTOS =====");
                Console.WriteLine("1 - Cadastrar equipamento");
                Console.WriteLine("2 - Listar equipamentos");
                Console.WriteLine("3 - Pesquisar equipamento");
                Console.WriteLine("4 - Equipamentos em manutenção");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Equipamento equipamento = new Equipamento();

                    Console.Write("Patrimônio: ");
                    equipamento.Patrimonio = Console.ReadLine();

                    Console.Write("Tipo: ");
                    equipamento.Tipo = Console.ReadLine();

                    Console.Write("Marca: ");
                    equipamento.Marca = Console.ReadLine();

                    Console.Write("Modelo: ");
                    equipamento.Modelo = Console.ReadLine();

                    Console.Write("Número de série: ");
                    equipamento.NumeroSerie = Console.ReadLine();

                    Console.Write("Status: ");
                    equipamento.Status = Console.ReadLine();

                    equipamentos.Add(equipamento);

                    Console.WriteLine("Equipamento cadastrado!");
                    Console.ReadLine();
                }
                else if (opcao == 2)
                {
                    Console.Clear();

                    foreach (Equipamento equipamento in equipamentos)
                    {
                        equipamento.MostrarEquipamento();
                        Console.WriteLine("----------------------");
                    }

                    Console.ReadLine();
                }
                else if (opcao == 3)
                {
                    Console.Write("Digite o patrimônio ou modelo: ");
                    string pesquisa = Console.ReadLine().ToLower();

                    bool encontrado = false;

                    foreach (Equipamento equipamento in equipamentos)
                    {
                        if (equipamento.Patrimonio.ToLower().Contains(pesquisa) ||
                            equipamento.Modelo.ToLower().Contains(pesquisa))
                        {
                            equipamento.MostrarEquipamento();
                            Console.WriteLine("----------------------");
                            encontrado = true;
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("Equipamento não encontrado.");
                    }

                    Console.ReadLine();
                }
                else if (opcao == 4)
                {
                    Console.Clear();

                    foreach (Equipamento equipamento in equipamentos)
                    {
                        if (equipamento.Status.ToLower() == "manutenção")
                        {
                            equipamento.MostrarEquipamento();
                            Console.WriteLine("----------------------");
                        }
                    }

                    Console.ReadLine();
                }
            }
        }
    }
}