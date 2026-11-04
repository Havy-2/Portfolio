using System.Collections.Generic;
using System.Linq;
using BibliotecaEscolarForms.Modelos;

namespace BibliotecaEscolarForms.Dados
{
    /// <summary>
    /// Guarda os dados do sistema enquanto o programa está aberto.
    /// <para>
    /// POR QUE OS DADOS NÃO FICAM DENTRO DO FormLivros?
    /// Cada vez que o usuário troca de tela, o formulário anterior é fechado
    /// e descartado — e tudo o que estava dentro dele é perdido. Por isso a
    /// lista fica aqui, em uma classe estática, que existe do início ao fim
    /// do programa. Na Unidade 5, esta classe será trocada pelo banco de dados.
    /// </para>
    /// </summary>
    public static class Acervo
    {
        /// <summary>
        /// Lista de livros cadastrados (já começa com alguns exemplos).
        /// </summary>
        public static List<Livro> Livros { get; } = new List<Livro>
        {
            new Livro(1, "Dom Casmurro", "Machado de Assis", 1899, 3),
            new Livro(2, "O Cortiço", "Aluísio Azevedo", 1890, 2),
            new Livro(3, "Capitães da Areia", "Jorge Amado", 1937, 4),
            new Livro(4, "Vidas Secas", "Graciliano Ramos", 1938, 1),
        };

        /// <summary>
        /// Calcula o próximo código livre (maior código + 1).
        /// </summary>
        /// <returns>O código a ser usado no próximo livro.</returns>
        public static int ProximoCodigoLivro()
        {
            return Livros.Count == 0 ? 1 : Livros.Max(livro => livro.Codigo) + 1;
        }
    }
}
