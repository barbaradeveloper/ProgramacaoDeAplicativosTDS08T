using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_11_Exerc_2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
      
        public double SalarioLiquido()
        {
            double sl = SalarioBruto - Imposto;
            return sl;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + SalarioBruto * (porcentagem / 100) - Imposto;
        }
    }
}
