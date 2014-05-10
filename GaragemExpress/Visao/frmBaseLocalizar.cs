using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaragemExpress
{
    public partial class frmBaseLocalizar : Form
    {
        public frmBaseLocalizar()
        {
            InitializeComponent();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string oId;

            oId = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();

            
        }

        private void Fechar_Esc(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

    }
}
