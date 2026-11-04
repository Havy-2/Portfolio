using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("========== ATIVIDADE 3 – EDITANDO UMA LISTA ==========\n");

        List<string> frutas = new List<string>
        {
            "Maçã",
            "Banana",
            "Uva",
            "Laranja"
        };

        int indiceBanana = frutas.IndexOf("Banana");
        if (indiceBanana >= 0)
        {
            frutas[indiceBanana] = "Morango";
        }

        Console.WriteLine("Lista atualizada de frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine("- " + fruta);
        }

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
