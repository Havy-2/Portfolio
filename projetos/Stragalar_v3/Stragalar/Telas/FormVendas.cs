using System;
using System.Windows.Forms;
using Stragalar.Dados;

namespace Stragalar.Telas
{
    public partial class FormVendas : Form
    {
        private readonly VendaDAO dao = new VendaDAO();
        private int idVendaAtual = 0;
        private decimal totalAtual = 0;
        private int idUsuarioLogado = 1;

        public FormVendas()
        {
            InitializeComponent();
            CarregarProdutos();
            CarregarVendasDoDia();
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

        private void CarregarItens()
        {
            if (idVendaAtual == 0) return;
            try { dgvItens.DataSource = dao.ListarItensDaVenda(idVendaAtual); }
            catch { }
        }

        private void CarregarVendasDoDia()
        {
            try { dgvVendas.DataSource = dao.ListarVendasDoDia(); }
            catch { }
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            try
            {
                idVendaAtual = dao.AbrirVenda(idUsuarioLogado);
                totalAtual = 0;
                lblVenda.Text = "Venda #" + idVendaAtual;
                lblTotal.Text = "Total: R$ 0,00";
                CarregarItens();
                MessageBox.Show("Nova venda aberta!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (idVendaAtual == 0)
            {
                MessageBox.Show("Abra uma venda primeiro.");
                return;
            }
            if (cmbProduto.SelectedValue == null) return;
            if (!decimal.TryParse(txtQtd.Text, out var qtd) || qtd <= 0)
            {
                MessageBox.Show("Quantidade inválida.");
                return;
            }

            int idProduto = Convert.ToInt32(cmbProduto.SelectedValue);
            // Preço simples: pega da linha selecionada se possível; senão 0
            decimal preco = 0;
            if (cmbProduto.SelectedItem is System.Data.DataRowView row)
                preco = Convert.ToDecimal(row["preco"]);

            try
            {
                dao.AdicionarItem(idVendaAtual, idProduto, qtd, preco);
                totalAtual += qtd * preco;
                lblTotal.Text = "Total: R$ " + totalAtual.ToString("N2");
                txtQtd.Clear();
                CarregarItens();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (idVendaAtual == 0)
            {
                MessageBox.Show("Nenhuma venda aberta.");
                return;
            }

            string forma = cmbPagamento.Text;
            if (string.IsNullOrEmpty(forma)) forma = "Dinheiro";

            try
            {
                dao.FinalizarVenda(idVendaAtual, forma, totalAtual);
                MessageBox.Show("Venda finalizada!");
                idVendaAtual = 0;
                totalAtual = 0;
                lblVenda.Text = "Nenhuma venda aberta";
                lblTotal.Text = "Total: R$ 0,00";
                dgvItens.DataSource = null;
                CarregarVendasDoDia();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
