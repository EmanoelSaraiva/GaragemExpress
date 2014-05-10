using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Focvs.DLLXML;

namespace GaragemExpress
{
    public partial class Form1 : GaragemExpress.frmBase
    {
        public Form1()
        {
            InitializeComponent();
        }
        public override bool Localizar()
        {
            return base.Localizar();
        }

        public override bool Salvar()
        {

            Modelo.cadCidade cidade = new Modelo.cadCidade();
            CrudXML framwork = new CrudXML(cidade);

            cidade.Cidade = txtCidade.Text;
            cidade.Estado = cbEstado.Text;

            try
            {
                framwork.InserirObjeto();
                return base.Salvar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel salvar o registro!", "Salvar", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return base.Salvar();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Modelo.cadCidade cidade = new Modelo.cadCidade();
            CrudXML framework = new CrudXML(cidade);

            cidade = null;
            framework = null;
        }

        
    }
}
