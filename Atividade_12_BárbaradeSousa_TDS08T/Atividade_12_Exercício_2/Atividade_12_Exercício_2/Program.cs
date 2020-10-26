using System;
using System.Globalization;

namespace Atividade_12_Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você quer comprar? ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double convensor = ConvensorDeMoeda.Convensor(dolar,valor);
            Console.WriteLine("Valor a ser pago em reais: " + convensor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
