using System;

namespace Atividade_19_BárbaradeSousa_TDS08T
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                        PROGRAMA DE ALGUÉL DE UM PENSIONATO ");
            Console.WriteLine();
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            // O tipo do vetor vai ser o nome da classe
            Estudante[] cliente = new Estudante[10]; // vetor de 10 posições

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #" + (i+1) + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                cliente[quarto] = new Estudante(nome, email, quarto);                            
            }

            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < 10; i++)
            {
                if (cliente[i] != null)
                {
                    Console.WriteLine(cliente[i]);
                }
            }
            Console.ReadKey();

        }
    }
}
