using System;

namespace Exercicio05
{
    public class Filme
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Ano { get; set; }
        public int Duracao { get; set; }
        public double Nota { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Gênero: " + Genero);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Duração: " + Duracao + " minutos");
            Console.WriteLine("Nota: " + Nota);

            if (Nota >= 8)
            {
                Console.WriteLine("Nota maior ou igual a 8!");
            }
        }
    }
}