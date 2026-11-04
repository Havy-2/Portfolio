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
    public partial class Frm_deposito : Form
    {
        private Conta cliente;
        public Frm_deposito(Object cli)
        {
            InitializeComponent();
            cliente = (Conta)cli;
            Txb_saldo.Text = Convert.ToString(cliente.Saldo);
        }
        private void Btn_depositar_Click(object sender, EventArgs e)
        {
            if (Txb_deposito.Text !="" && Convert.ToDouble(Txb_deposito.Text) > 0)
            {
                cliente.Saldo = cliente.Saldo + Convert.ToDouble(Txb_deposito.Text);
                Txb_saldo.Text = Convert.ToString(cliente.Saldo);
                MessageBox.Show("Deposito realizado com sucesso.");
                Txb_deposito.Clear();
            }
            else
            {
                MessageBox.Show("Preencha o valor do deposito corretamente.");
            }
            
        }

        private void Frm_deposito_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
