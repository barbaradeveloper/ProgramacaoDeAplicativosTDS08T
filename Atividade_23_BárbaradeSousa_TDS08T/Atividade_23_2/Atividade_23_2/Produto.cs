using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Atividade_23_2
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {

        }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public string EtiquetadePreco()
        {
            return "Nome: " + Nome + " \n Preço: " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
