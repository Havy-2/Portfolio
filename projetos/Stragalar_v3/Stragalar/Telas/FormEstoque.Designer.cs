namespace Stragalar.Telas
{
    partial class FormEstoque
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.RadioButton rdbEntrada;
        private System.Windows.Forms.RadioButton rdbSaida;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblTitulo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.rdbEntrada = new System.Windows.Forms.RadioButton();
            this.rdbSaida = new System.Windows.Forms.RadioButton();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();

            this.lblTitulo.Text = "Controle de Estoque";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Size = new System.Drawing.Size(300, 30);

            var lblProd = new System.Windows.Forms.Label { Text = "Produto:", Location = new System.Drawing.Point(20, 60), Size = new System.Drawing.Size(80, 25) };
            this.cmbProduto.Location = new System.Drawing.Point(110, 58);
            this.cmbProduto.Size = new System.Drawing.Size(250, 25);
            this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            var lblQtd = new System.Windows.Forms.Label { Text = "Quantidade:", Location = new System.Drawing.Point(20, 100), Size = new System.Drawing.Size(80, 25) };
            this.txtQuantidade.Location = new System.Drawing.Point(110, 98);
            this.txtQuantidade.Size = new System.Drawing.Size(100, 25);

            this.rdbEntrada.Text = "Entrada";
            this.rdbEntrada.Location = new System.Drawing.Point(230, 98);
            this.rdbEntrada.Checked = true;
            this.rdbSaida.Text = "Saída";
            this.rdbSaida.Location = new System.Drawing.Point(320, 98);

            var lblMot = new System.Windows.Forms.Label { Text = "Motivo:", Location = new System.Drawing.Point(20, 140), Size = new System.Drawing.Size(80, 25) };
            this.txtMotivo.Location = new System.Drawing.Point(110, 138);
            this.txtMotivo.Size = new System.Drawing.Size(250, 25);

            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Location = new System.Drawing.Point(110, 180);
            this.btnRegistrar.Size = new System.Drawing.Size(120, 35);
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);

            this.dgv.Location = new System.Drawing.Point(20, 230);
            this.dgv.Size = new System.Drawing.Size(700, 280);
            this.dgv.ReadOnly = true;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(lblProd);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(lblQtd);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.rdbEntrada);
            this.Controls.Add(this.rdbSaida);
            this.Controls.Add(lblMot);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgv);

            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
