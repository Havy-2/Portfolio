using System;
using System.Drawing;
using System.Windows.Forms;
using Stragalar.Telas;

namespace Stragalar.Telas
{
    public partial class FormPrincipal : Form
    {
        private Form formularioAtivo;
        private readonly string nomeUsuario;
        private readonly string funcao;

        public FormPrincipal(string nome, string funcao)
        {
            InitializeComponent();
            this.nomeUsuario = nome;
            this.funcao = funcao;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Usuário: {nomeUsuario} ({funcao})";
            AbrirFormulario(new FormInicio());
        }

        private void AbrirFormulario(Form form)
        {
            if (formularioAtivo != null)
            {
                formularioAtivo.Close();
                formularioAtivo.Dispose();
            }

            formularioAtivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(form);
            form.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e) => AbrirFormulario(new FormInicio());
        private void btnProdutos_Click(object sender, EventArgs e) => AbrirFormulario(new FormProdutos());
        private void btnEstoque_Click(object sender, EventArgs e) => AbrirFormulario(new FormEstoque());
        private void btnVendas_Click(object sender, EventArgs e) => AbrirFormulario(new FormVendas());
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
