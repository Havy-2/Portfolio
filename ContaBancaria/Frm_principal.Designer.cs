namespace ContaBancaria
{
    partial class Frm_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_nome = new System.Windows.Forms.TextBox();
            this.TXT_saldo = new System.Windows.Forms.TextBox();
            this.TXT_conta = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_consoltar = new System.Windows.Forms.Button();
            this.btn_linpar = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_depositar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_sacar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Titular";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nº da Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo";
            // 
            // TXT_nome
            // 
            this.TXT_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_nome.Location = new System.Drawing.Point(338, 74);
            this.TXT_nome.Name = "TXT_nome";
            this.TXT_nome.Size = new System.Drawing.Size(193, 26);
            this.TXT_nome.TabIndex = 3;
            // 
            // TXT_saldo
            // 
            this.TXT_saldo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_saldo.Location = new System.Drawing.Point(338, 166);
            this.TXT_saldo.Name = "TXT_saldo";
            this.TXT_saldo.Size = new System.Drawing.Size(100, 26);
            this.TXT_saldo.TabIndex = 4;
            // 
            // TXT_conta
            // 
            this.TXT_conta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_conta.Location = new System.Drawing.Point(338, 121);
            this.TXT_conta.Name = "TXT_conta";
            this.TXT_conta.Size = new System.Drawing.Size(193, 26);
            this.TXT_conta.TabIndex = 5;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_cadastrar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Location = new System.Drawing.Point(541, 166);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(156, 26);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_consoltar
            // 
            this.btn_consoltar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_consoltar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consoltar.ForeColor = System.Drawing.Color.White;
            this.btn_consoltar.Location = new System.Drawing.Point(324, 267);
            this.btn_consoltar.Name = "btn_consoltar";
            this.btn_consoltar.Size = new System.Drawing.Size(156, 26);
            this.btn_consoltar.TabIndex = 7;
            this.btn_consoltar.Text = "Consultar Saldo";
            this.btn_consoltar.UseVisualStyleBackColor = false;
            this.btn_consoltar.Click += new System.EventHandler(this.btn_consoltar_Click);
            // 
            // btn_linpar
            // 
            this.btn_linpar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_linpar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_linpar.ForeColor = System.Drawing.Color.White;
            this.btn_linpar.Location = new System.Drawing.Point(541, 267);
            this.btn_linpar.Name = "btn_linpar";
            this.btn_linpar.Size = new System.Drawing.Size(156, 26);
            this.btn_linpar.TabIndex = 8;
            this.btn_linpar.Text = "Linpar Dados";
            this.btn_linpar.UseVisualStyleBackColor = false;
            this.btn_linpar.Click += new System.EventHandler(this.btn_linpar_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_mostrar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar.ForeColor = System.Drawing.Color.White;
            this.btn_mostrar.Location = new System.Drawing.Point(102, 267);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(156, 26);
            this.btn_mostrar.TabIndex = 9;
            this.btn_mostrar.Text = "Mostra Dados";
            this.btn_mostrar.UseVisualStyleBackColor = false;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_depositar
            // 
            this.btn_depositar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_depositar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_depositar.ForeColor = System.Drawing.Color.White;
            this.btn_depositar.Location = new System.Drawing.Point(324, 343);
            this.btn_depositar.Name = "btn_depositar";
            this.btn_depositar.Size = new System.Drawing.Size(156, 26);
            this.btn_depositar.TabIndex = 10;
            this.btn_depositar.Text = "Depositar";
            this.btn_depositar.UseVisualStyleBackColor = false;
            this.btn_depositar.Click += new System.EventHandler(this.btn_depositar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_sair.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Location = new System.Drawing.Point(541, 343);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(156, 26);
            this.btn_sair.TabIndex = 11;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_sacar
            // 
            this.btn_sacar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_sacar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sacar.ForeColor = System.Drawing.Color.White;
            this.btn_sacar.Location = new System.Drawing.Point(102, 343);
            this.btn_sacar.Name = "btn_sacar";
            this.btn_sacar.Size = new System.Drawing.Size(156, 26);
            this.btn_sacar.TabIndex = 12;
            this.btn_sacar.Text = "Sacar";
            this.btn_sacar.UseVisualStyleBackColor = false;
            this.btn_sacar.Click += new System.EventHandler(this.btn_sacar_Click);
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sacar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_depositar);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_linpar);
            this.Controls.Add(this.btn_consoltar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.TXT_conta);
            this.Controls.Add(this.TXT_saldo);
            this.Controls.Add(this.TXT_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_principal";
            this.Text = "Sistema Bancario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_nome;
        private System.Windows.Forms.TextBox TXT_saldo;
        private System.Windows.Forms.TextBox TXT_conta;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_consoltar;
        private System.Windows.Forms.Button btn_linpar;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_depositar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_sacar;
    }
}

