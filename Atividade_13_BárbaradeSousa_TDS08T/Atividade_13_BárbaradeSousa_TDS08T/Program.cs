using System;
using System.Globalization;

namespace Atividade_13_BárbaradeSousa_TDS08T
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("             Programa Eleições Municipais             ");
            Console.Write("Informe o nome do candidato: ");
            string nome = Console.ReadLine();
            Console.Write("Informe o Partido do candidato: ");
            string partido = Console.ReadLine();
            Console.Write("Informe o Patrimômio do candidato: ");
            double patrimonio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe a profissão atual do candidato: ");
            string profissao = Console.ReadLine();
            Console.Write("Informe o Cargo pretendido pelo candidato: ");
            string cargo = Console.ReadLine();


            Candidato c = new Candidato(nome, partido, patrimonio, profissao, cargo);
            Console.WriteLine(c);

        }
    }
}
