namespace Banco
{
    partial class Frm_saque
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_saldo = new System.Windows.Forms.TextBox();
            this.Txb_saque = new System.Windows.Forms.TextBox();
            this.Btn_sacar = new System.Windows.Forms.Button();
            this.Btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(653, 310);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 486);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o valor do saque:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txb_saldo
            // 
            this.Txb_saldo.Enabled = false;
            this.Txb_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_saldo.Location = new System.Drawing.Point(895, 310);
            this.Txb_saldo.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Txb_saldo.Name = "Txb_saldo";
            this.Txb_saldo.Size = new System.Drawing.Size(308, 62);
            this.Txb_saldo.TabIndex = 2;
            this.Txb_saldo.TextChanged += new System.EventHandler(this.Txb_saldo_TextChanged);
            // 
            // Txb_saque
            // 
            this.Txb_saque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_saque.Location = new System.Drawing.Point(895, 469);
            this.Txb_saque.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Txb_saque.Name = "Txb_saque";
            this.Txb_saque.Size = new System.Drawing.Size(308, 62);
            this.Txb_saque.TabIndex = 3;
            this.Txb_saque.TextChanged += new System.EventHandler(this.Txb_saque_TextChanged);
            // 
            // Btn_sacar
            // 
            this.Btn_sacar.BackColor = System.Drawing.Color.Coral;
            this.Btn_sacar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_sacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_sacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sacar.ForeColor = System.Drawing.Color.Black;
            this.Btn_sacar.Location = new System.Drawing.Point(530, 740);
            this.Btn_sacar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Btn_sacar.Name = "Btn_sacar";
            this.Btn_sacar.Size = new System.Drawing.Size(615, 111);
            this.Btn_sacar.TabIndex = 4;
            this.Btn_sacar.Text = "Sacar";
            this.Btn_sacar.UseVisualStyleBackColor = false;
            this.Btn_sacar.Click += new System.EventHandler(this.Btn_sacar_Click);
            // 
            // Btn_sair
            // 
            this.Btn_sair.BackColor = System.Drawing.Color.Coral;
            this.Btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sair.ForeColor = System.Drawing.Color.Black;
            this.Btn_sair.Location = new System.Drawing.Point(530, 920);
            this.Btn_sair.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Btn_sair.Name = "Btn_sair";
            this.Btn_sair.Size = new System.Drawing.Size(615, 111);
            this.Btn_sair.TabIndex = 5;
            this.Btn_sair.Text = "Voltar";
            this.Btn_sair.UseVisualStyleBackColor = false;
            this.Btn_sair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // Frm_saque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 1281);
            this.Controls.Add(this.Btn_sair);
            this.Controls.Add(this.Btn_sacar);
            this.Controls.Add(this.Txb_saque);
            this.Controls.Add(this.Txb_saldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_saque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Efetuar saque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txb_saldo;
        private System.Windows.Forms.TextBox Txb_saque;
        private System.Windows.Forms.Button Btn_sacar;
        private System.Windows.Forms.Button Btn_sair;
    }
}