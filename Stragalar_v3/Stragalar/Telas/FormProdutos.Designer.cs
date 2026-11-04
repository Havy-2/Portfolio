namespace Stragalar.Telas
{
    partial class FormProdutos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgv;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();

            int y = 20;
            foreach (var (txt, label) in new[] { (txtNome, "Nome"), (txtCategoria, "Categoria"), (txtPreco, "Preço"), (txtQtd, "Quantidade") })
            {
                var lbl = new System.Windows.Forms.Label { Text = label, Location = new System.Drawing.Point(20, y), Size = new System.Drawing.Size(100, 25) };
                txt.Location = new System.Drawing.Point(130, y);
                txt.Size = new System.Drawing.Size(200, 25);
                this.Controls.Add(lbl);
                this.Controls.Add(txt);
                y += 35;
            }

            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Location = new System.Drawing.Point(130, y);
            this.btnSalvar.Size = new System.Drawing.Size(100, 35);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);

            this.dgv.Location = new System.Drawing.Point(20, y + 50);
            this.dgv.Size = new System.Drawing.Size(700, 300);
            this.dgv.ReadOnly = true;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgv);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
