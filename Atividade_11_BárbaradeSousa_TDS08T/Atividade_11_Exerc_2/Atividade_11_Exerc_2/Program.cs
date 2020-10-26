using System;
using System.Globalization;

namespace Atividade_11_Exerc_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f;
            f = new Funcionario();
            Console.WriteLine("Informe o nome do funcionário: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Informe o salário bruto do funcionário: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o imposto do funcionário: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double sl = f.SalarioLiquido();
            Console.WriteLine("Funcionário: " + f.Nome + ", " +  sl.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            f.AumentarSalario(porcentagem);
            Console.WriteLine("Dados Atualizados: " + f.Nome + ", " + f.SalarioBruto);

            
        }
    }
}
