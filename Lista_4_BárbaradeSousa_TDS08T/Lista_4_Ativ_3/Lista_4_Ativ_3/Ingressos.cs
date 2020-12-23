using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_4_Ativ_3
{
    class Ingressos
    {
        public double Valor { get; set; }
        public int Id { get; set; }

        public Ingressos()
        {

        }

        public Ingressos(double valor, int id)
        {
            Valor = valor;
            Id = id;
        }

        public void ImprimeValor()
        {
            Console.WriteLine(Valor);
        }
    }
}
