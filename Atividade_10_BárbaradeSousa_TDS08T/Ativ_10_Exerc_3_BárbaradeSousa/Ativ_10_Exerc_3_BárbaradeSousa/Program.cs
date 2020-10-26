using System;
using System.Globalization;

namespace Ativ_10_Exerc_3_BárbaradeSousa
{
    class Program
    {
        static void Main(string[] args)
        {
            Media M;
            M = new Media();
             

            Console.WriteLine("                  DADOS DO PRIMEIRO FUNCIONARIO");
            Console.WriteLine("");
            Console.Write("Digite o nome do primeiro funcionario(A): ");
            string Nome1 = Console.ReadLine();
            Console.WriteLine("Nome: " + Nome1);
            Console.WriteLine();
            Console.Write("Digite o valor do salário do primeiro funcionário(A): ");
            M.Salario1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Salário: " + M.Salario1);

            Console.WriteLine();

            Console.WriteLine("                  DADOS DO SEGUNDO FUNCIONARIO");
            Console.WriteLine("");
            Console.Write("Digite o nome do segundo funcionario(A): ");
            string Nome2 = Console.ReadLine();
            Console.WriteLine("Nome: " + Nome2);
            Console.WriteLine();
            Console.Write("Digite o valor do salário do segundo funcionário(A): ");
            M.Salario2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Salário: " + M.Salario2);
            double resultado = M.resultado();

            Console.WriteLine($"A média dos salários de {Nome1} e {Nome2} é igual a {resultado.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
