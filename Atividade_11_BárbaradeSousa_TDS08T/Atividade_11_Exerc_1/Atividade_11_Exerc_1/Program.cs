using System;
using System.Globalization;

namespace Atividade_11_Exerc_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r;
            r = new Retangulo();
            Console.WriteLine("Entre com os valores da altura e da largura do retângulo: ");
            Console.WriteLine("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = r.Area();
            Console.WriteLine("AREA: " + area.ToString("F2", CultureInfo.InvariantCulture));

            double perimetro = r.Perimetro();
            Console.WriteLine("PERÍMETRO: " + perimetro.ToString("F2", CultureInfo.InvariantCulture));

            double diagonal = r.Diagonal();
            Console.WriteLine("DIAGONAL: " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
