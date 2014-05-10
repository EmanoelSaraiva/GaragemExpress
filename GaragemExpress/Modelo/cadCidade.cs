using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaragemExpress.Modelo
{
    class cadCidade
    {
        Int64 _codigo;
        public Int64 Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        string _cidade;
        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        string _estado;
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
    }
}
