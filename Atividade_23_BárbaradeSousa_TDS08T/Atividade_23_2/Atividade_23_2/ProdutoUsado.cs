using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_23_2
{
    class ProdutoUsado : Produto
    {
        public  string DataFabricacao { get; set; }
        public ProdutoUsado()
        {

        }
        public ProdutoUsado(string nome, double preco, string datafabricacao): base(nome, preco)
        {
            Nome = nome;
            Preco = preco;
            DataFabricacao = datafabricacao;
        }
        public string EtiquetadePreco(string datafabricacao)
        {
            return "Nome: " + Nome + " \n Preço: " + Preco + "(Data de fabricação: " + DataFabricacao + ")";
        }
    }
}
