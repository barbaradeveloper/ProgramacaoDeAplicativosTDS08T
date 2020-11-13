using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _15_b_BárbaradeSousa_TDS08T
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;


       public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;

        } 
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            _nome = nome;
        }
        public double GetPreco()
        {
            return _preco;
        }
        public void SetPreco(double preco)
        {
            _preco = preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }
        public void SetQuantidade(int quantidade)
        {
            _quantidade = quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdcionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome + 
                ", $ " + _preco.ToString("F2", CultureInfo.InvariantCulture) + 
                ", " + _quantidade + 
                " unidades, Total: $ " +
                ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
