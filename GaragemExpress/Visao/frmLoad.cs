using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GaragemExpress.Visao
{
    public partial class frmLoad : Form
    {
        public frmLoad()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmLoad_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                frmPrincipal frm = new frmPrincipal();
                frm.Show();
                this.Hide();
            }
            
        }
    }
}
