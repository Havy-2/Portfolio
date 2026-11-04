using System;
using System.Windows.Forms;

namespace ContaBancaria
{
    public partial class Frm_sacar : Form
    {
        public Frm_sacar()
        {
            InitializeComponent();
        }

        private void Frm_sacar_Load(object sender, EventArgs e)
        {
            if (Frm_principal.contaAtual != null)
            {
                TXT_saldo.Text = Frm_principal.contaAtual.Saldo.ToString("F2");
                TXT_saldo.ReadOnly = true;
            }
        }

        private void btn_sacar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(TXT_valor.Text);

            if (Frm_principal.contaAtual.Sacar(valor))
            {
                MessageBox.Show("Saque realizado com sucesso");
                TXT_saldo.Text = Frm_principal.contaAtual.Saldo.ToString("F2");
                TXT_valor.Clear();
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
