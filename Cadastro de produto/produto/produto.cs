using System;

namespace cadastro_de_produto.produto
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public void MostrarProduto()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Categoria: " + Categoria);
            Console.WriteLine("Preço: R$ " + Preco.ToString("F2"));
            Console.WriteLine("Quantidade: " + Quantidade);
            Console.WriteLine("Valor total em estoque: R$ " +
                              (Preco * Quantidade).ToString("F2"));
        }
    }
}