using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandidatoEstagio
{
    public partial class Frm_Cadastro : Form
    {
        // cria um objeto e todos os atributos estão sem dados
        private Candidato candidato = new Candidato();

        public Frm_Cadastro()
        {
            InitializeComponent();
        }

        private void Frm_Cadastro_Load(object sender, EventArgs e)
        {
            TXT_idade.ReadOnly = true;
            TXT_idade.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RBT_engenharia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void limparDados()
        {
            TXT_nome.Clear();
            TXT_dia.Clear();
            TXT_mes.Clear();
            TXT_ano.Clear();
            TXT_idade.Clear();

            RBT_adm.Checked = false;
            RBT_computacao.Checked = false;
            RBT_engenharia.Checked = false;
            RBT_saude.Checked = false;

            CKB_matutino.Checked = false;
            CKB_vespertino.Checked = false;
            CKB_noturno.Checked = false;

            CMB_escolaridade.SelectedIndex = -1;
        }

        // idade é campo calculado em tempo de execução (não é gravada na classe)
        private void BTN_calcular_Click(object sender, EventArgs e)
        {
            if (TXT_dia.Text != "" && TXT_mes.Text != "" && TXT_ano.Text != "")
            {
                candidato.Dia = Convert.ToInt32(TXT_dia.Text);
                candidato.Mes = Convert.ToInt32(TXT_mes.Text);
                candidato.Ano = Convert.ToInt32(TXT_ano.Text);
                TXT_idade.Text = Convert.ToString(candidato.CalcularIdade());
            }
            else
            {
                MessageBox.Show("Preencha dia, mês e ano da data de nascimento.");
            }
        }

        // Passo 10 — Enviar: grava os dados no objeto (exceto a idade)
        private void BTN_enviar_Click(object sender, EventArgs e)
        {
            if (TXT_nome.Text != "" &&
                TXT_dia.Text != "" &&
                TXT_mes.Text != "" &&
                TXT_ano.Text != "" &&
                CMB_escolaridade.Text != "" &&
                (RBT_adm.Checked || RBT_computacao.Checked ||
                 RBT_engenharia.Checked || RBT_saude.Checked) &&
                (CKB_matutino.Checked || CKB_vespertino.Checked || CKB_noturno.Checked))
            {
                candidato.Nome = TXT_nome.Text;
                candidato.Dia = Convert.ToInt32(TXT_dia.Text);
                candidato.Mes = Convert.ToInt32(TXT_mes.Text);
                candidato.Ano = Convert.ToInt32(TXT_ano.Text);
                candidato.AreaAtuacao = ObterAreaAtuacao();
                candidato.Matutino = CKB_matutino.Checked;
                candidato.Vespertino = CKB_vespertino.Checked;
                candidato.Noturno = CKB_noturno.Checked;
                candidato.Escolaridade = CMB_escolaridade.Text;

                TXT_idade.Text = Convert.ToString(candidato.CalcularIdade());

                MessageBox.Show("Cadastro realizado com sucesso.\n\n" + candidato.ToString());
            }
            else
            {
                MessageBox.Show("Preencha todos os campos do formulário.");
            }
        }

        private void BTN_limpar_Click(object sender, EventArgs e)
        {
            limparDados();
            candidato = new Candidato();
        }

        private void BTN_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();  // fecha a aplicação
        }

        private string ObterAreaAtuacao()
        {
            if (RBT_adm.Checked)
            {
                return "Administração";
            }
            if (RBT_computacao.Checked)
            {
                return "Computação";
            }
            if (RBT_engenharia.Checked)
            {
                return "Engenharia";
            }
            if (RBT_saude.Checked)
            {
                return "Saúde";
            }
            return "";
        }
    }
}
