using System;

namespace Atividade_7_BárbaradeSousa_TDS08T
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Questão 1 
             Faça um programa que solicite do usuário a temperatura ambiente. 
                a) Se estiver abaixo de 20ºc. Escreva: "Frio"
                b) Se estiver entre 20ºc e 26ºc. Escreva: "Bom"
                c) Se estiver acima de 26ºc. Escreva: "Quente" 
             */
            
            Console.WriteLine("--------------- QUESTÃO 1 --------------");
            Console.WriteLine();
            Console.WriteLine("Digite a temperatura ambiente: ");
            int t = int.Parse(Console.ReadLine());
            if (t < 20)
            {
                Console.WriteLine("Frio");
            } 
            else if (t <= 26)
            {
                Console.WriteLine("Bom");
            }
            else if (t > 26)
            {
                Console.WriteLine("Quente");
            }
            Console.WriteLine();
            

            /* Questão 2 
              Faça um programa que solicite do usuário a umidade relativa do ar.
                a) Se a umidade estiver entre  50% e 80%. Escreva: "Ideal"
                b ) Se a umidade estiver entre 30% e 50%. Escreva: "Ruim"
                c ) Se a umidade estiver entre 20% de 30%. Escreva: "Estado de atenção!"
                d ) Se estiver acima de 80%. Escreva: "Grande possibilidade de chuvas"
                e ) Se estiver abaixo de abaixo de 20%. Escreva: "Help!"                         
             */
            Console.WriteLine("-------------- QUESTÃO 2 ------------");
            Console.WriteLine();
            Console.WriteLine("Digite qual é a umidade relativa do ar: ");
            int u = int.Parse(Console.ReadLine());
            
            if (u < 20)
            {
                Console.WriteLine("Help!");
            }
            else if (u < 30)
            {
                Console.WriteLine("Estado de atenção!");
            }
            else if (u < 50)
            {
                Console.WriteLine("Ruim!");
            }
            else if (u <= 80)
            {
                Console.WriteLine("Ideal!");
            }
            else if (u > 80)
            {
                Console.WriteLine("Grandes possibilidades de chuva!");
            }
        }
    }
}
