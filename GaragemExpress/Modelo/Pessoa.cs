using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaragemExpress.Modelo
{
    class Pessoa
    {
        Int64 _codigo;
        public Int64 Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        //dados importantes para o cadastro
        string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        string _CPF;
        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }

        string _RG;
        public string RG
        {
            get { return _RG; }
            set { _RG = value; }
        }

        string _telefone;
        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        string _celular;
        public string Celular
        {
            get { return _celular; }
            set { _celular = value; }
        }

        string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        DateTime _dtNasc;
        

        string _sexo;
        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        string _tpPessoa;
        public string TpPessoa
        {
            get { return _tpPessoa; }
            set { _tpPessoa = value; }
        }

        //informar endereço

        string _endereco;
        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        string _cidade;
        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        string _uf;
        public string Uf
        {
            get { return _uf; }
            set { _uf = value; }
        }

        string _CEP;
        public string CEP
        {
            get { return _CEP; }
            set { _CEP = value; }
        }

        string _bairro;
        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        public void CalculaDataDeNascimento ()
        {
            int _idade = DateTime.Now.Year - _dtNasc.Year;

            if (DateTime.Now.Month < _dtNasc.Month || (DateTime.Now.Month == _dtNasc.Month
                && DateTime.Now.Day < _dtNasc.Day))
            {
                _idade--;
            }

            
        }

    }
}
