using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BibliotecaEscolarForms.Dados;
using BibliotecaEscolarForms.Telas;

namespace BibliotecaEscolarForms
{
    /// <summary>
    /// Janela principal do sistema: topo, menu lateral, barra de status e a
    /// área central (<c>pnlConteudo</c>).
    /// <para>
    /// IDEIA CENTRAL: cada tela do sistema é um FORMULÁRIO separado
    /// (FormInicio, FormLivros...), desenhado em seu próprio arquivo.
    /// Ao clicar em um botão do menu, o formulário da tela é "encaixado"
    /// dentro do pnlConteudo, em vez de abrir como uma janela solta.
    /// </para>
    /// <para>
    /// Analogia: o FormPrincipal é um videogame, o pnlConteudo é o encaixe
    /// do cartucho e cada formulário é um cartucho. Para trocar de jogo,
    /// tiramos um cartucho e encaixamos outro.
    /// </para>
    /// </summary>
    public partial class FormPrincipal : Form
    {
        // -----------------------------------------------------------------
        // Cores e fontes do menu lateral (em um lugar só, sem números mágicos).
        // -----------------------------------------------------------------
        private static readonly Color CorMenuFundo = Color.FromArgb(30, 58, 138);
        private static readonly Color CorMenuHover = Color.FromArgb(45, 75, 160);
        private static readonly Color CorMenuTexto = Color.White;
        private static readonly Color CorMenuAtivoFundo = Color.FromArgb(219, 234, 254);
        private static readonly Color CorMenuAtivoTexto = Color.FromArgb(30, 58, 138);
        private static readonly Font FonteMenuNormal = new Font("Segoe UI", 11F, FontStyle.Regular);
        private static readonly Font FonteMenuAtivo = new Font("Segoe UI", 11F, FontStyle.Bold);

        /// <summary>
        /// Formulário que está encaixado no pnlConteudo neste momento
        /// (null antes de abrir a primeira tela).
        /// </summary>
        private Form formularioAtivo;

        /// <summary>
        /// Construtor: monta os controles desenhados no Designer.
        /// </summary>
        public FormPrincipal()
        {
            // Cria todos os controles definidos em FormPrincipal.Designer.cs.
            // NUNCA apague esta linha: sem ela a janela abre vazia.
            InitializeComponent();
        }

        // =================================================================
        #region Inicialização
        // =================================================================

        /// <summary>
        /// Executado uma vez, quando a janela termina de carregar.
        /// </summary>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuário: " + Environment.UserName;
            AtualizarStatus();

            // Define qual tela aparece primeiro ao abrir o sistema.
            AbrirFormulario(new FormPagInicial(), btnPagInicial);
        }

        /// <summary>
        /// Atualiza a barra de status com o total de livros do acervo.
        /// </summary>
        private void AtualizarStatus()
        {
            lblTotalLivros.Text = "Total: " + Acervo.Livros.Count + " livros cadastrados";
        }

        #endregion

        // =================================================================
        #region Navegação: como os botões abrem os formulários
        // =================================================================

        /// <summary>
        /// Fecha a tela atual e encaixa um novo formulário dentro do pnlConteudo.
        /// É o "coração" da navegação: TODOS os botões do menu chamam este método.
        /// </summary>
        /// <param name="novoFormulario">Formulário (tela) que deve aparecer.</param>
        /// <param name="botaoSelecionado">Botão do menu que deve ficar destacado.</param>
        private void AbrirFormulario(Form novoFormulario, Button botaoSelecionado)
        {
            // PASSO 1 — Fecha a tela anterior. Close() também descarta o
            // formulário (libera memória) e o tira de dentro do pnlConteudo.
            if (formularioAtivo != null)
            {
                formularioAtivo.Close();
            }
            formularioAtivo = novoFormulario;

            // PASSO 2 — Transforma a janela em um "controle comum".
            // TopLevel = false: o formulário deixa de ser uma janela independente.
            // ATENÇÃO: precisa vir ANTES do Controls.Add, senão ocorre erro.
            novoFormulario.TopLevel = false;
            novoFormulario.FormBorderStyle = FormBorderStyle.None; // sem barra de título
            novoFormulario.Dock = DockStyle.Fill;                  // ocupa todo o encaixe

            // PASSO 3 — Encaixa no pnlConteudo e exibe.
            pnlConteudo.Controls.Add(novoFormulario);
            novoFormulario.Show(); // Sem Show() o formulário fica invisível.

            // PASSO 4 — Pinta o botão clicado para o usuário saber onde está.
            DestacarBotaoMenu(botaoSelecionado);
        }

        /// <summary>
        /// Volta todos os botões do menu ao visual normal e destaca apenas um.
        /// </summary>
        /// <param name="botaoSelecionado">Botão que representa a tela atual.</param>
        private void DestacarBotaoMenu(Button botaoSelecionado)
        {
            foreach (Button botao in pnlMenuLateral.Controls.OfType<Button>())
            {
                if (botao == btnSair)
                {
                    continue; // O botão Sair não participa do destaque.
                }

                botao.BackColor = CorMenuFundo;
                botao.ForeColor = CorMenuTexto;
                botao.Font = FonteMenuNormal;
                botao.FlatAppearance.MouseOverBackColor = CorMenuHover;
            }

            botaoSelecionado.BackColor = CorMenuAtivoFundo;
            botaoSelecionado.ForeColor = CorMenuAtivoTexto;
            botaoSelecionado.Font = FonteMenuAtivo;
            // Evita que o botão ativo "pisque" de cor ao passar o mouse.
            botaoSelecionado.FlatAppearance.MouseOverBackColor = CorMenuAtivoFundo;
        }

        // -----------------------------------------------------------------
        // Eventos Click do menu: cada um cria o formulário da tela e chama
        // AbrirFormulario. Um objeto NOVO é criado a cada clique; o anterior
        // é fechado dentro de AbrirFormulario.
        // -----------------------------------------------------------------

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPagInicial(), btnPagInicial);
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            FormCadastros formLivros = new FormCadastros();

            // "Assina" o aviso do FormLivros: sempre que um livro for salvo,
            // alterado ou excluído, o método abaixo é chamado.
            formLivros.AcervoAlterado += FormLivros_AcervoAlterado;

            AbrirFormulario(formLivros, btnCadastros);
        }

        private void btnLeitores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEstoque(), btnRelatorioss);
        }

        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEmprestimos(), btnCaixa);
        }

        private void btnDevolucoes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormCaixa(), btnEstoque);
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormRelatorios(), btnRelatorios);
        }

        /// <summary>
        /// Chamado pelo FormLivros quando o acervo muda: atualiza a barra de status.
        /// </summary>
        private void FormLivros_AcervoAlterado(object sender, EventArgs e)
        {
            AtualizarStatus();
        }

        /// <summary>
        /// Pede confirmação antes de fechar o sistema.
        /// </summary>
        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                "Deseja realmente sair do sistema?",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Close(); // Fecha a janela principal e, com ela, o programa.
            }
        }

        #endregion

        private void pnlTopo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTituloSistema_Click(object sender, EventArgs e)
        {

        }
    }
}
