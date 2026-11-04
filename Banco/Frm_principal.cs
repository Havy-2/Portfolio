using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Frm_principal : Form
    {
        //cria um objeto e todos os atributos estão sem dados
        private Conta cliente = new Conta();
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_principal_Load(object sender, EventArgs e)
        {

        }
        public void limparDados()
        {
            Txb_titular.Clear();
            Txb_conta.Clear();
            Txb_saldo.Clear();
        }

        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (Txb_titular.Text != "" &&
                Txb_conta.Text != "" &&
                Txb_saldo.Text != "")
            {
                cliente.Titular = Txb_titular.Text;
                cliente.NumeroConta = int.Parse(Txb_conta.Text);
                cliente.Saldo = double.Parse(Txb_saldo.Text);
                MessageBox.Show("Cadastro realizado com sucesso");
                limparDados();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos do formulário.");
            }
        }

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();  // fecha a aplicação
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_saldo_Click(object sender, EventArgs e)
        {
            if (cliente.Titular != "")
            {
                MessageBox.Show("Saldo atual do cliente "+
                    cliente.Titular + " é R$" + cliente.Saldo);
            }
            else
            {
                MessageBox.Show("Não tem cliente cadastrado.");
            }
        }

        private void Btn_sacar_Click(object sender, EventArgs e)
        {
            if (cliente.Titular == "")
            {
                MessageBox.Show("Cliente não cadastrado.");
            }
            else
            {
                Frm_saque dados = new Frm_saque(cliente);
                dados.ShowDialog();
            }
        }

        private void Btn_depositar_Click(object sender, EventArgs e)
        {
            if (cliente.Titular == "")
            {
                MessageBox.Show("Cliente não cadastrado.");
            }
            else
            {
                Frm_deposito dados = new Frm_deposito(cliente);
                dados.ShowDialog();
            }
        }

        private void Btn_mostrar_Click(object sender, EventArgs e)
        {
            if (cliente.NumeroConta != 0 &&
                cliente.Titular != "")
            {
                Frm_dadosCliente dados = new Frm_dadosCliente(cliente);
                dados.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não há nada para mostrar.\n" +
                    " Cadastre um cliente.");
            }
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            limparDados();
        }
    }
}
