using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Atividade_23_1
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int HorasTrabalhadas { get; set; }
        public double ValorHora { get; set; }
        public Funcionario()
        {

        }
        public Funcionario(string nome, int horastrabalhadas, double valorhora)
        {
            Nome = nome;
            HorasTrabalhadas = horastrabalhadas;
            ValorHora = valorhora;
        }
        public double Pagamento()
        {
            return ValorHora * HorasTrabalhadas;
        }
        public override string ToString()
        {
            return "Pagamentos: \n" + 
                Nome + " - " + Pagamento().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
