using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Focvs.DLLXML;

namespace GaragemExpress.Visao
{
    public partial class frmCliente : GaragemExpress.frmBase
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        public override bool Salvar()
        {
            Modelo.Pessoa pessoa = new Modelo.Pessoa();
            CrudXML frmw = new CrudXML(pessoa);

            pessoa.Nome = txtNome.Text;
            pessoa.CPF = mskCPF.Text;
            pessoa.RG = mskRG.Text;
            pessoa.Telefone = mskTel.Text;
            pessoa.Celular = mskCel.Text;

            pessoa.Endereco = txtEnd.Text;
            pessoa.Cidade = cbCida.Text;
            pessoa.Uf = cbUF.Text;

            try
            {
                frmw.InserirObjeto();
                return base.Salvar();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

       

      

       
    }
}
