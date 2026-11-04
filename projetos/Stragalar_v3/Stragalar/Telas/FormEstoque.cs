using System;
using System.Windows.Forms;
using Stragalar.Dados;

namespace Stragalar.Telas
{
    public partial class FormEstoque : Form
    {
        private readonly EstoqueDAO dao = new EstoqueDAO();
        private int idUsuarioLogado = 1; // pode ser passado do login futuramente

        public FormEstoque()
        {
            InitializeComponent();
            CarregarProdutos();
            CarregarMovimentacoes();
        }

        private void CarregarProdutos()
        {
            try
            {
                cmbProduto.DataSource = dao.ListarProdutos();
                cmbProduto.DisplayMember = "nomeProduto";
                cmbProduto.ValueMember = "idProduto";
            }
            catch { }
        }

        private void CarregarMovimentacoes()
        {
            try { dgv.DataSource = dao.ListarMovimentacoes(); }
            catch { }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbProduto.SelectedValue == null)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }
            if (!decimal.TryParse(txtQuantidade.Text, out var qtd) || qtd <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida.");
                return;
            }

            string tipo = rdbEntrada.Checked ? "Entrada" : "Saída";
            int idProduto = Convert.ToInt32(cmbProduto.SelectedValue);

            try
            {
                dao.RegistrarMovimentacao(idProduto, idUsuarioLogado, tipo, qtd, txtMotivo.Text.Trim());
                MessageBox.Show("Movimentação registrada!");
                txtQuantidade.Clear();
                txtMotivo.Clear();
                CarregarProdutos();
                CarregarMovimentacoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
