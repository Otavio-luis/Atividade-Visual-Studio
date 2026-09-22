using System;

namespace Exercicio09
{
    public class Equipamento
    {
        public string Patrimonio { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NumeroSerie { get; set; }
        public string Status { get; set; }

        public void MostrarEquipamento()
        {
            Console.WriteLine("Patrimônio: " + Patrimonio);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Número de série: " + NumeroSerie);
            Console.WriteLine("Status: " + Status);
        }
    }
}