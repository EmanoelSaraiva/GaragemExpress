using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaragemExpress.Modelo
{
    class cadVeiculo
    {
        Int64 _codigo;
        public Int64 Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        string _montadora;
        public string Montadora
        {
            get { return _montadora; }
            set { _montadora = value; }
        }

        string _modelo;
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        string _numChassi;
        public string NumChassi
        {
            get { return _numChassi; }
            set { _numChassi = value; }
        }
        string _obs;
        public string Obs
        {
            get { return _obs; }
            set { _obs = value; }
        }

        string _placa;
        public string Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        string _obtVia;
        public string ObtVia
        {
            get { return _obtVia; }
            set { _obtVia = value; }
        }

        DateTime _anoFabr;
        public DateTime AnoFabr
        {
            get { return _anoFabr; }
            set { _anoFabr = value; }
        }
    }
}
