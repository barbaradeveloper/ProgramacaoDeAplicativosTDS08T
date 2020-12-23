using System;

namespace Lista_4_Ativ_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 3: Crie uma classe chamada Ingresso que possui um valor em reais e um método
                    imprimeValor().
                    a. crie uma classe VIP, que herda Ingresso e possui um valor adicional. Crie um
                    método que retorne o valor do ingresso VIP (com o adicional incluído).
                    b. crie uma classe Normal, que herda Ingresso e possui um método que imprime:
                    "Ingresso Normal".
                    c. crie uma classe CamaroteInferior (que possui a localização do ingresso e métodos
                    para acessar e imprimir esta localização) e uma classe CamaroteSuperior, que é
                    mais cara (possui valor adicional). Esta última possui um método para retornar o
                    valor do ingresso. Ambas as classes herdam a classe VIP. */
            Vip v1 = new Vip(180.40, 444, 20);
            Normal n1 = new Normal(180.40, 444);
        }
    }
}
