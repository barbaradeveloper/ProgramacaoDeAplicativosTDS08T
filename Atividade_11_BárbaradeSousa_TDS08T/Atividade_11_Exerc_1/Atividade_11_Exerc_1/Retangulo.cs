using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_11_Exerc_1
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            double area = Altura * Largura;
            return area;
        }
        public double Perimetro()
        {
            double perimetro = (Altura * 2) + (Largura * 2);
            return perimetro;
        }
        public double Diagonal()
        {
            double diagonal = Math.Sqrt( Math.Pow(Altura, 2.0) + Math.Pow(Largura, 2.0));
            return diagonal;
        }
    }
}
