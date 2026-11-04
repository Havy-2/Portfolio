namespace Banco
{
    partial class Frm_dadosCliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.Txb_titular = new System.Windows.Forms.TextBox();
            this.Txb_saldo = new System.Windows.Forms.TextBox();
            this.Txb_conta = new System.Windows.Forms.TextBox();
            this.BTN_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do titular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nº da conta:";
            // 
            // Txb_titular
            // 
            this.Txb_titular.Enabled = false;
            this.Txb_titular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_titular.Location = new System.Drawing.Point(524, 127);
            this.Txb_titular.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txb_titular.Name = "Txb_titular";
            this.Txb_titular.Size = new System.Drawing.Size(608, 51);
            this.Txb_titular.TabIndex = 3;
            // 
            // Txb_saldo
            // 
            this.Txb_saldo.Enabled = false;
            this.Txb_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_saldo.Location = new System.Drawing.Point(524, 385);
            this.Txb_saldo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txb_saldo.Name = "Txb_saldo";
            this.Txb_saldo.Size = new System.Drawing.Size(352, 51);
            this.Txb_saldo.TabIndex = 4;
            // 
            // Txb_conta
            // 
            this.Txb_conta.Enabled = false;
            this.Txb_conta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_conta.Location = new System.Drawing.Point(524, 263);
            this.Txb_conta.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Txb_conta.Name = "Txb_conta";
            this.Txb_conta.Size = new System.Drawing.Size(352, 51);
            this.Txb_conta.TabIndex = 5;
            // 
            // BTN_voltar
            // 
            this.BTN_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_voltar.Location = new System.Drawing.Point(504, 604);
            this.BTN_voltar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BTN_voltar.Name = "BTN_voltar";
            this.BTN_voltar.Size = new System.Drawing.Size(376, 90);
            this.BTN_voltar.TabIndex = 6;
            this.BTN_voltar.Text = "Voltar";
            this.BTN_voltar.UseVisualStyleBackColor = true;
            this.BTN_voltar.Click += new System.EventHandler(this.BTN_voltar_Click);
            // 
            // Frm_dadosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 806);
            this.Controls.Add(this.BTN_voltar);
            this.Controls.Add(this.Txb_conta);
            this.Controls.Add(this.Txb_saldo);
            this.Controls.Add(this.Txb_titular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_dadosCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados do Cliente";
            this.Load += new System.EventHandler(this.Frm_dadosCliente_Load);
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
        private System.Windows.Forms.Button BTN_voltar;
    }
}