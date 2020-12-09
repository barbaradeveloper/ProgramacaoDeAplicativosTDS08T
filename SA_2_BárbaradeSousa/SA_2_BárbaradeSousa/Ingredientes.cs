using System;
using System.Collections.Generic;
using System.Text;

namespace SA_2_BárbaradeSousa
{
    class Ingredientes
    {
        public string Nome_Ingrediente { get; set; }
        public int Quantidade_Ingrediente { get; set; }
        public string Unidade_De_Medida { get; set; }

        public Ingredientes(string nome_ingrediente, int quantidade_ingrediente, string unidade_de_medida)
        {
            Nome_Ingrediente = nome_ingrediente;
            Quantidade_Ingrediente = quantidade_ingrediente;
            Unidade_De_Medida = unidade_de_medida;
        }
    }
}
