using System;
using System.Windows.Forms;

namespace ContaBancaria
{
    public partial class Frm_deposito : Form
    {
        public Frm_deposito()
        {
            InitializeComponent();
        }

        private void Frm_deposito_Load(object sender, EventArgs e)
        {
            if (Frm_principal.contaAtual != null)
            {
                TXT_saldo.Text = Frm_principal.contaAtual.Saldo.ToString("F2");
                TXT_saldo.ReadOnly = true;
            }
        }

        private void btn_depositar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(TXT_valor.Text);

            if (Frm_principal.contaAtual.Depositar(valor))
            {
                MessageBox.Show("Depósito realizado com sucesso!");
                TXT_saldo.Text = Frm_principal.contaAtual.Saldo.ToString("F2");
                TXT_valor.Clear();
            }
            else
            {
                MessageBox.Show("Informe um valor maior que zero.");
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
