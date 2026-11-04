namespace Stragalar.Telas
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnSair;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();

            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Size = new System.Drawing.Size(200, 600);
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.btnVendas);
            this.pnlMenu.Controls.Add(this.btnEstoque);
            this.pnlMenu.Controls.Add(this.btnProdutos);
            this.pnlMenu.Controls.Add(this.btnInicio);
            this.pnlMenu.Controls.Add(this.lblUsuario);

            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(10, 20);
            this.lblUsuario.Size = new System.Drawing.Size(180, 40);
            this.lblUsuario.Text = "Usuário";

            int y = 80;
            foreach (var btn in new[] { btnInicio, btnProdutos, btnEstoque, btnVendas, btnSair })
            {
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.ForeColor = System.Drawing.Color.White;
                btn.BackColor = System.Drawing.Color.FromArgb(30, 58, 138);
                btn.Size = new System.Drawing.Size(180, 40);
                btn.Location = new System.Drawing.Point(10, y);
                btn.Font = new System.Drawing.Font("Segoe UI", 10F);
                y += 50;
            }
            this.btnInicio.Text = "Início";
            this.btnProdutos.Text = "Produtos";
            this.btnEstoque.Text = "Estoque";
            this.btnVendas.Text = "Vendas";
            this.btnSair.Text = "Sair";

            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);

            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.BackColor = System.Drawing.Color.White;

            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Text = "STRAGALAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
