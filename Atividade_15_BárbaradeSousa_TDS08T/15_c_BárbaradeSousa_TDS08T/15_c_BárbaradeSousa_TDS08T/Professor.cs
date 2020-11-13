using System;
using System.Collections.Generic;
using System.Text;

namespace _15_c_BárbaradeSousa_TDS08T
{
    class Professor
    {
        private string _nome;
        private string _sobrenome;
        private int _telefone;
        private bool _oculos;

        public Professor(string nome, string sobrenome, int telefone, bool oculos)       
        {
            _nome = nome;
            _sobrenome = sobrenome;
            _telefone = telefone;
            _oculos = oculos;

        }
        public string GetNome()
        {
            return _nome;
        }
        public string GetSobrenome()
        {
            return _sobrenome;
        }
        public int GetTelefone()
        {
            return _telefone;
        }
        public void SetTelefone(int telefone)
        {
            _telefone = telefone;
        }
        public bool GetOculos()
        {
            return _oculos;
        }
        public void SetOculos(bool oculos)
        {
            _oculos = oculos;
        }

        public override string ToString()
        {
            return _nome + _sobrenome + _telefone + _oculos; 
        }
    
    }
}
