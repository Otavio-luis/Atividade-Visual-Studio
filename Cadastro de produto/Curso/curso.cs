using System;

namespace Exercicio07
{
    public class Curso
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public string Professor { get; set; }
        public string Modalidade { get; set; }
        public int QuantidadeVagas { get; set; }

        public void MostrarCurso()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Carga horária: " + CargaHoraria + " horas");
            Console.WriteLine("Professor: " + Professor);
            Console.WriteLine("Modalidade: " + Modalidade);
            Console.WriteLine("Vagas disponíveis: " + QuantidadeVagas);
        }
    }
}