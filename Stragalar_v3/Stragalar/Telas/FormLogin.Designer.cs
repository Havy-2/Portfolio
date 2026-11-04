namespace Stragalar.Telas
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblTitulo.Text = "STRAGALAR — Login";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(40, 30);
            this.lblTitulo.Size = new System.Drawing.Size(300, 40);

            this.txtLogin.Location = new System.Drawing.Point(40, 100);
            this.txtLogin.Size = new System.Drawing.Size(280, 28);
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLogin.PlaceholderText = "Login";

            this.txtSenha.Location = new System.Drawing.Point(40, 150);
            this.txtSenha.Size = new System.Drawing.Size(280, 28);
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.PlaceholderText = "Senha";

            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Location = new System.Drawing.Point(40, 210);
            this.btnEntrar.Size = new System.Drawing.Size(130, 40);
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);

            this.btnSair.Text = "Sair";
            this.btnSair.Location = new System.Drawing.Point(190, 210);
            this.btnSair.Size = new System.Drawing.Size(130, 40);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);

            this.ClientSize = new System.Drawing.Size(360, 300);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnSair);
            this.Text = "STRAGALAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
