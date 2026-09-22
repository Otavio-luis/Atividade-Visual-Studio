using System;
using System.Collections.Generic;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pedido> pedidos = new List<Pedido>();
            int opcao = 0;

            while (opcao != 3)
            {
                Console.Clear();

                Console.WriteLine("===== CADASTRO DE PEDIDOS =====");
                Console.WriteLine("1 - Cadastrar pedido");
                Console.WriteLine("2 - Listar pedidos");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Pedido pedido = new Pedido();

                    Console.Write("Número do pedido: ");
                    pedido.Numero = int.Parse(Console.ReadLine());

                    Console.Write("Cliente: ");
                    pedido.Cliente = Console.ReadLine();

                    Console.Write("Produto: ");
                    pedido.Produto = Console.ReadLine();

                    Console.Write("Quantidade: ");
                    pedido.Quantidade = int.Parse(Console.ReadLine());

                    Console.Write("Valor unitário: ");
                    pedido.ValorUnitario = double.Parse(Console.ReadLine());

                    pedidos.Add(pedido);

                    Console.WriteLine("Pedido cadastrado!");
                    Console.ReadLine();
                }
                else if (opcao == 2)
                {
                    Console.Clear();

                    foreach (Pedido pedido in pedidos)
                    {
                        pedido.MostrarPedido();
                        Console.WriteLine("----------------------");
                    }

                    Console.ReadLine();
                }
            }
        }
    }
}