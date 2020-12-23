using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Atividade_23_1
{
    class FuncionarioTerceirizado : Funcionario
    {
        public double DespesaAdicional { get; set; }
        public FuncionarioTerceirizado()
        {

        }
        public FuncionarioTerceirizado(string nome, int horastrabalhadas, double valorhora, double despesa): base(nome, horastrabalhadas, valorhora)
        {
            Nome = nome;
            HorasTrabalhadas = horastrabalhadas;
            ValorHora = valorhora;
            DespesaAdicional = despesa;
        }
        public double Pagamento(double despesa)
        {
            return (ValorHora * HorasTrabalhadas) + (110 * DespesaAdicional)/100 + DespesaAdicional;
        }
        public override string ToString()
        {
            return "Pagamentos: \n" 
                + Nome + " - " + Pagamento().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
