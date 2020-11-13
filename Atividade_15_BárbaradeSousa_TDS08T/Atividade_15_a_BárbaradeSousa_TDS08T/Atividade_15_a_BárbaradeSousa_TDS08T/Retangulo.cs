using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Atividade_15_a_BárbaradeSousa_TDS08T
{
    class Retangulo
    {
        private double _largura;
        private double _altura;


        public  Retangulo(double largura, double altura)
        {
            _largura = largura;
            _altura = altura;
        }
        public double GetLargura()
        {
            return _largura;
        }
        public void SetLargura(double largura)
        {
            _largura = largura;
        }
        public double GetAltura()
        {
            return _altura;
        }
        public void SetAltura(double altura)
        {
            _altura = altura;
        }
        public double Area()
        {
            return _largura * _altura;
        }
        public double Perimetro()
        {
            return 2 * (_largura +  _altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(_largura, 2.0) + Math.Pow(_altura, 2.0));
        }
        public override string ToString()
        {
            return "Area " + Area().ToString("F2",CultureInfo.InvariantCulture) + 
                "Perímetro " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) +
                "Diagonal" + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
