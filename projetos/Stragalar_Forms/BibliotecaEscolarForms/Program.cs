using System;
using System.Windows.Forms;

namespace BibliotecaEscolarForms
{
    /// <summary>
    /// Ponto de entrada da aplicação. É aqui que o Windows começa a executar o programa.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Método principal: configura o visual e abre a janela principal.
        /// </summary>
        [STAThread] // Exigido pelo Windows Forms (área de transferência, diálogos etc.).
        private static void Main()
        {
            // Usa o visual moderno do Windows nos botões, caixas de texto etc.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Só o FormPrincipal é aberto aqui. As outras telas (FormLivros,
            // FormInicio...) são abertas DENTRO dele, pelo menu lateral.
            Application.Run(new FormPrincipal());
        }
    }
}
