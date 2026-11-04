using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Frm_saque : Form
    {
        private Conta cliente;
        public Frm_saque(Object cli)
        {
            InitializeComponent();
            cliente = (Conta) cli;
            Txb_saldo.Text = Convert.ToString(cliente.Saldo);
        }

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Btn_sacar_Click(object sender, EventArgs e)
        {
            if (Txb_saque.Text == "" || Convert.ToDouble(Txb_saque.Text) > cliente.Saldo)
            {
                MessageBox.Show("Saldo insuficiente ou campo em branco.");
            }
            else
            {
                cliente.Saldo = (cliente.Saldo - Convert.ToDouble(Txb_saque.Text));
                Txb_saldo.Text = Convert.ToString(cliente.Saldo);
                MessageBox.Show("Saque realizado com sucesso.");
                Txb_saque.Clear();
            }
        }

        private void Txb_saque_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txb_saldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
