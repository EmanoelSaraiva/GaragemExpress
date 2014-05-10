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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "Admin" || txtSenha.Text == "123")
            {
                frmLoad frmP = new frmLoad();
                frmP.Show();
                this.Hide();
            }   
        }
    }
}
