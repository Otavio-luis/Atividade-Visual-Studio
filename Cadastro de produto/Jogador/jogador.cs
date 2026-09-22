using System;

namespace Exercicio10
{
    public class Jogador
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Posicao { get; set; }
        public string Time { get; set; }
        public int NumeroCamisa { get; set; }
        public int Gols { get; set; }

        public void MostrarJogador()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Posição: " + Posicao);
            Console.WriteLine("Time: " + Time);
            Console.WriteLine("Número da camisa: " + NumeroCamisa);
            Console.WriteLine("Gols: " + Gols);
        }
    }
}