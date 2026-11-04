using System;

namespace BibliotecaEscolarForms.Modelos
{
    /// <summary>
    /// Representa um livro do acervo da biblioteca.
    /// Esta classe NÃO sabe nada sobre telas: ela só guarda e valida os dados.
    /// (Separar "regra de negócio" de "interface" é uma boa prática.)
    /// </summary>
    public class Livro
    {
        // Campos privados (encapsulamento): só a própria classe acessa diretamente.
        private string titulo;
        private string autor;
        private int ano;
        private int exemplares;

        /// <summary>
        /// Cria um livro já validando todos os dados.
        /// </summary>
        /// <param name="codigo">Código do livro (ex.: 1 aparece como 001).</param>
        /// <param name="titulo">Título da obra.</param>
        /// <param name="autor">Nome do autor.</param>
        /// <param name="ano">Ano de publicação.</param>
        /// <param name="exemplares">Quantidade de exemplares disponíveis.</param>
        public Livro(int codigo, string titulo, string autor, int ano, int exemplares)
        {
            Codigo = codigo;
            Titulo = titulo;       // Passa pelo "set" da propriedade, que valida.
            Autor = autor;
            Ano = ano;
            Exemplares = exemplares;
        }

        /// <summary>Código do livro. Só pode ser definido dentro da classe.</summary>
        public int Codigo { get; private set; }

        /// <summary>Título do livro (obrigatório).</summary>
        public string Titulo
        {
            get { return titulo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O título do livro é obrigatório.");
                }
                titulo = value.Trim();
            }
        }

        /// <summary>Autor do livro (obrigatório).</summary>
        public string Autor
        {
            get { return autor; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome do autor é obrigatório.");
                }
                autor = value.Trim();
            }
        }

        /// <summary>Ano de publicação: de 1450 (prensa) até o ano atual.</summary>
        public int Ano
        {
            get { return ano; }
            set
            {
                if (value < 1450 || value > DateTime.Today.Year)
                {
                    throw new ArgumentException(
                        "O ano deve estar entre 1450 e " + DateTime.Today.Year + ".");
                }
                ano = value;
            }
        }

        /// <summary>Quantidade de exemplares (não pode ser negativa).</summary>
        public int Exemplares
        {
            get { return exemplares; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "A quantidade de exemplares não pode ser negativa.");
                }
                exemplares = value;
            }
        }
    }
}
