namespace Banco
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
            this.Btn_sair = new System.Windows.Forms.Button();
            this.Btn_depositar = new System.Windows.Forms.Button();
            this.Txb_deposito = new System.Windows.Forms.TextBox();
            this.Txb_saldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_sair
            // 
            this.Btn_sair.BackColor = System.Drawing.Color.Coral;
            this.Btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sair.ForeColor = System.Drawing.Color.Black;
            this.Btn_sair.Location = new System.Drawing.Point(217, 393);
            this.Btn_sair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_sair.Name = "Btn_sair";
            this.Btn_sair.Size = new System.Drawing.Size(259, 48);
            this.Btn_sair.TabIndex = 11;
            this.Btn_sair.Text = "Voltar";
            this.Btn_sair.UseVisualStyleBackColor = false;
            this.Btn_sair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // Btn_depositar
            // 
            this.Btn_depositar.BackColor = System.Drawing.Color.Coral;
            this.Btn_depositar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_depositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_depositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_depositar.ForeColor = System.Drawing.Color.Black;
            this.Btn_depositar.Location = new System.Drawing.Point(217, 315);
            this.Btn_depositar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_depositar.Name = "Btn_depositar";
            this.Btn_depositar.Size = new System.Drawing.Size(259, 48);
            this.Btn_depositar.TabIndex = 10;
            this.Btn_depositar.Text = "Depositar";
            this.Btn_depositar.UseVisualStyleBackColor = false;
            this.Btn_depositar.Click += new System.EventHandler(this.Btn_depositar_Click);
            // 
            // Txb_deposito
            // 
            this.Txb_deposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_deposito.Location = new System.Drawing.Point(372, 198);
            this.Txb_deposito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txb_deposito.Name = "Txb_deposito";
            this.Txb_deposito.Size = new System.Drawing.Size(132, 30);
            this.Txb_deposito.TabIndex = 9;
            // 
            // Txb_saldo
            // 
            this.Txb_saldo.Enabled = false;
            this.Txb_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_saldo.Location = new System.Drawing.Point(372, 129);
            this.Txb_saldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txb_saldo.Name = "Txb_saldo";
            this.Txb_saldo.Size = new System.Drawing.Size(132, 30);
            this.Txb_saldo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Digite o valor do deposito:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Saldo:";
            // 
            // Frm_deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 554);
            this.Controls.Add(this.Btn_sair);
            this.Controls.Add(this.Btn_depositar);
            this.Controls.Add(this.Txb_deposito);
            this.Controls.Add(this.Txb_saldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_deposito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depositar";
            this.Load += new System.EventHandler(this.Frm_deposito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_sair;
        private System.Windows.Forms.Button Btn_depositar;
        private System.Windows.Forms.TextBox Txb_deposito;
        private System.Windows.Forms.TextBox Txb_saldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}