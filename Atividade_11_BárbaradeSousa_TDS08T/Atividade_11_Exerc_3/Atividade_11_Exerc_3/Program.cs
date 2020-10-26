using System;
using System.Globalization;

namespace Atividade_11_Exerc_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a;
            a = new Aluno();
            Console.WriteLine("Digite o nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas do aluno: ");
            a.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double situacao = a.Soma();

            Console.WriteLine("NOTA FINAL: " + situacao.ToString("F2", CultureInfo.InvariantCulture));

            if (situacao > 60)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

            
        }
    }
}
