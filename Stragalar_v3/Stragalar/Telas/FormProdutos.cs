using System;
using System.Windows.Forms;
using Stragalar.Dados;
using Stragalar.Modelos;

namespace Stragalar.Telas
{
    public partial class FormProdutos : Form
    {
        private readonly ProdutoDAO dao = new ProdutoDAO();

        public FormProdutos()
        {
            InitializeComponent();
            Carregar();
        }

        private void Carregar()
        {
            try { dgv.DataSource = dao.Listar(); }
            catch { /* banco pode não estar disponível */ }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do produto.");
                return;
            }

            var p = new Produto
            {
                Nome = txtNome.Text.Trim(),
                Categoria = txtCategoria.Text.Trim(),
                UnidadeMedida = "Unidade",
                Preco = decimal.TryParse(txtPreco.Text, out var pr) ? pr : 0,
                QuantidadeEstoque = decimal.TryParse(txtQtd.Text, out var q) ? q : 0
            };

            try
            {
                dao.Inserir(p);
                MessageBox.Show("Produto cadastrado!");
                txtNome.Clear(); txtCategoria.Clear(); txtPreco.Clear(); txtQtd.Clear();
                Carregar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
