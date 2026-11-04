using System;
using System.Windows.Forms;

namespace CandidatoEstagio
{
    public partial class Frm_Cadastro : Form
    {
        // Objeto que armazena os dados de um único candidato
        private Candidato candidato;

        public Frm_Cadastro()
        {
            InitializeComponent();
            candidato = new Candidato();
        }

        private void Frm_Cadastro_Load(object sender, EventArgs e)
        {
            cmbEscolaridade.Items.Clear();
            cmbEscolaridade.Items.Add("Médio");
            cmbEscolaridade.Items.Add("Técnico");
            cmbEscolaridade.Items.Add("Superior");
            cmbEscolaridade.SelectedIndex = -1;

            txtIdade.ReadOnly = true;
            txtIdade.Text = "";
        }

        // Botão Calcular — idade em tempo real (não é gravada na classe)
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dia, mes, ano;

            if (!int.TryParse(txtDia.Text, out dia) ||
                !int.TryParse(txtMes.Text, out mes) ||
                !int.TryParse(txtAno.Text, out ano))
            {
                MessageBox.Show("Informe dia, mês e ano válidos.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DataValida(dia, mes, ano))
            {
                MessageBox.Show("Data de nascimento inválida.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            candidato.Dia = dia;
            candidato.Mes = mes;
            candidato.Ano = ano;

            txtIdade.Text = candidato.CalcularIdade().ToString();
        }

        // Passo 10 — Enviar: grava os dados no objeto (exceto a idade)
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do candidato.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            int dia, mes, ano;
            if (!int.TryParse(txtDia.Text, out dia) ||
                !int.TryParse(txtMes.Text, out mes) ||
                !int.TryParse(txtAno.Text, out ano) ||
                !DataValida(dia, mes, ano))
            {
                MessageBox.Show("Data de nascimento inválida.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string area = ObterAreaAtuacao();
            if (area == "")
            {
                MessageBox.Show("Selecione a área de atuação.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chkMatutino.Checked && !chkVespertino.Checked && !chkNoturno.Checked)
            {
                MessageBox.Show("Selecione ao menos um turno de disponibilidade.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbEscolaridade.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a escolaridade.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            candidato = new Candidato();
            candidato.Nome = txtNome.Text.Trim();
            candidato.Dia = dia;
            candidato.Mes = mes;
            candidato.Ano = ano;
            candidato.AreaAtuacao = area;
            candidato.Matutino = chkMatutino.Checked;
            candidato.Vespertino = chkVespertino.Checked;
            candidato.Noturno = chkNoturno.Checked;
            candidato.Escolaridade = cmbEscolaridade.SelectedItem.ToString();

            // Atualiza a idade na tela (campo calculado, não persistido)
            txtIdade.Text = candidato.CalcularIdade().ToString();

            MessageBox.Show("Candidato cadastrado com sucesso!\n\n" + candidato.ToString(),
                "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Passo 10 — Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtDia.Clear();
            txtMes.Clear();
            txtAno.Clear();
            txtIdade.Clear();

            rdbAdministracao.Checked = false;
            rdbComputacao.Checked = false;
            rdbEngenharia.Checked = false;
            rdbSaude.Checked = false;

            chkMatutino.Checked = false;
            chkVespertino.Checked = false;
            chkNoturno.Checked = false;

            cmbEscolaridade.SelectedIndex = -1;

            candidato = new Candidato();
            txtNome.Focus();
        }

        // Passo 8 — Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja encerrar a aplicação?",
                "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private string ObterAreaAtuacao()
        {
            if (rdbAdministracao.Checked) return "Administração";
            if (rdbComputacao.Checked) return "Computação";
            if (rdbEngenharia.Checked) return "Engenharia";
            if (rdbSaude.Checked) return "Saúde";
            return "";
        }

        private bool DataValida(int dia, int mes, int ano)
        {
            try
            {
                DateTime data = new DateTime(ano, mes, dia);
                return data <= DateTime.Today;
            }
            catch
            {
                return false;
            }
        }
    }
}
