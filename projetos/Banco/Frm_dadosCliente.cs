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
    public partial class Frm_dadosCliente : Form
    {
        private Conta clienteDados;
        public Frm_dadosCliente(Object cliente)
        {
            InitializeComponent();
            this.clienteDados = (Conta)cliente;
            Txb_titular.Text = clienteDados.Titular;
            Txb_conta.Text = Convert.ToString(clienteDados.NumeroConta);
            Txb_saldo.Text = Convert.ToString(clienteDados.Saldo);
        }

        private void Frm_dadosCliente_Load(object sender, EventArgs e)
        {

        }

        private void BTN_voltar_Click(object sender, EventArgs e)
        {
            Dispose(); // fecha a form liberando mémoria utilizada
        }
    }
}
