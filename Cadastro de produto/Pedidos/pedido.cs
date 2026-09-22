using System;

namespace Exercicio08
{
    public class Pedido
    {
        public int Numero { get; set; }
        public string Cliente { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }

        public double CalcularTotal()
        {
            return Quantidade * ValorUnitario;
        }

        public void MostrarPedido()
        {
            Console.WriteLine("Pedido: " + Numero);
            Console.WriteLine("Cliente: " + Cliente);
            Console.WriteLine("Produto: " + Produto);
            Console.WriteLine("Quantidade: " + Quantidade);
            Console.WriteLine("Valor unitário: R$ " +
                              ValorUnitario.ToString("F2"));
            Console.WriteLine("Total: R$ " +
                              CalcularTotal().ToString("F2"));
        }
    }
}