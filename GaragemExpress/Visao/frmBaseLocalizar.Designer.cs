namespace GaragemExpress
{
    partial class frmBaseLocalizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusGrid = new System.Windows.Forms.StatusStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnManutencao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusGrid
            // 
            this.statusGrid.Location = new System.Drawing.Point(0, 295);
            this.statusGrid.Name = "statusGrid";
            this.statusGrid.Size = new System.Drawing.Size(482, 22);
            this.statusGrid.SizingGrip = false;
            this.statusGrid.Stretch = false;
            this.statusGrid.TabIndex = 1;
            this.statusGrid.Text = "statusStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(333, 31);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 2;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            // 
            // btnManutencao
            // 
            this.btnManutencao.Location = new System.Drawing.Point(333, 80);
            this.btnManutencao.Name = "btnManutencao";
            this.btnManutencao.Size = new System.Drawing.Size(75, 23);
            this.btnManutencao.TabIndex = 3;
            this.btnManutencao.Text = "Manutenção";
            this.btnManutencao.UseVisualStyleBackColor = true;
            // 
            // frmBaseLocalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 317);
            this.Controls.Add(this.btnManutencao);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.statusGrid);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBaseLocalizar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Garagem Express - ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fechar_Esc);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Button btnManutencao;
    }
}