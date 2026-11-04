namespace Stragalar.Telas
{
    partial class FormVendas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.ComboBox cmbPagamento;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridView dgvVendas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblVenda = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.cmbPagamento = new System.Windows.Forms.ComboBox();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.SuspendLayout();

            this.lblVenda.Text = "Nenhuma venda aberta";
            this.lblVenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblVenda.Location = new System.Drawing.Point(20, 15);
            this.lblVenda.Size = new System.Drawing.Size(300, 25);

            this.lblTotal.Text = "Total: R$ 0,00";
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotal.Location = new System.Drawing.Point(350, 15);
            this.lblTotal.Size = new System.Drawing.Size(200, 25);

            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.Location = new System.Drawing.Point(20, 50);
            this.btnNovaVenda.Size = new System.Drawing.Size(120, 35);
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);

            var lblP = new System.Windows.Forms.Label { Text = "Produto:", Location = new System.Drawing.Point(160, 55), Size = new System.Drawing.Size(60, 25) };
            this.cmbProduto.Location = new System.Drawing.Point(220, 53);
            this.cmbProduto.Size = new System.Drawing.Size(180, 25);
            this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            var lblQ = new System.Windows.Forms.Label { Text = "Qtd:", Location = new System.Drawing.Point(410, 55), Size = new System.Drawing.Size(40, 25) };
            this.txtQtd.Location = new System.Drawing.Point(450, 53);
            this.txtQtd.Size = new System.Drawing.Size(60, 25);

            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Location = new System.Drawing.Point(520, 50);
            this.btnAdicionar.Size = new System.Drawing.Size(90, 35);
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);

            this.cmbPagamento.Items.AddRange(new object[] { "Dinheiro", "Pix", "Débito", "Crédito" });
            this.cmbPagamento.Location = new System.Drawing.Point(20, 100);
            this.cmbPagamento.Size = new System.Drawing.Size(120, 25);
            this.cmbPagamento.SelectedIndex = 0;

            this.btnFinalizar.Text = "Finalizar Venda";
            this.btnFinalizar.Location = new System.Drawing.Point(160, 95);
            this.btnFinalizar.Size = new System.Drawing.Size(130, 35);
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);

            this.dgvItens.Location = new System.Drawing.Point(20, 150);
            this.dgvItens.Size = new System.Drawing.Size(450, 200);
            this.dgvItens.ReadOnly = true;
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            var lblHist = new System.Windows.Forms.Label { Text = "Vendas do dia:", Location = new System.Drawing.Point(490, 150), Size = new System.Drawing.Size(120, 20) };
            this.dgvVendas.Location = new System.Drawing.Point(490, 175);
            this.dgvVendas.Size = new System.Drawing.Size(350, 175);
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.Controls.Add(this.lblVenda);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(lblP);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(lblQ);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cmbPagamento);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(lblHist);
            this.Controls.Add(this.dgvVendas);

            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
