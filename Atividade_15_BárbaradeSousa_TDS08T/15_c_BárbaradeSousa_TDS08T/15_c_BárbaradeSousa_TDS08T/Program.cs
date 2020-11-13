using System;

namespace _15_c_BárbaradeSousa_TDS08T
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p = new Professor("Aguinaldo", "Souza", 35334444, true);
            p.SetOculos(false);
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetSobrenome());
            Console.WriteLine(p.GetTelefone());
            Console.WriteLine(p.GetOculos());
        }
    }
}
