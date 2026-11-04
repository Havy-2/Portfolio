namespace ContaBancaria
{
    partial class Frm_sacar
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
            this.btn_sacar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o valor do saque:";
            // 
            // TXT_saldo
            // 
            this.TXT_saldo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_saldo.Location = new System.Drawing.Point(296, 91);
            this.TXT_saldo.Name = "TXT_saldo";
            this.TXT_saldo.Size = new System.Drawing.Size(100, 26);
            this.TXT_saldo.TabIndex = 2;
            // 
            // TXT_valor
            // 
            this.TXT_valor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_valor.Location = new System.Drawing.Point(296, 147);
            this.TXT_valor.Name = "TXT_valor";
            this.TXT_valor.Size = new System.Drawing.Size(100, 26);
            this.TXT_valor.TabIndex = 3;
            // 
            // btn_sacar
            // 
            this.btn_sacar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_sacar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sacar.Location = new System.Drawing.Point(177, 219);
            this.btn_sacar.Name = "btn_sacar";
            this.btn_sacar.Size = new System.Drawing.Size(179, 39);
            this.btn_sacar.TabIndex = 4;
            this.btn_sacar.Text = "Sacar";
            this.btn_sacar.UseVisualStyleBackColor = false;
            this.btn_sacar.Click += new System.EventHandler(this.btn_sacar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_sair.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(177, 290);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(179, 39);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Frm_sacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(479, 416);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_sacar);
            this.Controls.Add(this.TXT_valor);
            this.Controls.Add(this.TXT_saldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_sacar";
            this.Text = "Efetuar saque";
            this.Load += new System.EventHandler(this.Frm_sacar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_saldo;
        private System.Windows.Forms.TextBox TXT_valor;
        private System.Windows.Forms.Button btn_sacar;
        private System.Windows.Forms.Button btn_sair;
    }
}