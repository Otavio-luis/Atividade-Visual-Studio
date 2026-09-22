using System;

namespace Exercicio03
{
	public class Funcionario
	{
		public string Nome { get; set; }
		public int Idade { get; set; }
		public string Cargo { get; set; }
		public double Salario { get; set; }
		public string Setor { get; set; }

		public void Apresentar()
		{
			Console.WriteLine("Nome: " + Nome);
			Console.WriteLine("Cargo: " + Cargo);
			Console.WriteLine("Setor: " + Setor);
			Console.WriteLine("Salário: R$ " + Salario.ToString("F2"));
		}

		public double CalcularSalarioAnual()
		{
			return Salario * 12;
		}
	}
}