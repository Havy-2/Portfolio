using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BibliotecaEscolarForms.Dados;
using BibliotecaEscolarForms.Modelos;

namespace BibliotecaEscolarForms.Telas
{
    /// <summary>
    /// Tela Cadastro de Livros. É um formulário comum, desenhado no seu
    /// próprio Designer; o FormPrincipal o encaixa dentro do pnlConteudo.
    /// </summary>
    public partial class FormCadastros : Form
    {
        /// <summary>
        /// Evento que AVISA quem estiver interessado (o FormPrincipal) que a
        /// lista de livros mudou. O FormLivros não precisa saber quem vai
        /// ouvir o aviso — ele só "toca a campainha".
        /// </summary>
        public event EventHandler AcervoAlterado;

        /// <summary>Livro clicado na grade (null quando nenhum está selecionado).</summary>
        private Livro livroSelecionado;

        /// <summary>
        /// Construtor: monta os controles desenhados no Designer.
        /// </summary>
        public FormCadastros()
        {
            InitializeComponent();

            // Usamos as colunas criadas no Designer (com DataPropertyName),
            // em vez de deixar a grade inventar colunas sozinha.
            dgvProdutos.AutoGenerateColumns = false;
        }

        /// <summary>
        /// Ao abrir a tela, carrega a grade a partir do Acervo.
        /// </summary>
        private void FormLivros_Load(object sender, EventArgs e)
        {
            AtualizarGrade();
            LimparCampos();
        }

        /// <summary>
        /// Dispara o evento AcervoAlterado (se alguém estiver ouvindo).
        /// </summary>
        private void AvisarAcervoAlterado()
        {
            // ?. = "só chame Invoke se AcervoAlterado não for null",
            // ou seja, se algum outro formulário assinou o evento.
            AcervoAlterado?.Invoke(this, EventArgs.Empty);
        }

        // =================================================================
        #region Grade e campos
        // =================================================================

        /// <summary>
        /// Recarrega a grade aplicando o filtro da caixa de pesquisa.
        /// </summary>
        private void AtualizarGrade()
        {
            string termo = txtPesquisa.Text.Trim();

            // LINQ: filtra por título OU autor, sem diferenciar maiúsculas/minúsculas.
            List<Livro> resultado = Acervo.Livros
                .Where(livro => termo.Length == 0
                    || livro.Titulo.IndexOf(termo, StringComparison.OrdinalIgnoreCase) >= 0
                    || livro.Autor.IndexOf(termo, StringComparison.OrdinalIgnoreCase) >= 0)
                .OrderBy(livro => livro.Codigo)
                .ToList();

            // Atribuir null antes obriga a grade a "esquecer" a lista antiga e redesenhar.
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = resultado;
        }

        /// <summary>
        /// Deixa os campos prontos para um novo cadastro.
        /// </summary>
        private void LimparCampos()
        {
            livroSelecionado = null;
            txtCodigo.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            nudAno.Value = DateTime.Today.Year;
            nudMedida.Value = 1;
            dgvProdutos.ClearSelection();
        }

        /// <summary>
        /// Copia os dados de um livro para os campos do formulário.
        /// </summary>
        /// <param name="livro">Livro cujos dados serão exibidos.</param>
        private void PreencherCampos(Livro livro)
        {
            txtCodigo.Text = livro.Codigo.ToString("000");
            txtTitulo.Text = livro.Titulo;
            txtAutor.Text = livro.Autor;
            nudAno.Value = livro.Ano;
            nudMedida.Value = livro.Exemplares;
        }

        /// <summary>
        /// Quando o usuário clica em uma linha, o livro vai para os campos.
        /// </summary>
        private void dgvLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // RowIndex = -1 significa clique no cabeçalho da coluna: ignorar.
            if (e.RowIndex < 0)
            {
                return;
            }

            // DataBoundItem devolve o OBJETO Livro que está por trás da linha.
            livroSelecionado = (Livro)dgvProdutos.Rows[e.RowIndex].DataBoundItem;
            PreencherCampos(livroSelecionado);
        }

        /// <summary>
        /// Depois de carregar os dados, a grade seleciona a 1ª linha sozinha.
        /// Aqui desfazemos isso, para nada parecer selecionado sem clique.
        /// </summary>
        private void dgvLivros_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProdutos.ClearSelection();
        }

        /// <summary>
        /// Filtra a grade enquanto o usuário digita.
        /// </summary>
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrade();
            LimparCampos();
        }

        #endregion

        // =================================================================
        #region Botões Novo, Salvar, Alterar, Excluir
        // =================================================================

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtCodigo.Text = Acervo.ProximoCodigoLivro().ToString("000");
            txtTitulo.Focus(); // Cursor já piscando no primeiro campo.
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Salvar serve para livro NOVO. Livro já existente usa Alterar.
            if (livroSelecionado != null)
            {
                MessageBox.Show(
                    "Este livro já está cadastrado.\n" +
                    "Para modificá-lo, use o botão Alterar.\n" +
                    "Para cadastrar outro, clique em + Novo.",
                    "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // O construtor de Livro valida os dados e lança
                // ArgumentException se algo estiver errado.
                Livro novoLivro = new Livro(
                    Acervo.ProximoCodigoLivro(),
                    txtTitulo.Text,
                    txtAutor.Text,
                    (int)nudAno.Value,          // NumericUpDown.Value é decimal:
                    (int)nudMedida.Value);  // por isso o cast para int.

                Acervo.Livros.Add(novoLivro);
                AtualizarGrade();
                LimparCampos();
                AvisarAcervoAlterado(); // A barra de status do FormPrincipal é atualizada.

                MessageBox.Show("Livro cadastrado com sucesso!", "Salvar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Dados inválidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (livroSelecionado == null)
            {
                MessageBox.Show("Selecione um livro na lista antes de alterar.", "Alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Validamos tudo primeiro em um objeto temporário. Se algum dado
                // estiver errado, o livro original não fica "meio alterado".
                Livro dadosNovos = new Livro(
                    livroSelecionado.Codigo,
                    txtTitulo.Text,
                    txtAutor.Text,
                    (int)nudAno.Value,
                    (int)nudMedida.Value);

                livroSelecionado.Titulo = dadosNovos.Titulo;
                livroSelecionado.Autor = dadosNovos.Autor;
                livroSelecionado.Ano = dadosNovos.Ano;
                livroSelecionado.Exemplares = dadosNovos.Exemplares;

                AtualizarGrade();
                LimparCampos();
                AvisarAcervoAlterado();

                MessageBox.Show("Livro alterado com sucesso!", "Alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Dados inválidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (livroSelecionado == null)
            {
                MessageBox.Show("Selecione um livro na lista antes de excluir.", "Excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Exclusão não tem "desfazer": sempre confirme com o usuário.
            // MessageBoxDefaultButton.Button2 deixa o "Não" como padrão (mais seguro).
            DialogResult resposta = MessageBox.Show(
                "Excluir o livro \"" + livroSelecionado.Titulo + "\"?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
            {
                Acervo.Livros.Remove(livroSelecionado);
                AtualizarGrade();
                LimparCampos();
                AvisarAcervoAlterado();
            }
        }

        #endregion
    }
}
