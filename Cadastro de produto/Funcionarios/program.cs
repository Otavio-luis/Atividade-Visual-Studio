using System;
using System.Collections.Generic;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            int opcao = 0;

            while (opcao != 3)
            {
                Console.Clear();

                Console.WriteLine("===== CADASTRO DE FUNCIONÁRIOS =====");
                Console.WriteLine("1 - Cadastrar funcionário");
                Console.WriteLine("2 - Listar funcionários");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Funcionario funcionario = new Funcionario();

                    Console.Write("Nome: ");
                    funcionario.Nome = Console.ReadLine();

                    Console.Write("Idade: ");
                    funcionario.Idade = int.Parse(Console.ReadLine());

                    Console.Write("Cargo: ");
                    funcionario.Cargo = Console.ReadLine();

                    Console.Write("Salário: ");
                    funcionario.Salario = double.Parse(Console.ReadLine());

                    Console.Write("Setor: ");
                    funcionario.Setor = Console.ReadLine();

                    funcionarios.Add(funcionario);

                    Console.WriteLine("Funcionário cadastrado!");
                    Console.ReadLine();
                }
                else if (opcao == 2)
                {
                    Console.Clear();

                    foreach (Funcionario funcionario in funcionarios)
                    {
                        funcionario.Apresentar();

                        Console.WriteLine("Salário anual: R$ " +
                            funcionario.CalcularSalarioAnual().ToString("F2"));

                        Console.WriteLine("----------------------");
                    }

                    Console.ReadLine();
                }
            }
        }
    }

    public class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public string Setor { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário: R$ {Salario:F2}");
            Console.WriteLine($"Setor: {Setor}");
        }

        public double CalcularSalarioAnual()
        {
            return Salario * 12;
        }
    }
}