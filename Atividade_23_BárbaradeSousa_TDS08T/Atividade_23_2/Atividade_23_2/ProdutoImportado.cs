using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Atividade_23_2
{
    class ProdutoImportado : Produto
    {
        public double TaxaAlfandega { get; set; }
        
        public ProdutoImportado()
        {

        }
        public ProdutoImportado(string nome, double preco, double taxaalfandega) : base(nome, preco)
        {
            Nome = nome;
            Preco = preco;
            TaxaAlfandega = taxaalfandega;
        }
        public double PrecoTotal()
        {
            return Preco + TaxaAlfandega;
        }
        public string EtiquetadePreco(double taxaalfandega)
        {
            return " Nome: " + Nome + "\n Preço: " + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture) +
                "\n (Taxa de Alfândega: " + TaxaAlfandega + ")";
        }
    }
}
