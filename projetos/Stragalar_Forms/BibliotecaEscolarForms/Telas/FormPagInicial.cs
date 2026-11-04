using System;
using System.Windows.Forms;
using BibliotecaEscolarForms.Dados;

namespace BibliotecaEscolarForms.Telas
{
    /// <summary>
    /// Tela inicial: boas-vindas e um resumo do acervo.
    /// </summary>
    public partial class FormPagInicial : Form
    {
        /// <summary>
        /// Construtor: monta os controles desenhados no Designer.
        /// </summary>
        public FormPagInicial()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ao carregar, lê o total de livros da classe Acervo (e não do FormLivros,
        /// que pode nem estar aberto).
        /// </summary>
        private void FormInicio_Load(object sender, EventArgs e)
        {
            lblResumo.Text = "Livros no acervo: " + Acervo.Livros.Count;
        }
    }
}
