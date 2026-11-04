using System;
using System.Windows.Forms;

namespace ContaBancaria
{
    public partial class Frm_dadosClientes : Form
    {
        public Frm_dadosClientes()
        {
            InitializeComponent();
        }

        private void Frm_dadosClientes_Load(object sender, EventArgs e)
        {
            if (Frm_principal.contaAtual != null)
            {
                TXT_nome.Text = Frm_principal.contaAtual.Titular;
                TXT_conta.Text = Frm_principal.contaAtual.NumeroConta.ToString();
                TXT_saldo.Text = Frm_principal.contaAtual.Saldo.ToString("F2");
                TXT_nome.ReadOnly = true;
                TXT_conta.ReadOnly = true;
                TXT_saldo.ReadOnly = true;
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
