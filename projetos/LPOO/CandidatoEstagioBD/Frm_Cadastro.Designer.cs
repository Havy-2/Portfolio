namespace CandidatoEstagio
{
    partial class Frm_Cadastro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_nome = new System.Windows.Forms.TextBox();
            this.TXT_dia = new System.Windows.Forms.TextBox();
            this.TXT_mes = new System.Windows.Forms.TextBox();
            this.TXT_ano = new System.Windows.Forms.TextBox();
            this.TXT_idade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RBT_adm = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTN_calcular = new System.Windows.Forms.Button();
            this.CMB_escolaridade = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CKB_noturno = new System.Windows.Forms.CheckBox();
            this.CKB_vespertino = new System.Windows.Forms.CheckBox();
            this.CKB_matutino = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RBT_saude = new System.Windows.Forms.RadioButton();
            this.RBT_engenharia = new System.Windows.Forms.RadioButton();
            this.RBT_computacao = new System.Windows.Forms.RadioButton();
            this.BTN_enviar = new System.Windows.Forms.Button();
            this.BTN_limpar = new System.Windows.Forms.Button();
            this.BTN_sair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(145, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de candidato a estagio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(139, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(30, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Idade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(30, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data de Nacimento:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TXT_nome
            // 
            this.TXT_nome.Location = new System.Drawing.Point(208, 22);
            this.TXT_nome.Name = "TXT_nome";
            this.TXT_nome.Size = new System.Drawing.Size(468, 20);
            this.TXT_nome.TabIndex = 3;
            // 
            // TXT_dia
            // 
            this.TXT_dia.Location = new System.Drawing.Point(208, 53);
            this.TXT_dia.Name = "TXT_dia";
            this.TXT_dia.Size = new System.Drawing.Size(47, 20);
            this.TXT_dia.TabIndex = 4;
            // 
            // TXT_mes
            // 
            this.TXT_mes.Location = new System.Drawing.Point(261, 53);
            this.TXT_mes.Name = "TXT_mes";
            this.TXT_mes.Size = new System.Drawing.Size(47, 20);
            this.TXT_mes.TabIndex = 5;
            // 
            // TXT_ano
            // 
            this.TXT_ano.Location = new System.Drawing.Point(314, 53);
            this.TXT_ano.Name = "TXT_ano";
            this.TXT_ano.Size = new System.Drawing.Size(47, 20);
            this.TXT_ano.TabIndex = 6;
            // 
            // TXT_idade
            // 
            this.TXT_idade.Location = new System.Drawing.Point(97, 125);
            this.TXT_idade.Name = "TXT_idade";
            this.TXT_idade.Size = new System.Drawing.Size(100, 20);
            this.TXT_idade.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(30, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Aria de atuação";
            // 
            // RBT_adm
            // 
            this.RBT_adm.AutoSize = true;
            this.RBT_adm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBT_adm.Location = new System.Drawing.Point(34, 231);
            this.RBT_adm.Name = "RBT_adm";
            this.RBT_adm.Size = new System.Drawing.Size(141, 24);
            this.RBT_adm.TabIndex = 9;
            this.RBT_adm.TabStop = true;
            this.RBT_adm.Text = "Administração";
            this.RBT_adm.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BTN_sair);
            this.panel2.Controls.Add(this.BTN_limpar);
            this.panel2.Controls.Add(this.BTN_enviar);
            this.panel2.Controls.Add(this.BTN_calcular);
            this.panel2.Controls.Add(this.CMB_escolaridade);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.CKB_noturno);
            this.panel2.Controls.Add(this.CKB_vespertino);
            this.panel2.Controls.Add(this.CKB_matutino);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.RBT_saude);
            this.panel2.Controls.Add(this.RBT_engenharia);
            this.panel2.Controls.Add(this.RBT_computacao);
            this.panel2.Controls.Add(this.RBT_adm);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TXT_idade);
            this.panel2.Controls.Add(this.TXT_ano);
            this.panel2.Controls.Add(this.TXT_mes);
            this.panel2.Controls.Add(this.TXT_dia);
            this.panel2.Controls.Add(this.TXT_nome);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 620);
            this.panel2.TabIndex = 1;
            // 
            // BTN_calcular
            // 
            this.BTN_calcular.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTN_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_calcular.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_calcular.Location = new System.Drawing.Point(220, 119);
            this.BTN_calcular.Name = "BTN_calcular";
            this.BTN_calcular.Size = new System.Drawing.Size(123, 29);
            this.BTN_calcular.TabIndex = 20;
            this.BTN_calcular.Text = "Calcular";
            this.BTN_calcular.UseVisualStyleBackColor = false;
            this.BTN_calcular.Click += new System.EventHandler(this.BTN_calcular_Click);
            // 
            // CMB_escolaridade
            // 
            this.CMB_escolaridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_escolaridade.FormattingEnabled = true;
            this.CMB_escolaridade.Items.AddRange(new object[] {
            "Médio",
            "Técnico",
            "Superior"});
            this.CMB_escolaridade.Location = new System.Drawing.Point(34, 524);
            this.CMB_escolaridade.Name = "CMB_escolaridade";
            this.CMB_escolaridade.Size = new System.Drawing.Size(121, 21);
            this.CMB_escolaridade.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(30, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Escolaridade";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CKB_noturno
            // 
            this.CKB_noturno.AutoSize = true;
            this.CKB_noturno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKB_noturno.Location = new System.Drawing.Point(34, 445);
            this.CKB_noturno.Name = "CKB_noturno";
            this.CKB_noturno.Size = new System.Drawing.Size(92, 24);
            this.CKB_noturno.TabIndex = 17;
            this.CKB_noturno.Text = "Noturno";
            this.CKB_noturno.UseVisualStyleBackColor = true;
            // 
            // CKB_vespertino
            // 
            this.CKB_vespertino.AutoSize = true;
            this.CKB_vespertino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKB_vespertino.Location = new System.Drawing.Point(34, 415);
            this.CKB_vespertino.Name = "CKB_vespertino";
            this.CKB_vespertino.Size = new System.Drawing.Size(115, 24);
            this.CKB_vespertino.TabIndex = 16;
            this.CKB_vespertino.Text = "Vespertino";
            this.CKB_vespertino.UseVisualStyleBackColor = true;
            // 
            // CKB_matutino
            // 
            this.CKB_matutino.AutoSize = true;
            this.CKB_matutino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKB_matutino.Location = new System.Drawing.Point(34, 385);
            this.CKB_matutino.Name = "CKB_matutino";
            this.CKB_matutino.Size = new System.Drawing.Size(98, 24);
            this.CKB_matutino.TabIndex = 15;
            this.CKB_matutino.Text = "Matutino";
            this.CKB_matutino.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(30, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Disponibilidade para o estagio";
            // 
            // RBT_saude
            // 
            this.RBT_saude.AutoSize = true;
            this.RBT_saude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBT_saude.Location = new System.Drawing.Point(34, 321);
            this.RBT_saude.Name = "RBT_saude";
            this.RBT_saude.Size = new System.Drawing.Size(79, 24);
            this.RBT_saude.TabIndex = 12;
            this.RBT_saude.TabStop = true;
            this.RBT_saude.Text = "Saude";
            this.RBT_saude.UseVisualStyleBackColor = true;
            // 
            // RBT_engenharia
            // 
            this.RBT_engenharia.AutoSize = true;
            this.RBT_engenharia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBT_engenharia.Location = new System.Drawing.Point(34, 291);
            this.RBT_engenharia.Name = "RBT_engenharia";
            this.RBT_engenharia.Size = new System.Drawing.Size(119, 24);
            this.RBT_engenharia.TabIndex = 11;
            this.RBT_engenharia.TabStop = true;
            this.RBT_engenharia.Text = "Engenharia";
            this.RBT_engenharia.UseVisualStyleBackColor = true;
            this.RBT_engenharia.CheckedChanged += new System.EventHandler(this.RBT_engenharia_CheckedChanged);
            // 
            // RBT_computacao
            // 
            this.RBT_computacao.AutoSize = true;
            this.RBT_computacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBT_computacao.Location = new System.Drawing.Point(34, 261);
            this.RBT_computacao.Name = "RBT_computacao";
            this.RBT_computacao.Size = new System.Drawing.Size(128, 24);
            this.RBT_computacao.TabIndex = 10;
            this.RBT_computacao.TabStop = true;
            this.RBT_computacao.Text = "Computação";
            this.RBT_computacao.UseVisualStyleBackColor = true;
            // 
            // BTN_enviar
            // 
            this.BTN_enviar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTN_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_enviar.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_enviar.Location = new System.Drawing.Point(80, 570);
            this.BTN_enviar.Name = "BTN_enviar";
            this.BTN_enviar.Size = new System.Drawing.Size(123, 29);
            this.BTN_enviar.TabIndex = 21;
            this.BTN_enviar.Text = "Enviar";
            this.BTN_enviar.UseVisualStyleBackColor = false;
            this.BTN_enviar.Click += new System.EventHandler(this.BTN_enviar_Click);
            // 
            // BTN_limpar
            // 
            this.BTN_limpar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTN_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_limpar.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_limpar.Location = new System.Drawing.Point(320, 570);
            this.BTN_limpar.Name = "BTN_limpar";
            this.BTN_limpar.Size = new System.Drawing.Size(123, 29);
            this.BTN_limpar.TabIndex = 22;
            this.BTN_limpar.Text = "Limpar";
            this.BTN_limpar.UseVisualStyleBackColor = false;
            this.BTN_limpar.Click += new System.EventHandler(this.BTN_limpar_Click);
            // 
            // BTN_sair
            // 
            this.BTN_sair.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTN_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_sair.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_sair.Location = new System.Drawing.Point(560, 570);
            this.BTN_sair.Name = "BTN_sair";
            this.BTN_sair.Size = new System.Drawing.Size(123, 29);
            this.BTN_sair.TabIndex = 21;
            this.BTN_sair.Text = "Sair";
            this.BTN_sair.UseVisualStyleBackColor = false;
            this.BTN_sair.Click += new System.EventHandler(this.BTN_sair_Click);
            // 
            // Frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 710);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Candidatos de Estágio";
            this.Load += new System.EventHandler(this.Frm_Cadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_nome;
        private System.Windows.Forms.TextBox TXT_dia;
        private System.Windows.Forms.TextBox TXT_mes;
        private System.Windows.Forms.TextBox TXT_ano;
        private System.Windows.Forms.TextBox TXT_idade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RBT_adm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RBT_saude;
        private System.Windows.Forms.RadioButton RBT_engenharia;
        private System.Windows.Forms.RadioButton RBT_computacao;
        private System.Windows.Forms.CheckBox CKB_matutino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CKB_noturno;
        private System.Windows.Forms.CheckBox CKB_vespertino;
        private System.Windows.Forms.ComboBox CMB_escolaridade;
        private System.Windows.Forms.Button BTN_calcular;
        private System.Windows.Forms.Button BTN_enviar;
        private System.Windows.Forms.Button BTN_limpar;
        private System.Windows.Forms.Button BTN_sair;
    }
}

