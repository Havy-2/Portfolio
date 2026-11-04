using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CandidatoEstagio
{
    public partial class Frm_Cadastro : Form
    {
        private Candidato candidato = new Candidato();
        private CandidatoDAO dao = new CandidatoDAO();

        public Frm_Cadastro()
        {
            InitializeComponent();
        }

        private void Frm_Cadastro_Load(object sender, EventArgs e)
        {
            TXT_idade.ReadOnly = true;
            TXT_idade.Text = "";
            CMB_escolaridade.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void LimparCampos()
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
            candidato = new Candidato();
        }

        private void BTN_calcular_Click(object sender, EventArgs e)
        {
            int dia;
            int mes;
            int ano;
            if (int.TryParse(TXT_dia.Text.Trim(), out dia) &&
                int.TryParse(TXT_mes.Text.Trim(), out mes) &&
                int.TryParse(TXT_ano.Text.Trim(), out ano))
            {
                candidato.Dia = dia;
                candidato.Mes = mes;
                candidato.Ano = ano;
                TXT_idade.Text = Convert.ToString(candidato.CalcularIdade());
            }
            else
            {
                MessageBox.Show("Preencha dia, mês e ano da data de nascimento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_enviar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            candidato = new Candidato();
            candidato.Nome = TXT_nome.Text.Trim();
            candidato.Dia = int.Parse(TXT_dia.Text.Trim());
            candidato.Mes = int.Parse(TXT_mes.Text.Trim());
            candidato.Ano = int.Parse(TXT_ano.Text.Trim());
            candidato.AreaAtuacao = ObterAreaAtuacao();
            candidato.Matutino = CKB_matutino.Checked;
            candidato.Vespertino = CKB_vespertino.Checked;
            candidato.Noturno = CKB_noturno.Checked;
            candidato.Escolaridade = CMB_escolaridade.Text;
            TXT_idade.Text = Convert.ToString(candidato.CalcularIdade());

            try
            {
                int id = dao.Inserir(candidato);
                MessageBox.Show("Candidato cadastrado com sucesso! Código: " + id, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Não foi possível gravar no banco de dados. " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível gravar no banco de dados. " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void BTN_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool ValidarCampos()
        {
            if (TXT_nome.Text.Trim() == "")
            {
                MessageBox.Show("Informe o nome do candidato.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_nome.Focus();
                return false;
            }

            int dia;
            int mes;
            int ano;
            if (!int.TryParse(TXT_dia.Text.Trim(), out dia) ||
                !int.TryParse(TXT_mes.Text.Trim(), out mes) ||
                !int.TryParse(TXT_ano.Text.Trim(), out ano) ||
                ano < 1 || ano > 9999 ||
                mes < 1 || mes > 12 ||
                dia < 1 || dia > DateTime.DaysInMonth(ano, mes))
            {
                MessageBox.Show("Informe uma data de nascimento válida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_dia.Focus();
                return false;
            }

            DateTime nascimento = new DateTime(ano, mes, dia);
            if (nascimento > DateTime.Today)
            {
                MessageBox.Show("Informe uma data de nascimento válida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_dia.Focus();
                return false;
            }

            if (!RBT_adm.Checked && !RBT_computacao.Checked && !RBT_engenharia.Checked && !RBT_saude.Checked)
            {
                MessageBox.Show("Selecione a área de atuação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RBT_adm.Focus();
                return false;
            }

            if (!CKB_matutino.Checked && !CKB_vespertino.Checked && !CKB_noturno.Checked)
            {
                MessageBox.Show("Marque pelo menos um turno de disponibilidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CKB_matutino.Focus();
                return false;
            }

            if (CMB_escolaridade.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a escolaridade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMB_escolaridade.Focus();
                return false;
            }

            return true;
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
