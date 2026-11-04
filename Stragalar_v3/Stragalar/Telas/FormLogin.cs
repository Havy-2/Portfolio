using System;
using System.Windows.Forms;
using Stragalar.Dados;

namespace Stragalar.Telas
{
    public partial class FormLogin : Form
    {
        private readonly UsuarioDAO dao = new UsuarioDAO();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Informe login e senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string nome, funcao;
                if (dao.Validar(login, senha, out nome, out funcao))
                {
                    this.Hide();
                    new FormPrincipal(nome, funcao).Show();
                }
                else
                {
                    MessageBox.Show("Login ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
