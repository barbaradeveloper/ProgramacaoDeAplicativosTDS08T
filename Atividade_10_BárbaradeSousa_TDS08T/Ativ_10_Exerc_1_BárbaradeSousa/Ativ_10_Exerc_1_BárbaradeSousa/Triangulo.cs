using System;
using System.Collections.Generic;
using System.Text;

namespace Ativ_10_Exerc_1_BárbaradeSousa
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }
    }
}
