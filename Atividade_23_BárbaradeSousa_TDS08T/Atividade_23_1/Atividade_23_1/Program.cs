using System;
using System.Globalization;

namespace Atividade_23_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Questão 1
            Console.Write("Entre com o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());
            int resp = 0;
            for(int i = 0; i < n; i ++)
            {
                Console.WriteLine("Funcionário #" + i + " dados: ");
                Console.Write("O funcionário é terceirizado? Digite 1 para sim e 2 para não: ");
                resp = int.Parse(Console.ReadLine());
                if (resp == 1)
                {
                    FuncionarioTerceirizado f = new FuncionarioTerceirizado();
                    Console.Write("Nome: ");
                    f.Nome = Console.ReadLine();
                    Console.Write("Horas Trabalhadas: ");
                    f.HorasTrabalhadas = int.Parse(Console.ReadLine());
                    Console.Write("Valor por Hora: ");
                    f.ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Despesa Adicional: ");
                    f.DespesaAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine(f);
                }
                else if (resp == 2)
                {
                  
                    Funcionario f = new Funcionario();
                    Console.Write("Nome: ");
                    f.Nome = Console.ReadLine();
                    Console.Write("Horas Trabalhadas: ");
                    f.HorasTrabalhadas = int.Parse(Console.ReadLine());
                    Console.Write("Valor por Hora: ");
                    f.ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine(f);
                }
             
            }
            


        }
    }
}
