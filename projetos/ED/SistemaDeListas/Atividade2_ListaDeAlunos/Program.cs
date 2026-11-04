using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("========== ATIVIDADE 2 – LISTA DE ALUNOS ==========\n");

        List<string> alunos = new List<string>
        {
            "Ana Souza",
            "Bruno Lima",
            "Carla Mendes",
            "Diego Alves",
            "Elena Costa"
        };

        Console.WriteLine("Primeiro aluno: " + alunos[0]);
        Console.WriteLine("Último aluno: " + alunos[alunos.Count - 1]);

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
