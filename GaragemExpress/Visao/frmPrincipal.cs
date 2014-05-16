using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaragemExpress.Visao
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frmus = new frmUsuario();
            frmus.Show();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GaragemExpress.Form1 frmCit = new Form1();
            frmCit.Show();
        }

        private void veículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarro frmVe = new frmCarro();
            frmVe.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmC = new frmCliente();
            frmC.Show();
        }
    }
}
