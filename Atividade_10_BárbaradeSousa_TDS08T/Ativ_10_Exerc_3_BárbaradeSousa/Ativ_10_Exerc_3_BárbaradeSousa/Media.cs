using System;
using System.Collections.Generic;
using System.Text;

namespace Ativ_10_Exerc_3_BárbaradeSousa
{
    class Media
    {
        public string Nome1;
        public string Nome2;

        public double Salario1;
        public double Salario2;

        public double resultado()
        {
           
            double resultado = (Salario1 + Salario2)/2;
            return resultado;
        }


    }
}
