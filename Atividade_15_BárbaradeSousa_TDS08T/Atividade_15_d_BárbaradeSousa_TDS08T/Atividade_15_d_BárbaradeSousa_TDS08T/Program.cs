using System;

namespace Atividade_15_d_BárbaradeSousa_TDS08T
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno("Carolina", "carolina@gmail.com", "Belo Horizonte", true);
            a.SetNome("Bruna");
            a.SetEmail("bruna@gmail.com");
            a.SetCidade("Nova Lima");
            a.SetStatus(false);
            Console.WriteLine(a.GetNome());
            Console.WriteLine(a.GetEmail());
            Console.WriteLine(a.GetCidade());
            Console.WriteLine(a.GetStatus());
        }
    }
}
