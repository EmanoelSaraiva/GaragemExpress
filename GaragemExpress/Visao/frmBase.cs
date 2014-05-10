using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Focvs.DLLXML;

namespace GaragemExpress
{
    public partial class frmBase : Form
    {
        StatusCadastro sStatus;

        public frmBase()
        {
            InitializeComponent();
            
        }

        private void Fechar_Esc(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void HabilitaDesabilita(bool Value)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is ToolStrip)
                    continue;
                ctl.Enabled = Value;
                
            }

            //habilita quando não estivermos inserindo ou editando, somente navegando
            btnNovo.Enabled = (sStatus == StatusCadastro.scBrowser);
            // habilita quando estiver inserindo ou editando
            btnIncluir.Enabled = ((sStatus == StatusCadastro.scInsert) || (sStatus == StatusCadastro.scEdit));
            btnAlterar.Enabled = (sStatus == StatusCadastro.scEdit);
            //habilita quando não estiver inserindo ou editando, somente navegando
            btnLocalizar.Enabled = (sStatus == StatusCadastro.scBrowser);
            //habilita quando estiver editando
            btnExcluir.Enabled = (sStatus == StatusCadastro.scEdit);
            //habilita sempre
            btnSair.Enabled = true;
            
            
        }

        public enum StatusCadastro
        {
            scInsert, scBrowser, scEdit
        }

        private void LimparControles()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                    (ctl as TextBox).Text = "";
                if (ctl is ComboBox)
                    (ctl as ComboBox).SelectedIndex = -1;
                if (ctl is ListBox)
                    (ctl as ListBox).SelectedIndex = -1;
            }
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            sStatus = StatusCadastro.scBrowser;
            LimparControles();
            HabilitaDesabilita(false);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual bool Salvar()
        {
            return true; 
        }

        public virtual bool Exlcuir()
        { return true; }

        public virtual bool Localizar()
        { return true; }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            sStatus = StatusCadastro.scInsert;
            HabilitaDesabilita(true);            
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (Salvar())
            {
                sStatus = StatusCadastro.scBrowser;
                HabilitaDesabilita(true);
                MessageBox.Show("Registro salvo com sucesso!", "Salvar", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            LimparControles();
            HabilitaDesabilita(false);
        }
    }
}
