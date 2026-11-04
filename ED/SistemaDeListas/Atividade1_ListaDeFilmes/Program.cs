using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("========== ATIVIDADE 1 – LISTA DE FILMES ==========\n");

        List<string> filmes = new List<string>();

        filmes.Add("Avatar");
        filmes.Add("Vingadores");
        filmes.Add("Matrix");
        filmes.Add("Interestelar");

        Console.WriteLine("Filmes cadastrados:");
        foreach (string filme in filmes)
        {
            Console.WriteLine("- " + filme);
        }

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
