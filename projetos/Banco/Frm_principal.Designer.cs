namespace Banco
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
            this.Txb_titular = new System.Windows.Forms.TextBox();
            this.Txb_saldo = new System.Windows.Forms.TextBox();
            this.Txb_conta = new System.Windows.Forms.TextBox();
            this.Btn_mostrar = new System.Windows.Forms.Button();
            this.Btn_sair = new System.Windows.Forms.Button();
            this.Btn_depositar = new System.Windows.Forms.Button();
            this.Btn_sacar = new System.Windows.Forms.Button();
            this.Btn_saldo = new System.Windows.Forms.Button();
            this.Btn_cadastrar = new System.Windows.Forms.Button();
            this.Btn_limpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(244, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do titular:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(336, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nº da conta:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(494, 475);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 69);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo:";
            // 
            // Txb_titular
            // 
            this.Txb_titular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_titular.Location = new System.Drawing.Point(732, 176);
            this.Txb_titular.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Txb_titular.Name = "Txb_titular";
            this.Txb_titular.Size = new System.Drawing.Size(1369, 72);
            this.Txb_titular.TabIndex = 3;
            // 
            // Txb_saldo
            // 
            this.Txb_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_saldo.Location = new System.Drawing.Point(732, 464);
            this.Txb_saldo.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Txb_saldo.Name = "Txb_saldo";
            this.Txb_saldo.Size = new System.Drawing.Size(628, 72);
            this.Txb_saldo.TabIndex = 5;
            // 
            // Txb_conta
            // 
            this.Txb_conta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_conta.Location = new System.Drawing.Point(732, 319);
            this.Txb_conta.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Txb_conta.Name = "Txb_conta";
            this.Txb_conta.Size = new System.Drawing.Size(628, 72);
            this.Txb_conta.TabIndex = 4;
            // 
            // Btn_mostrar
            // 
            this.Btn_mostrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mostrar.Location = new System.Drawing.Point(256, 824);
            this.Btn_mostrar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Btn_mostrar.Name = "Btn_mostrar";
            this.Btn_mostrar.Size = new System.Drawing.Size(491, 120);
            this.Btn_mostrar.TabIndex = 7;
            this.Btn_mostrar.Text = "Mostrar Dados";
            this.Btn_mostrar.UseVisualStyleBackColor = false;
            this.Btn_mostrar.Click += new System.EventHandler(this.Btn_mostrar_Click);
            // 
            // Btn_sair
            // 
            this.Btn_sair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sair.Location = new System.Drawing.Point(1626, 1041);
            this.Btn_sair.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Btn_sair.Name = "Btn_sair";
            this.Btn_sair.Size = new System.Drawing.Size(491, 120);
            this.Btn_sair.TabIndex = 12;
            this.Btn_sair.Text = "Sair";
            this.Btn_sair.UseVisualStyleBackColor = false;
            this.Btn_sair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // Btn_depositar
            // 
            this.Btn_depositar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_depositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_depositar.Location = new System.Drawing.Point(965, 1038);
            this.Btn_depositar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Btn_depositar.Name = "Btn_depositar";
            this.Btn_depositar.Size = new System.Drawing.Size(475, 120);
            this.Btn_depositar.TabIndex = 11;
            this.Btn_depositar.Text = "Depositar";
            this.Btn_depositar.UseVisualStyleBackColor = false;
            this.Btn_depositar.Click += new System.EventHandler(this.Btn_depositar_Click);
            // 
            // Btn_sacar
            // 
            this.Btn_sacar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_sacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sacar.Location = new System.Drawing.Point(256, 1038);
            this.Btn_sacar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Btn_sacar.Name = "Btn_sacar";
            this.Btn_sacar.Size = new System.Drawing.Size(491, 120);
            this.Btn_sacar.TabIndex = 10;
            this.Btn_sacar.Text = "Sacar";
            this.Btn_sacar.UseVisualStyleBackColor = false;
            this.Btn_sacar.Click += new System.EventHandler(this.Btn_sacar_Click);
            // 
            // Btn_saldo
            // 
            this.Btn_saldo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_saldo.Location = new System.Drawing.Point(965, 827);
            this.Btn_saldo.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Btn_saldo.Name = "Btn_saldo";
            this.Btn_saldo.Size = new System.Drawing.Size(475, 120);
            this.Btn_saldo.TabIndex = 8;
            this.Btn_saldo.Text = "Consultar Saldo";
            this.Btn_saldo.UseVisualStyleBackColor = false;
            this.Btn_saldo.Click += new System.EventHandler(this.Btn_saldo_Click);
            // 
            // Btn_cadastrar
            // 
            this.Btn_cadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cadastrar.Location = new System.Drawing.Point(1452, 455);
            this.Btn_cadastrar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Btn_cadastrar.Name = "Btn_cadastrar";
            this.Btn_cadastrar.Size = new System.Drawing.Size(649, 97);
            this.Btn_cadastrar.TabIndex = 6;
            this.Btn_cadastrar.Text = "Cadastrar";
            this.Btn_cadastrar.UseVisualStyleBackColor = false;
            this.Btn_cadastrar.Click += new System.EventHandler(this.Btn_cadastrar_Click);
            // 
            // Btn_limpar
            // 
            this.Btn_limpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limpar.Location = new System.Drawing.Point(1626, 827);
            this.Btn_limpar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Btn_limpar.Name = "Btn_limpar";
            this.Btn_limpar.Size = new System.Drawing.Size(475, 120);
            this.Btn_limpar.TabIndex = 9;
            this.Btn_limpar.Text = "Limpar Dados";
            this.Btn_limpar.UseVisualStyleBackColor = false;
            this.Btn_limpar.Click += new System.EventHandler(this.Btn_limpar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(906, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(557, 69);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cadastro de Cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(166, 630);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2006, 10);
            this.panel1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(953, 675);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(469, 69);
            this.label5.TabIndex = 15;
            this.label5.Text = "Menu de opções";
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2321, 1281);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_limpar);
            this.Controls.Add(this.Btn_cadastrar);
            this.Controls.Add(this.Btn_saldo);
            this.Controls.Add(this.Btn_sacar);
            this.Controls.Add(this.Btn_depositar);
            this.Controls.Add(this.Btn_sair);
            this.Controls.Add(this.Btn_mostrar);
            this.Controls.Add(this.Txb_conta);
            this.Controls.Add(this.Txb_saldo);
            this.Controls.Add(this.Txb_titular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Bancário";
            this.Load += new System.EventHandler(this.Frm_principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txb_titular;
        private System.Windows.Forms.TextBox Txb_saldo;
        private System.Windows.Forms.TextBox Txb_conta;
        private System.Windows.Forms.Button Btn_mostrar;
        private System.Windows.Forms.Button Btn_sair;
        private System.Windows.Forms.Button Btn_depositar;
        private System.Windows.Forms.Button Btn_sacar;
        private System.Windows.Forms.Button Btn_saldo;
        private System.Windows.Forms.Button Btn_cadastrar;
        private System.Windows.Forms.Button Btn_limpar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}

