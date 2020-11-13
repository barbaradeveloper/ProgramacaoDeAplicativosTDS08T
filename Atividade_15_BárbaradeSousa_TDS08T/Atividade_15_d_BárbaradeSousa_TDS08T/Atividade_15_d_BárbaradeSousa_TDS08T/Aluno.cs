using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_15_d_BárbaradeSousa_TDS08T
{
    class Aluno
    {
        private string _nome;
        private string _email;
        private string _cidade;
        private bool _status;

        public Aluno(string nome, string email, string cidade, bool status)
        {
            _nome = nome;
            _email = email;
            _cidade = cidade;
            _status = status;
        }
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            _nome = nome;
        }
        public string GetEmail()
        {
            return _email;
        }
        public void SetEmail(string email)
        {
            _email = email;
        }
        public string GetCidade()
        {
            return _cidade;
        }
        public void SetCidade(string cidade)
        {
            _cidade = cidade;
        }
        public bool GetStatus()
        {
            return _status;
        }
        public void SetStatus(bool status)
        {
            _status = status;
        }
    }
}
