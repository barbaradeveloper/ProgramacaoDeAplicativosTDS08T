using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Atividade_13_BárbaradeSousa_TDS08T
{
    class Candidato
    {
        public string Nome;
        public string Partido;
        public string Ficha;
        public double Patrimonio;
        public string Profissao;
        public string Cargo;
        public string Municipio;

        public Candidato(string nome, string partido, double patrimonio, string cargo, string profissao)
        {
            Nome = nome;
            Partido = partido;
            Patrimonio = patrimonio;
            Profissao = profissao;
            Cargo = cargo;
            Municipio = "Lagoa Santa";
            Ficha = "Limpa";
        }

        public override string ToString()
        {
            return "Candidato " +  Nome + " cadastrado com sucesso! \r\n" 
                + " Dados para conferência: \r\n" + 
                " Candidato a " + Cargo + " de " + Municipio +  "\r\n"
                + " Nome: " + Nome 
                + "\r\n Partido:  " + Partido  
                + "\r\n Patrimônio declarado: R$" + Patrimonio.ToString("F2", CultureInfo.InvariantCulture)
                + "\r\n Profissão: "+ Profissao
                + "\r\n Ficha limpa: "+ Ficha ;
        }
    }
}
