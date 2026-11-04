using System;
using System.Windows.Forms;

namespace ContaBancaria
{
    public partial class Frm_principal : Form
    {
        public static Conta contaAtual;

        public Frm_principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (TXT_nome.Text == "" || TXT_conta.Text == "" || TXT_saldo.Text == "")
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            contaAtual = new Conta();
            contaAtual.Titular = TXT_nome.Text;
            contaAtual.NumeroConta = Convert.ToInt32(TXT_conta.Text);
            contaAtual.Saldo = Convert.ToDouble(TXT_saldo.Text);

            MessageBox.Show("Conta cadastrada com sucesso!");
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            if (contaAtual == null)
            {
                MessageBox.Show("Nenhuma conta cadastrada.");
                return;
            }

            Frm_dadosClientes frm = new Frm_dadosClientes();
            frm.ShowDialog();
        }

        private void btn_consoltar_Click(object sender, EventArgs e)
        {
            if (contaAtual == null)
            {
                MessageBox.Show("Nenhuma conta cadastrada.");
                return;
            }

            MessageBox.Show("Saldo atual: R$ " + contaAtual.Saldo.ToString("F2"));
        }

        private void btn_linpar_Click(object sender, EventArgs e)
        {
            TXT_nome.Clear();
            TXT_conta.Clear();
            TXT_saldo.Clear();
            TXT_nome.Focus();
        }

        private void btn_sacar_Click(object sender, EventArgs e)
        {
            if (contaAtual == null)
            {
                MessageBox.Show("Nenhuma conta cadastrada.");
                return;
            }

            Frm_sacar frm = new Frm_sacar();
            frm.ShowDialog();
        }

        private void btn_depositar_Click(object sender, EventArgs e)
        {
            if (contaAtual == null)
            {
                MessageBox.Show("Nenhuma conta cadastrada.");
                return;
            }

            Frm_deposito frm = new Frm_deposito();
            frm.ShowDialog();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
