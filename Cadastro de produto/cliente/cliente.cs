using System;

namespace Exercicio06
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public void ApresentarCliente()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("E-mail: " + Email);
            Console.WriteLine("Telefone: " + Telefone);
        }
    }
}