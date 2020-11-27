using System;

namespace Atividade_de_Fixação_BárbaradeSousa_TDS08T
{
    class Program
    {
        static void Main(string[] args)
        {

            // Questão 1 
            Console.WriteLine("               PROGRAMA QUE LÊ 6 VALORES INTEIROS E MOSTRA OS VALORES LIDOS ");
            Console.WriteLine();


            int[] numeros = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Informe o valor do " + i + "° número inteiro: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------------------===========================------------------------");

            //  Questão 2 
            Console.WriteLine("             PROGRAMA QUE LÊ 6 NOMES E MOSTRA NA TELA OS VALORES LIDOS ");
            Console.WriteLine();

            string[] nomes = new string[6];
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Informe o " + i + "° nome: ");
                nomes[i] = Console.ReadLine();
            }
            foreach (string i in nomes)
            {
                Console.WriteLine(i);
            }
        }
    }
}
