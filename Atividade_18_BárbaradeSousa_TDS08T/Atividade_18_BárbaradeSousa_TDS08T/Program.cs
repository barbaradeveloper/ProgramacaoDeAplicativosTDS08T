using System;

namespace Atividade_18_BárbaradeSousa_TDS08T
{
    class Program
    {
        static void Main(string[] args)
        {
            // Questão 1
            int? n1 = null;

            // Questão 2 
            long? n2 = null;

            // Questão 3 
            ushort? n3 = null;

            // Questão 4
            double? n4 = null;

            // Questão 5 
            int? n5 = n1 ?? 34;

            // Questão 6 
            long? n6 = n2 ?? 65000000;

            // Questão 7 
            ushort? n7 = n3 ?? 500;
            // Questão 8 

            double? n8 = n4 ?? 7.50;
            

            // Questão 9 
            Console.WriteLine(n5.GetValueOrDefault());

            // Questão 10
         
            Console.WriteLine(n6.HasValue);

            // Questão 11 
            Console.WriteLine(n7.Value);
            
        }
    }
}
