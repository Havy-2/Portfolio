using System;
using System.Windows.Forms;

namespace Stragalar
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Telas.FormLogin());
        }
    }
}
