using System;
using System.Collections.Generic;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            int opcao = 0;

            while (opcao != 4)
            {
                Console.Clear();

                Console.WriteLine("===== CADASTRO DE CLIENTES =====");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar clientes");
                Console.WriteLine("3 - Pesquisar cliente");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Cliente cliente = new Cliente();

                    Console.Write("Nome: ");
                    cliente.Nome = Console.ReadLine();

                    Console.Write("Idade: ");
                    cliente.Idade = int.Parse(Console.ReadLine());

                    Console.Write("Cidade: ");
                    cliente.Cidade = Console.ReadLine();

                    Console.Write("E-mail: ");
                    cliente.Email = Console.ReadLine();

                    Console.Write("Telefone: ");
                    cliente.Telefone = Console.ReadLine();

                    clientes.Add(cliente);

                    Console.WriteLine("Cliente cadastrado!");
                    Console.ReadLine();
                }
                else if (opcao == 2)
                {
                    Console.Clear();

                    foreach (Cliente cliente in clientes)
                    {
                        cliente.ApresentarCliente();
                        Console.WriteLine("----------------------");
                    }

                    Console.ReadLine();
                }
                else if (opcao == 3)
                {
                    Console.Write("Digite o nome do cliente: ");
                    string pesquisa = Console.ReadLine().ToLower();

                    bool encontrado = false;

                    foreach (Cliente cliente in clientes)
                    {
                        if (cliente.Nome.ToLower().Contains(pesquisa))
                        {
                            cliente.ApresentarCliente();
                            Console.WriteLine("----------------------");
                            encontrado = true;
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("Cliente não encontrado.");
                    }

                    Console.ReadLine();
                }
            }
        }
    }
}