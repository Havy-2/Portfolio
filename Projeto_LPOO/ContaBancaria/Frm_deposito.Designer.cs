namespace ContaBancaria
{
    partial class Frm_deposito
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
            this.TXT_saldo = new System.Windows.Forms.TextBox();
            this.TXT_valor = new System.Windows.Forms.TextBox();
            this.btn_depositar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o valor do deposito:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TXT_saldo
            // 
            this.TXT_saldo.Location = new System.Drawing.Point(279, 73);
            this.TXT_saldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_saldo.Name = "TXT_saldo";
            this.TXT_saldo.Size = new System.Drawing.Size(148, 26);
            this.TXT_saldo.TabIndex = 2;
            // 
            // TXT_valor
            // 
            this.TXT_valor.Location = new System.Drawing.Point(279, 133);
            this.TXT_valor.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_valor.Name = "TXT_valor";
            this.TXT_valor.Size = new System.Drawing.Size(148, 26);
            this.TXT_valor.TabIndex = 3;
            this.TXT_valor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_depositar
            // 
            this.btn_depositar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_depositar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_depositar.Location = new System.Drawing.Point(191, 212);
            this.btn_depositar.Name = "btn_depositar";
            this.btn_depositar.Size = new System.Drawing.Size(158, 39);
            this.btn_depositar.TabIndex = 4;
            this.btn_depositar.Text = "Depositar";
            this.btn_depositar.UseVisualStyleBackColor = false;
            this.btn_depositar.Click += new System.EventHandler(this.btn_depositar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_sair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(191, 290);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(158, 39);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Frm_deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(504, 408);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_depositar);
            this.Controls.Add(this.TXT_valor);
            this.Controls.Add(this.TXT_saldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_deposito";
            this.Text = "Depositar";
            this.Load += new System.EventHandler(this.Frm_deposito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_saldo;
        private System.Windows.Forms.TextBox TXT_valor;
        private System.Windows.Forms.Button btn_depositar;
        private System.Windows.Forms.Button btn_sair;
    }
}