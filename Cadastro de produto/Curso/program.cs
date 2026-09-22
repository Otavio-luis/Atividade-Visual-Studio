using System;
using System.Collections.Generic;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Curso> cursos = new List<Curso>();
            int opcao = 0;

            while (opcao != 4)
            {
                Console.Clear();

                Console.WriteLine("===== CADASTRO DE CURSOS =====");
                Console.WriteLine("1 - Cadastrar curso");
                Console.WriteLine("2 - Listar cursos");
                Console.WriteLine("3 - Ver cursos disponíveis");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Curso curso = new Curso();

                    Console.Write("Nome: ");
                    curso.Nome = Console.ReadLine();

                    Console.Write("Carga horária: ");
                    curso.CargaHoraria = int.Parse(Console.ReadLine());

                    Console.Write("Professor: ");
                    curso.Professor = Console.ReadLine();

                    Console.Write("Modalidade: ");
                    curso.Modalidade = Console.ReadLine();

                    Console.Write("Quantidade de vagas: ");
                    curso.QuantidadeVagas = int.Parse(Console.ReadLine());

                    cursos.Add(curso);

                    Console.WriteLine("Curso cadastrado!");
                    Console.ReadLine();
                }
                else if (opcao == 2)
                {
                    Console.Clear();

                    foreach (Curso curso in cursos)
                    {
                        curso.MostrarCurso();
                        Console.WriteLine("----------------------");
                    }

                    Console.ReadLine();
                }
                else if (opcao == 3)
                {
                    Console.Clear();

                    foreach (Curso curso in cursos)
                    {
                        if (curso.QuantidadeVagas > 0)
                        {
                            curso.MostrarCurso();
                            Console.WriteLine("----------------------");
                        }
                    }

                    Console.ReadLine();
                }
            }
        }
    }
}