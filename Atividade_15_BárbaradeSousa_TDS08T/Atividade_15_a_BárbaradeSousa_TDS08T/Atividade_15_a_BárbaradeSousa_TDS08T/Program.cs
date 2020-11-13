using System;
using System.Globalization;

namespace Atividade_15_a_BárbaradeSousa_TDS08T
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("        PROGRAMA QUE MOSTRA A ÁREA, PERÍMETRO E DIAGONAL DO RETÂNGULO         ");
            Console.WriteLine();
            Retangulo r = new Retangulo(3.0, 5.0);
            r.SetLargura(2.0);
            r.SetAltura(5.0);
            Console.WriteLine(r.GetLargura());
            Console.WriteLine(r.GetAltura());

            
        }
    }
}
